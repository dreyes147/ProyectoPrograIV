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
    public partial class mCliente : Form
    {
        public mCliente()
        {
            InitializeComponent();
        }

        #region Declaracion de variables
        private string vModo;
        #endregion

        #region Delcaracion de Metodos
        private void CargarLista()
        {
            CapaNegocios.Cliente vNeciosCredito = new CapaNegocios.Cliente();
            DataTable dtCreditos = new DataTable();
            ListViewItem vItem;
            try
            {
                dtCreditos = vNeciosCredito.Select();
                ltvCreditos.Items.Clear();
                if (dtCreditos.Rows.Count > 0)
                {
                    foreach (DataRow vRow in dtCreditos.Rows)
                    {
                        vItem = new ListViewItem(vRow["IdCliente"].ToString());
                        vItem.SubItems.Add(vRow["Nombre"].ToString());
                        vItem.SubItems.Add(vRow["Apellido1"].ToString());
                        vItem.SubItems.Add(vRow["Apellido2"].ToString());
                        vItem.SubItems.Add(vRow["IdInstitucion"].ToString());
                        ltvCreditos.Items.Add(vItem);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void Aceptar()
        {
            CapaEntidad.Estructura.Cliente vEntidad;
            CapaNegocios.Cliente vNegociosCreditos = new CapaNegocios.Cliente();
            try
            {
                if (Validar())
                {
                    vEntidad = new CapaEntidad.Estructura.Cliente()
                    {
                        IdCliente = Convert.ToInt32(lblId.Text),
                        Nombre = txtNombre.Text,
                        Apellido1 = txtApellido1.Text,
                        Apellido2 = txtApellido2.Text,
                        IdInstitucion = Convert.ToInt32(cboInstitucion.SelectedValue.ToString())
                    };

                    switch (vModo)
                    {
                        case "A":
                            vNegociosCreditos.Insert(vEntidad);
                            break;
                        case "B":
                            vNegociosCreditos.Delete(vEntidad);
                            break;
                        case "M":
                            vNegociosCreditos.Update(vEntidad);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private bool Validar()
        {
            CapaNegocios.Planilla vNegocioPlanilla = new CapaNegocios.Planilla();
            bool vResultado = true;
            try
            {
                if (txtNombre.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Nombre contiene un valor no válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vResultado = false;
                }

                if (txtApellido1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Apellido1 contiene un valor no válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vResultado = false;
                }

                if (txtApellido2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Apellido2 contiene un valor no válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vResultado = false;
                }

            }
            catch (Exception ex)
            {
                vResultado = false;
                throw new Exception(ex.Message, ex);
            }
            return vResultado;
        }

        private void LimpiarCampos()
        {
            try
            {
                txtNombre.Text = string.Empty;
                txtApellido1.Text = string.Empty;
                txtApellido2.Text = string.Empty;
                lblId.Text = "0";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


        private void DeshabilitarControles()
        {
            try
            {
                switch (vModo)
                {
                    case "A":
                        txtApellido1.Enabled = true;
                        txtApellido2.Enabled = true;
                        cboInstitucion.Enabled = true;
                        txtNombre.Enabled = true;
                        lblId.Visible = false;
                        lblIdInstitucion.Visible = false;
                        break;
                    case "B":
                        txtApellido1.Enabled = false;
                        txtApellido2.Enabled = false;
                        cboInstitucion.Enabled = false;
                        txtNombre.Enabled = false;
                        lblId.Visible = true;
                        lblIdInstitucion.Visible = true;
                        break;
                    case "C":
                        txtApellido1.Enabled = false;
                        txtApellido2.Enabled = false;
                        cboInstitucion.Enabled = false;
                        txtNombre.Enabled = false;
                        lblId.Visible = true;
                        lblIdInstitucion.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void CargarControles()
        {
            try
            {
                if (ltvCreditos.SelectedItems.Count > 0)
                {
                    lblId.Text = ltvCreditos.SelectedItems[0].SubItems[0].Text;
                    txtNombre.Text = ltvCreditos.SelectedItems[0].SubItems[1].Text;
                    txtApellido1.Text = ltvCreditos.SelectedItems[0].SubItems[2].Text;
                    txtApellido2.Text = ltvCreditos.SelectedItems[0].SubItems[3].Text;
                    cboInstitucion.SelectedValue = ltvCreditos.SelectedItems[0].SubItems[4].Text;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void CargarCombo()
        {
            CapaNegocios.Institucion vNegocioInstitucion = new CapaNegocios.Institucion();
            DataTable dtDatos = new DataTable();
            try
            {
                dtDatos = vNegocioInstitucion.Select();
                cboInstitucion.DataSource = dtDatos;
                cboInstitucion.DisplayMember = "NombreInstitucion";
                cboInstitucion.ValueMember = "IdInstitucion";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }   

        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                vModo = "A";
                DeshabilitarControles();
                tbpDatos.Parent = tbcInformacion;
                tbcInformacion.SelectTab(tbpDatos);
                tbpLista.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vModo = "M";
                tbpDatos.Parent = tbcInformacion;
                CargarControles();
                tbcInformacion.SelectTab(tbpDatos);
                tbpLista.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                vModo = "B";
                tbpDatos.Parent = tbcInformacion;
                DeshabilitarControles();
                CargarControles();
                tbcInformacion.SelectTab(tbpDatos);
                tbpLista.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Aceptar();
                LimpiarCampos();
                MessageBox.Show("El proceso a finalizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
                CargarLista();
                tbpLista.Parent = tbcInformacion;
                tbcInformacion.SelectTab(tbpLista);
                tbpDatos.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mCliente_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLista();
                CargarCombo();
                tbpDatos.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
