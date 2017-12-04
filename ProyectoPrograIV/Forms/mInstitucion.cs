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
    public partial class mInstitucion : Form
    {
        public mInstitucion()
        {
            InitializeComponent();
        }

        #region Declaracion de variables
        private string vModo;
        #endregion

        #region Delcaracion de Metodos
        private void CargarLista()
        {
            CapaNegocios.Institucion vNeciosCredito = new CapaNegocios.Institucion();
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
                        vItem = new ListViewItem(vRow["IdInstitucion"].ToString());
                        vItem.SubItems.Add(vRow["NombreInstitucion"].ToString());
                        vItem.SubItems.Add(vRow["IdLote"].ToString());
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
            CapaEntidad.Estructura.Institucion vEntidad;
            CapaNegocios.Institucion vNegociosCreditos = new CapaNegocios.Institucion();
            try
            {
                if (Validar())
                {
                    vEntidad = new CapaEntidad.Estructura.Institucion()
                    {
                        IdInstitucion = Convert.ToInt32(lblId.Text),
                        NombreInstitucion = txtNombre.Text,
                        IdLote = Convert.ToInt32(txtLote.Text)
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

                if (txtLote.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Lote contiene un valor no válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                lblId.Text = "0";
                txtLote.Text = string.Empty;
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
                        txtLote.Enabled = true;
                        txtNombre.Enabled = true;
                        lblId.Visible = false;
                        lblIdInstitucion.Visible = false;
                        break;
                    case "B":
                        txtLote.Enabled = false;
                        txtNombre.Enabled = false;
                        lblId.Visible = true;
                        lblIdInstitucion.Visible = true;
                        break;
                    case "C":
                        txtLote.Enabled = false;
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
                    txtLote.Text = ltvCreditos.SelectedItems[0].SubItems[2].Text;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Declaracion de Eventos
        private void mInstitucion_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLista();
                tbpDatos.Parent = null;
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
        #endregion
    
    }
}
