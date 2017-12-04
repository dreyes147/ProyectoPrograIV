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


        public static class Globals
        {
            public const Int32 ID = 2; 

        }

        public String CargarRegistro(int a)
        {
            DataTable dtResultado = new DataTable("Datos");

            string vSQL = string.Empty;
            try
            {
                vSQL += "SELECT(SELECT Campo + ', '  FROM Estructura t2 WHERE t1.IdCliente =" + a + " AND t2.IdCliente = " + a + " ORDER BY t1.idCliente FOR XML PATH('')) AS Cadena FROM Estructura t1 WHERE t1.IdCliente = " + a + " GROUP BY t1.idcliente";
                // vSQL += "SELECT IdLote, IdCliente, FechaCorte, IdCredito, CuotaCobrada, CuotaPaga, SaldoPendiente, Amortizacion, Intereses, EstadoPlanilla from Planilla ";
                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                // vcmd.Parameters.Add("@Identificacion", SqlDbType.DateTime).Value = pFecha;
                vAdapter = new SqlDataAdapter(vcmd);
                vAdapter.Fill(dtResultado);
                CerrarConexion();
                var stringArr = dtResultado.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
                return stringArr[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }

        }

        public int EnviarID(int id)
        {
             
            return id;
        }


        public System.Data.DataTable CargarPlantilla(int a)
        {
            DataTable dtResultado = new DataTable("Datos");

            string vSQL = string.Empty;
            try
            {
                //vSQL += "SELECT (select left('" + CargarRegistro() + "', len('" + CargarRegistro() + "')-1)) from Planilla";

                vSQL += "SELECT  " + CargarRegistro(a) + " IdLote from Planilla Where IdCliente = "+a+"";
               // vSQL += "SELECT IdLote, IdCliente, FechaCorte, IdCredito, CuotaCobrada, CuotaPaga, SaldoPendiente, Amortizacion, Intereses, EstadoPlanilla from Planilla ";
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


