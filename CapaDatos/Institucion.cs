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
        public DataTable LeerInstitucion(int pIdCliente)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                string vSQL = string.Empty;

                vSQL += "SELECT ";
                vSQL += "INS.IdInstitucion, ";
                vSQL += "INS.IdLote, ";
                vSQL += "INS.NombreInstitucion ";
                vSQL += "FROM dbo.Institucion INS ";
                vSQL += "INNER JOIN dbo.Cliente CLI ON ";
                vSQL += "CLI.IdInstitucion = INS.IdInstitucion ";
                vSQL += "WHERE (CLI.IdCliente = @IdCliente OR 0 = @IdCliente)";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdCliente", SqlDbType.Int, 32).Value = pIdCliente;
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

        public DataTable Select()
        {
            DataTable dtResultado = new DataTable();
            try
            {
                string vSQL = string.Empty;

                vSQL += "SELECT ";
                vSQL += "INS.IdInstitucion, ";
                vSQL += "INS.IdLote, ";
                vSQL += "INS.NombreInstitucion ";
                vSQL += "FROM dbo.Institucion INS ";

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

        public void Insert(CapaEntidad.Estructura.Institucion pDatos)
        {
            try
            {
                string vSQL = string.Empty;
                vSQL += "DECLARE @Id INT ";
                vSQL += "SELECT @Id = ISNULL(MAX(IdInstitucion),0) + 1 FROM dbo.Institucion ";

                vSQL += " INSERT INTO dbo.Institucion(IdInstitucion, NombreInstitucion, IdLote) ";
                vSQL += " VALUES(@Id, @NombreInstitucion, @IdLote)";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@NombreInstitucion", SqlDbType.VarChar).Value = pDatos.NombreInstitucion;
                vcmd.Parameters.Add("@IdLote", SqlDbType.Int).Value = pDatos.IdLote;
                vcmd.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Update(CapaEntidad.Estructura.Institucion pDatos)
        {
            try
            {
                string vSQL = string.Empty;

                vSQL += " UPDATE dbo.Institucion ";
                vSQL += "   SET ";
                vSQL += "      NombreInstitucion = @NombreInstitucion";
                vSQL += "      ,IdLote = @IdLote";
                vSQL += "  WHERE IdInstitucion = @IdInstitucion ";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdInstitucion", SqlDbType.Int).Value = pDatos.IdInstitucion;
                vcmd.Parameters.Add("@NombreInstitucion", SqlDbType.VarChar).Value = pDatos.NombreInstitucion;
                vcmd.Parameters.Add("@IdLote", SqlDbType.Int).Value = pDatos.IdLote;
                vcmd.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Delete(CapaEntidad.Estructura.Institucion pDatos)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                string vSQL = string.Empty;

                vSQL += "DELETE FROM dbo.Institucion  ";
                vSQL += " WHERE IdInstitucion = @IdInstitucion ";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdInstitucion", SqlDbType.Int, 32).Value = pDatos.IdInstitucion;
                vcmd.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion
    }


}
