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
    public class Institucion
    {
        #region Declaracion de Constructor 
        public Institucion() { }
        #endregion

        #region Declaracion de Variables
        SqlConnection vConnection;
        SqlCommand vcmd;
        SqlDataReader vReader;
        SqlDataAdapter vAdapter;
        #endregion

        #region Declaracion de Metodos

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
        public DataTable LeerInstitucion(int pInstitucion)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                string vSQL = string.Empty;

                vSQL += "SELECT ";
                vSQL += "IdInstitucion, ";
                vSQL += "NombreInstitucion ";
                vSQL += "FROM dbo.Institucion";
                vSQL += "where IdInstitucion = @IdInstitucion";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdInstitucion", SqlDbType.Int).Value = pInstitucion;
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
        #endregion
    }


}
