using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIV.Forms
{
    public partial class mEstructura : Form
    {
        int IdCliente = 0;
        public mEstructura()
        {
            InitializeComponent();
        }

        private void mEstructura_Load(object sender, EventArgs e)
        {
            CapaEntidad.clsEstructura CargarCMB = new CapaEntidad.clsEstructura();


            DataTable dtCMB = new DataTable();

            dtCMB = CargarCMB.CargarEstructura();
            cmbEstruc.ValueMember = "COLUMN_NAME";
            cmbEstruc.DataSource = dtCMB;
        }



        List<String> data = new List<string>()
        {
            "First",
            "Second",
            "Third",
            "Fourth"
        };

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int a = 0;

            for (int i = 0; i < dtgEstructura.Rows.Count; i++)
            {
                for (int j = 0; j < dtgEstructura.Columns.Count; j++)
                {
                    if (dtgEstructura.Rows[i].Cells[j].Value != null && cmbEstruc.Text == dtgEstructura.Rows[i].Cells[j].Value.ToString())
                    {
                        MessageBox.Show("El campo ya existe en el registro");
                        a = 1;
                        break;
                    }
                   
                }
            }
            if (a!=1)
            {
                this.dtgEstructura.Rows.Add(cmbEstruc.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dtgEstructura.SelectedRows.Count > 0)
            {
                dtgEstructura.Rows.RemoveAt(this.dtgEstructura.SelectedRows[0].Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(txtBuscarC.Text=="")
            {
                MessageBox.Show("Por favor digite el número de identificación que desea buscar");
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtBuscarC.Text, "[^0-9]"))
                {
                    MessageBox.Show("Por favor digite solamente números sin comillas ''");
                    txtBuscarC.Text = txtBuscarC.Text.Remove(txtBuscarC.Text.Length - 1);
                }
                else
                {
                    CapaEntidad.clsBuscarCliente CargarCMB = new CapaEntidad.clsBuscarCliente();


                    DataTable dtCMB = new DataTable();

                    dtCMB = CargarCMB.SeleccionarCliente(int.Parse(txtBuscarC.Text));
                    IdCliente = int.Parse(txtBuscarC.Text);
                    // lblNombre.ValueMember = "NombreC";


                    if (dtCMB != null)
                    {
                        if (dtCMB.Rows.Count > 0)
                        {
                            lblNombre.Text = dtCMB.Rows[0]["NombreC"].ToString();
                            groupBox1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Por favor digite una idenficación válida");
                        }
                    }


                    
                }
            }
            

           
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            


            StringBuilder sb = new StringBuilder();

            int valid = 0;
            foreach (DataGridViewRow row in dtgEstructura.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    CapaEntidad.clsGuardarEstructura InsertDATA = new CapaEntidad.clsGuardarEstructura();


                    //sb.Append(cell.Value);

                    if (dtgEstructura.Rows.Count == 0)
                    {
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(cell.Value.ToString()) || cell.Value.ToString().Trim().Length == 0 || cell.Value.ToString() == null)
                        {
                            
                        }
                        else
                        {
                             valid = 1;
                            InsertDATA.InsertarEstructura(cell.Value.ToString(), IdCliente);
                            
                        }
                        
                    }
                    
                        
                }
                
                
                

            }

            if (valid == 1)
            {
                MessageBox.Show("Datos agregados correctamente");
                valid = 0;
            }
            else
            {
                MessageBox.Show("No se ha podido ingresar ningún, verifique e intente nuevamente");
                valid = 0;
            }



            //InsertDATA.InsertarEstructura("ID", IdCliente);




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text File|*.txt";
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            // setup for export
            dtgEstructura.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dtgEstructura.SelectAll();
            // hiding row headers to avoid extra \t in exported text
            var rowHeaders = dtgEstructura.RowHeadersVisible;
            dtgEstructura.RowHeadersVisible = false;

            // ! creating text from grid values
            string content = dtgEstructura.GetClipboardContent().GetText();

            // restoring grid state
            dtgEstructura.ClearSelection();
            dtgEstructura.RowHeadersVisible = rowHeaders;

            System.IO.File.WriteAllText(dialog.FileName, content);
            MessageBox.Show(@"Text file was created.");
        }
    }
}
