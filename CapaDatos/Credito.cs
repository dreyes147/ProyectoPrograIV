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
    public class Credito
    {

        #region Declaracion de Constructor 

        public Credito() { }

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

        public DataTable Select()
        {
            DataTable dtResultado = new DataTable();
            try
            {
                string vSQL = string.Empty;

                vSQL += "SELECT IdCredito ";
                vSQL += "      ,IdCliente ";
                vSQL += "      ,MontoAprobado ";
                vSQL += "      ,Tasa ";
                vSQL += "      ,Saldo ";
                vSQL += "      ,Cuota ";
                vSQL += "      ,Plazo ";
                vSQL += "      ,UltimaProyeccion ";
                vSQL += "FROM dbo.Credito ";
               
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

        public void Insert(CapaEntidad.Estructura.Credito pDatos)
        {
            try
            {
                string vSQL = string.Empty;
                vSQL += "DECLARE @Id INT ";
                vSQL += "SELECT ISNULL(MAX(IdCredito),0) + 1 FROM dbo.Credito ";
                vSQL += "INSERT INTO dbo.Credito (IdCredito,IdCliente,MontoAprobado,Tasa,Saldo,Cuota,Plazo,UltimaProyeccion) ";
                vSQL += "VALUES(@Id, @IdCliente, @MontoAprobado, @Tasa, @Saldo, @Cuota, @Plazo, @UltimaProyeccion ) ";
                
                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = pDatos.IdCliente;
                vcmd.Parameters.Add("@MontoAprobado", SqlDbType.Decimal).Value = pDatos.MontoAprobado;
                vcmd.Parameters.Add("@Tasa", SqlDbType.Int).Value = pDatos.Tasa;
                vcmd.Parameters.Add("@Saldo", SqlDbType.Decimal).Value = pDatos.Saldo;
                vcmd.Parameters.Add("@Cuota", SqlDbType.Decimal).Value = pDatos.Cuota;
                vcmd.Parameters.Add("@Plazo", SqlDbType.Int).Value = pDatos.Plazo;
                vcmd.Parameters.Add("@UltimaProyeccion", SqlDbType.VarChar).Value = pDatos.UltimaProyeccion;
                vcmd.ExecuteNonQuery();
               
                CerrarConexion();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public void Update(CapaEntidad.Estructura.Credito pDatos)
        {
            try
            {
                string vSQL = string.Empty;

                vSQL += "UPDATE dbo.Credito ";
                vSQL += "SET ";
                vSQL += "   ,IdCliente = @IdCliente ";
                vSQL += "   ,MontoAprobado = @MontoAprobado ";
                vSQL += "   ,Tasa = @Tasa ";
                vSQL += "   ,Saldo = @Saldo ";
                vSQL += "   ,Cuota = @Cuota ";
                vSQL += "   ,Plazo = @Plazo ";
                vSQL += "   ,UltimaProyeccion = @UltimaProyeccion ";
                vSQL += "WHERE  IdCredito = @IdCredito ";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdCredito", SqlDbType.Int).Value = pDatos.IdCredito;
                vcmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = pDatos.IdCliente;
                vcmd.Parameters.Add("@MontoAprobado", SqlDbType.Decimal).Value = pDatos.MontoAprobado;
                vcmd.Parameters.Add("@Tasa", SqlDbType.Int).Value = pDatos.Tasa;
                vcmd.Parameters.Add("@Saldo", SqlDbType.Decimal).Value = pDatos.Saldo;
                vcmd.Parameters.Add("@Cuota", SqlDbType.Decimal).Value = pDatos.Cuota;
                vcmd.Parameters.Add("@Plazo", SqlDbType.Int).Value = pDatos.Plazo;
                vcmd.Parameters.Add("@UltimaProyeccion", SqlDbType.VarChar).Value = pDatos.UltimaProyeccion;
                vcmd.ExecuteNonQuery();

                CerrarConexion();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public void Delete(CapaEntidad.Estructura.Credito pDatos)
        {
            try
            {
                string vSQL = string.Empty;

                vSQL += "DELETE FROM dbo.Credito ";
                vSQL += "WHERE  IdCredito = @IdCredito ";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdCredito", SqlDbType.Int).Value = pDatos.IdCredito;
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
