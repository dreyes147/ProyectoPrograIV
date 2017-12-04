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
  public  class clsBuscarCliente
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



        public System.Data.DataTable SeleccionarCliente(int pID)
        {
            DataTable dtResultado = new DataTable("Datos");

            string vSQL = string.Empty;
            try
            {
                vSQL += "SELECT +'Identificación: '+CONVERT(varchar(10),IdCliente)+' ' +'Nombre del cliente: '+ Nombre+' '+ Apellido1 +' '+ Apellido2 as NombreC from Cliente where IdCliente = @Identificacion";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@Identificacion", SqlDbType.Int).Value = pID;
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


