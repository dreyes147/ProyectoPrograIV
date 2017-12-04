using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Planilla
    {
        #region Declaracion de Constructor 
        public Planilla() { }
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
        public DataTable LeerPlanilla(int pIdCredito)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                string vSQL = string.Empty;

                vSQL += " SELECT IdLote";
                vSQL += "      , IdCliente";
                vSQL += "      , FechaCorte";
                vSQL += "      , IdCredito";
                vSQL += "      , CuotaCobrada";
                vSQL += "      , CuotaPaga";
                vSQL += "      , SaldoPendiente";
                vSQL += "      , Amortizacion";
                vSQL += "      , Intereses";
                vSQL += "      , EstadoPlanilla";
                vSQL += " FROM dbo.Planilla";
                vSQL += "WHERE (IdCredito = @IdCredito OR 0 = @IdCredito";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdCliente", SqlDbType.Int, 32).Value = pIdCredito;
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

        public DataTable LeerExcel(string filename, string sheetName)
        { 
            OleDbConnection dbConn = null;
            DataTable dtrResultTable = new DataTable(sheetName);
            string connString;
            try
            {   
                if (System.IO.Path.GetExtension(filename).ToUpper() == ".XLSX")
                {
                    connString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filename + "';Extended Properties=Excel 12.0;";
                }
                else
                {
                    connString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + filename + "';Extended Properties=Excel 8.0;";
                }

                dbConn = new OleDbConnection(connString);
                dbConn.Open();

                if (!sheetName.EndsWith("$"))
                {
                    sheetName += '$';
                }
                string query = string.Format("SELECT * FROM [{0}]", sheetName);
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, dbConn))
                {
                    adapter.Fill(dtrResultTable);
                }   
            }
            catch (Exception)
            {

                throw;
            }
            return dtrResultTable;
        }

        public void Insert(CapaEntidad.Estructura.Planilla pDatos)
        {
            DataTable dtResultado = new DataTable();
            try
            {
                string vSQL = string.Empty;

                vSQL += "INSERT INTO dbo.Planilla ";
                vSQL += "     (IdLote ";
                vSQL += "     , IdCliente  ";
                vSQL += "     , FechaCorte  ";
                vSQL += "     , IdCredito  ";
                vSQL += "     , CuotaCobrada   ";
                vSQL += "     , CuotaPaga   ";
                vSQL += "     , SaldoPendiente  ";
                vSQL += "     , Amortizacion  ";
                vSQL += "     , Intereses  ";
                vSQL += "     , EstadoPlanilla)  ";
                vSQL += " VALUES  ";
                vSQL += "     (@IdLote  ";
                vSQL += "     , @IdCliente  ";
                vSQL += "     , @FechaCorte  ";
                vSQL += "     , @IdCredito  ";
                vSQL += "     , @CuotaCobrada ";
                vSQL += "     , @CuotaPaga  ";
                vSQL += "     , @SaldoPendiente ";
                vSQL += "     , @Amortizacion  ";
                vSQL += "     , @Intereses  ";
                vSQL += "     , @EstadoPlanilla)   ";

                AbrirConexion();
                vcmd = new SqlCommand(vSQL, vConnection);
                vcmd.Parameters.Add("@IdLote", SqlDbType.Int, 32).Value = pDatos.IdLote ;
                vcmd.Parameters.Add("@IdCliente", SqlDbType.Int, 32).Value = pDatos.IdCliente ;
                vcmd.Parameters.Add("@FechaCorte", SqlDbType.Int, 32).Value = pDatos.FechaCorte ;
                vcmd.Parameters.Add("@IdCredito", SqlDbType.Int, 32).Value = pDatos.IdCredito ;
                vcmd.Parameters.Add("@CuotaCobrada", SqlDbType.Int, 32).Value = pDatos.CuotaCobrada ;
                vcmd.Parameters.Add("@CuotaPaga", SqlDbType.Int, 32).Value = pDatos.CuotaPaga ;
                vcmd.Parameters.Add("@SaldoPendiente", SqlDbType.Int, 32).Value = pDatos.SaldoPendiente ;
                vcmd.Parameters.Add("@Amortizacion", SqlDbType.Int, 32).Value = pDatos.Amortizacion ;
                vcmd.Parameters.Add("@Intereses", SqlDbType.Int, 32).Value = pDatos.Intereses ;
                vcmd.Parameters.Add("@EstadoPlanilla", SqlDbType.Int, 32).Value = pDatos.EstadoPlanilla ;
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
