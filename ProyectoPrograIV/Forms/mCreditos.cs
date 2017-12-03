using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIV
{
    public partial class mCreditos : Form
    {
        public mCreditos()
        {
            InitializeComponent();
        }
        #region Declaracion de Variables
        private string vModo = string.Empty;
        private int vIdCredito = 0;
        #endregion

        #region Declaracion de Metodos
        private void CargarCliente(int pIdCliente)
        {
            DataTable dtCliente = new DataTable();
            CapaNegocios.Cliente objNegocio = new CapaNegocios.Cliente();
            try
            {
                if (pIdCliente != 0)
                {
                    dtCliente = objNegocio.LeerCliente(pIdCliente);
                    if (dtCliente.Rows.Count >0 )
                    {
                        txtIdCliente.Text = dtCliente.Rows[0]["IdCliente"].ToString();
                        txtCliente.Text = dtCliente.Rows[0]["Nombre"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("El Id del cliente no pertenece a ningún registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void CargarCombo(int pIdCliente)
        {
            CapaNegocios.Institucion vNegocio = new CapaNegocios.Institucion();
            try
            {
                cboEmpresa.DataSource = vNegocio.LeerInstitucion(pIdCliente);
                cboEmpresa.ValueMember = "IdLote";
                cboEmpresa.DisplayMember = "NombreInstitucion";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void Aceptar()
        {
            CapaEntidad.Estructura.Credito vEntidad;
            CapaNegocios.Credito vNegociosCreditos= new CapaNegocios.Credito();
            int vIdCreditos =0 ;
            try
            {
                if (vModo != "A")
                {
                    vIdCreditos = vIdCredito;
                }
               
                if (Validar())
                {
                    vEntidad = new CapaEntidad.Estructura.Credito()
                    {
                        IdCredito = vIdCreditos,
                        IdCliente = Convert.ToInt32(txtIdCliente.Text),
                        Cuota = Convert.ToDecimal(txtCuota.Text),
                        Tasa = Convert.ToDecimal(txtTasa.Text),
                        MontoAprobado = Convert.ToDecimal(txtMontoCredito.Text),
                        Plazo = Convert.ToInt32(txtPlazo.Text),
                        Saldo = Convert.ToDecimal(txtMontoCredito.Text)
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
                if (txtIdCliente.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Id Cliente contiene un valor no válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vResultado = false;
                }

                if (txtTasa.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Tasa contiene un valor no válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vResultado = false;
                }

                if (txtMontoCredito.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Monto Crédito contiene un valor no válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vResultado = false;
                }

                if (txtPlazo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Plazo contiene un valor no válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vResultado = false;
                }

                if (txtCuota.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("El campo Plazo contiene un valor no válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vResultado = false;
                }

                if(vModo =="M"|| vModo == "E") { 
                    if (vNegocioPlanilla.LeerPlanilla(vIdCredito).Rows.Count > 0)
                    {
                        MessageBox.Show("No se puede realizar esta acción porque el credito ya contiene una planilla asociada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        vResultado = false;
                    }
                }

            }
            catch (Exception ex)
            {
                vResultado = false;
                throw new Exception(ex.Message, ex);
            }
            return vResultado;
        }

        #endregion

        #region Declaracion de Eventos


        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                CargarCliente(Convert.ToInt32(txtIdCliente.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mCreditos_Load(object sender, EventArgs e)
        {
            try
            {
                
                //CargarCombo(0);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion


    }
}
