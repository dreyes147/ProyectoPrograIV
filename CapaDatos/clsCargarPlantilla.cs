using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
  public  class clsCargarPlantilla
    {

        SqlConnection vConnection;
        SqlCommand vcmd;
       // SqlDataReader vReader;
        SqlDataAdapter vAdapter;



        private void AbrirConexion()
        {
            string vInstancia = string.Empty;
            try
            {
                vInstancia = ConfigurationManager.ConnectionStrings["BaseDatos"].ConnectionString;
                vConnection = new SqlConnection(vInstancia);
                vConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        private void CerrarConexion()
        {
            string vInstancia = string.Empty;
            try
            {
                vConnection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }


        public string CargarRegistro()
        {
            var myString = "";
            string vSQL = string.Empty;
           
            try
            {

                vSQL += "SELECT t1.IdCliente, ( SELECT Campo+ ', '  FROM Estructura t2 WHERE t1.idcliente = t2.IdCliente ORDER BY t1.idCliente FOR XML PATH('') ) AS Dias FROM Estructura t1 GROUP BY t1.idcliente";
                vcmd = new SqlCommand(vSQL, vConnection);
           
                AbrirConexion();


                using (SqlDataReader dr = vcmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return dr.GetString(0);
                    }
                    else
                    {
                        return ""; // some value to indicate a missing record
                                   // or throw an exception
                    }
                    return myString;

                }

            CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);


            }

        }


        public System.Data.DataTable CargarPlantilla()
        {
            DataTable dtResultado = new DataTable("Datos");

            string vSQL = string.Empty;
            try
            {
                vSQL += "SELECT '"+CargarRegistro()+"' from Planilla";
                //vSQL += "SELECT IdLote, IdCliente, FechaCorte, IdCredito, CuotaCobrada, CuotaPaga, SaldoPendiente, Amortizacion, Intereses, EstadoPlanilla from Planilla where FechaCorte = @pFecha";
                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
               // vcmd.Parameters.Add("@Identificacion", SqlDbType.DateTime).Value = pFecha;
                vAdapter = new SqlDataAdapter(vcmd);
                vAdapter.Fill(dtResultado);
                CerrarConexion();
                return dtResultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
                
            }
            
        }



    }
}


