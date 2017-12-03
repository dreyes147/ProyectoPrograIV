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
        #endregion
    }
}
