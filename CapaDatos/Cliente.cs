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
    public class Cliente
    {
        #region Declaracion de Constructor 

        public Cliente() { }

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

        public DataTable LeerCliente(int pIdCliente)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                string vSQL = string.Empty;

                vSQL += "SELECT ";
                vSQL += "IdCliente, ";
                vSQL += "Nombre +' '+ Apellido1 + ' ' + Apellido2 AS Nombre ";
                vSQL += "FROM dbo.Cliente ";
                vSQL += "where IdCliente = @IdCliente";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = pIdCliente;
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
                vSQL += "IdCliente, ";
                vSQL += "Nombre, ";
                vSQL += "Apellido1, ";
                vSQL += "Apellido2, ";
                vSQL += "IdInstitucion ";
                vSQL += "FROM dbo.Cliente";

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

        public void Insert(CapaEntidad.Estructura.Cliente pDatos)
        {
            try
            {
                string vSQL = string.Empty;
                vSQL += "DECLARE @Id INT ";
                vSQL += "SELECT @Id = ISNULL(MAX(IdInstitucion),0) + 1 FROM dbo.Cliente ";

                vSQL += " INSERT INTO dbo.Cliente(IdCliente, Nombre, Apellido1, Apellido2, IdInstitucion) ";
                vSQL += " VALUES(@Id, @Nombre, @Apellido1, @Apellido2, @IdInstitucion)";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = pDatos.Nombre;
                vcmd.Parameters.Add("@Apellido1", SqlDbType.VarChar).Value = pDatos.Apellido1;
                vcmd.Parameters.Add("@Apellido2", SqlDbType.VarChar).Value = pDatos.Apellido2;
                vcmd.Parameters.Add("@IdInstitucion", SqlDbType.Int).Value = pDatos.IdInstitucion;
                vcmd.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Update(CapaEntidad.Estructura.Cliente pDatos)
        {
            try
            {
                string vSQL = string.Empty;

                vSQL += " UPDATE dbo.Cliente ";
                vSQL += "   SET ";
                vSQL += "      Nombre = @Nombre";
                vSQL += "      ,Apellido1 = @Apellido1";
                vSQL += "      ,Apellido2 = @Apellido2";
                vSQL += "      ,IdInstitucion = @IdInstitucion";
                vSQL += "  WHERE IdCliente = @IdCliente ";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = pDatos.Nombre;
                vcmd.Parameters.Add("@Apellido1", SqlDbType.VarChar).Value = pDatos.Apellido1;
                vcmd.Parameters.Add("@Apellido2", SqlDbType.VarChar).Value = pDatos.Apellido2;
                vcmd.Parameters.Add("@IdInstitucion", SqlDbType.Int).Value = pDatos.IdInstitucion;
                vcmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = pDatos.IdCliente;
                vcmd.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Delete(CapaEntidad.Estructura.Cliente pDatos)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                string vSQL = string.Empty;

                vSQL += "DELETE FROM dbo.Cliente  ";
                vSQL += " WHERE IdCliente = @IdCliente ";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdCliente", SqlDbType.Int, 32).Value = pDatos.IdCliente;
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
