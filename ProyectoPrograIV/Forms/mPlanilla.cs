using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
//using Excel = Microsoft.Office.Interop.Excel;


namespace ProyectoPrograIV.Forms
{
    public partial class mPlanilla : Form
    {
        public mPlanilla()
        {
            InitializeComponent();
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbTipoFile.Text == "TXT")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Text File|*.xml";
                var result = dialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;

                // setup for export
                dtgPlanilla.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                dtgPlanilla.SelectAll();
                // hiding row headers to avoid extra \t in exported text
                var rowHeaders = dtgPlanilla.RowHeadersVisible;
                dtgPlanilla.RowHeadersVisible = false;

                // ! creating text from grid values
                string content = dtgPlanilla.GetClipboardContent().GetText();

                // restoring grid state
                dtgPlanilla.ClearSelection();
                dtgPlanilla.RowHeadersVisible = rowHeaders;

                System.IO.File.WriteAllText(dialog.FileName, content);
                MessageBox.Show(@"Archivo creado");
            }
            else if (cmbTipoFile.Text == "EXCEL")
            {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "Reporte.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(dataGridView1, @"c:\export.xls");
                    ToCsV(dtgPlanilla, sfd.FileName); // Here dataGridview1 is your grid view name

                }
                else if (cmbTipoFile.Text == "XML")
                {
                   
                }

            }

        }


        private void Planilla_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            CapaEntidad.clsCargarPlantilla CargarDTG = new CapaEntidad.clsCargarPlantilla();
            DataTable dtBD = new DataTable();

            dtBD = CargarDTG.CargarPlantilla();
            dtgPlanilla.DataSource = dtBD;
        }
    }
    }
