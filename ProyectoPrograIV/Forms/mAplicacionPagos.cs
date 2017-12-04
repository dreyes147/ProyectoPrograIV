using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProyectoPrograIV.Forms
{
    public partial class mAplicacionPagos : Form
    {
        public mAplicacionPagos()
        {
            InitializeComponent();
        }

        #region Declaracion de Variables
        DataTable dtDatos = new DataTable();
        #endregion

        #region Declaracion de Metodos


        public void CargarArchivoExcel(string pRuta)
        {
            CapaNegocios.Planilla vNegocioPlanilla = new CapaNegocios.Planilla();
            try
            {
                dtDatos = vNegocioPlanilla.LeerExcel(pRuta, "Hoja1");
                dgvDatos.DataSource = dtDatos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void CargarArchivoXml(string pRuta)
        {
            CapaNegocios.Planilla vNegocioPlanilla = new CapaNegocios.Planilla();
            DataSet dsDatos = new DataSet();
            string vXML = string.Empty;
            System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
            XmlNodeReader xmlNodedr;
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(pRuta);
                xmlNodedr = new XmlNodeReader(xDoc);   
                dsDatos.ReadXml(xmlNodedr);
                dgvDatos.DataSource = dsDatos.Tables[0];
                dtDatos = dsDatos.Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Declaracion de Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        { 
            try
            {
                openFileDialog.Filter = "Archivos de Excel (*.xls,*.xlsx)|*.xls;*.xlsx|Archivos XML (*.xml*)|*.xml*";
                openFileDialog.Title = "Seleccione un Archivo";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = openFileDialog.FileName;

                    if (System.IO.Path.GetExtension(openFileDialog.FileName).ToUpper() == ".XML")
                    {
                        CargarArchivoXml(openFileDialog.FileName);
                    }
                    else
                    {
                        CargarArchivoExcel(openFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            int vUltimaLinea;
            CapaEntidad.Estructura.Planilla vDatos;
            CapaNegocios.Planilla vNegocioPlanilla = new CapaNegocios.Planilla();
            try
            {
                if(dtDatos.Rows.Count>0 )
                {
                    vUltimaLinea = dtDatos.Rows.Count - 1;
                    vDatos = new CapaEntidad.Estructura.Planilla()
                    {
                        IdLote = Convert.ToInt32(dtDatos.Rows[0]["IdLote"].ToString()),
                        IdCliente = Convert.ToInt32(dtDatos.Rows[0]["IdCliente"].ToString()),
                        FechaCorte = Convert.ToDateTime(dtDatos.Rows[0]["FechaCorte"].ToString()),
                        IdCredito = Convert.ToInt32(dtDatos.Rows[0]["IdCredito"].ToString()),
                        CuotaCobrada = Convert.ToDecimal(dtDatos.Rows[0]["CuotaCobrada"].ToString()),
                        CuotaPaga = Convert.ToDecimal(dtDatos.Rows[0]["CuotaPaga"].ToString()),
                        SaldoPendiente = Convert.ToDecimal(dtDatos.Rows[0]["SaldoPendiente"].ToString()),
                        Amortizacion = Convert.ToDecimal(dtDatos.Rows[0]["Amortizacion"].ToString()),
                        Intereses = Convert.ToDecimal(dtDatos.Rows[0]["Intereses"].ToString()),
                        EstadoPlanilla = Convert.ToString(dtDatos.Rows[0]["EstadoPlanilla"].ToString()),
                        
                    };
                    vNegocioPlanilla.Insert(vDatos);
                    MessageBox.Show("El Proceso a finalizado de forma correcta");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }
    }
}
