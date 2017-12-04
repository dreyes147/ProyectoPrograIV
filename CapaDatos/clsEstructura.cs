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
  public  class clsEstructura
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

        public System.Data.DataTable Selecccionar(int pID)
        {
            DataTable dtResultado = new DataTable("Datos");
            string vSQL = string.Empty;
            try
            {
                vSQL += "SELECT ";
                vSQL += "IdPersona ";
                vSQL += ",IdTipoPersona ";
                vSQL += ",IdTipoCliente ";
                vSQL += "FROM dbo.CLIENTE";
                vSQL += "where Identificacion = @Identificacion";


                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@Identificacion", SqlDbType.Int).Value = pID;
                vAdapter = new SqlDataAdapter(vcmd);
                vAdapter.Fill(dtResultado);
                CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }

        public System.Data.DataTable CargarPlanilla()
        {
            DataTable dtResultado = new DataTable("Datos");
            string vSQL = string.Empty;
            try
            {
                vSQL += "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Planilla'";


                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
 
                vAdapter = new SqlDataAdapter(vcmd);
                vAdapter.Fill(dtResultado);
                CerrarConexion();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }

    }
}


