using Microsoft.VisualBasic;
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
        CapaEntidad.Estructura.Credito vCreditoSeleccionado ;
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
                        CargarCombo(Convert.ToInt32(txtIdCliente.Text));
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

                if( vModo == "E") { 
                    if (vNegocioPlanilla.LeerPlanilla(vIdCredito).Rows.Count > 0)
                    {
                        if (MessageBox.Show("El credito seleccionado  contiene una planilla asociada,¿Desea continuar?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.No)
                        {
                            vResultado = false;
                        }
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

        private void CargarListaCreditos()
        {
            CapaNegocios.Credito vNeciosCredito = new CapaNegocios.Credito();
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
                        vItem = new ListViewItem(vRow["IdCredito"].ToString());
                        vItem.SubItems.Add(vRow["IdCliente"].ToString());
                        vItem.SubItems.Add(vRow["MontoAprobado"].ToString());
                        vItem.SubItems.Add(vRow["Tasa"].ToString());
                        vItem.SubItems.Add(vRow["Saldo"].ToString());
                        vItem.SubItems.Add(vRow["Cuota"].ToString());
                        vItem.SubItems.Add(vRow["Plazo"].ToString());
                        vItem.SubItems.Add(vRow["UltimaProyeccion"].ToString());
                        ltvCreditos.Items.Add(vItem);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void GenerarProyeccion()
        {
            List<CapaEntidad.Estructura.Proyeccion> vListaProyeccion = new List<CapaEntidad.Estructura.Proyeccion>();
            CapaNegocios.Planilla vNegocioPlanilla = new CapaNegocios.Planilla();
            CapaEntidad.Estructura.Proyeccion vProyeccion;
            decimal vSaldoAnterior = 0;
            decimal vTasa = 0;
            int vDias;
            DateTime vFecha = DateTime.Now.Date;
            DataTable dtPlanilla;
            int vCantidadRegistros = 0;
            decimal vSaldo = 0;
            decimal vSaldo2 = 0;
            try
            {   
                vSaldoAnterior = Math.Round(Convert.ToDecimal(txtMontoCredito.Text), 2);
                vTasa = Convert.ToDecimal(txtTasa.Text) / 100;
                if(vModo == "C")
                {
                    dtPlanilla=vNegocioPlanilla.LeerPlanilla(vIdCredito);
                    if (dtPlanilla.Rows.Count > 0)
                    {
                        vFecha = Convert.ToDateTime(dtPlanilla.Rows[0]["FechaCorte"].ToString());
                        vCantidadRegistros = dtPlanilla.Rows.Count;
                    }

                }
                for (int i = 0; i <= Convert.ToInt32(txtPlazo.Text); i++)
                {
                    if (i == 0)
                    {
                    vProyeccion = new CapaEntidad.Estructura.Proyeccion()
                    {
                        Cuota = 0,
                        MontoPrincipal = 0,
                        Interes = 0,
                        Saldo = vSaldoAnterior,
                        Pago= 0,
                        FechaCorte = vFecha,
                        NumeroCuota = i
                        };
                    }
                    else
                    {
                        vFecha = DateTime.Now.Date.AddMonths(i);
                        vDias = vFecha.Day;
                        if (vFecha.Month == 2)
                        {
                            vDias = 28 - vDias;
                        }
                        else
                        {
                            vDias = 30 - vDias;
                        }
                        vFecha=vFecha.AddDays(vDias);
                        vProyeccion = new CapaEntidad.Estructura.Proyeccion();
                        vProyeccion.Cuota = Convert.ToDecimal(txtCuota.Text);
                        vProyeccion.MontoPrincipal = Math.Round(vSaldoAnterior * vTasa, 2);
                        vProyeccion.Interes = Math.Round(Convert.ToDecimal(txtCuota.Text) - vProyeccion.MontoPrincipal, 2);
                        vProyeccion.Saldo = Math.Round(vSaldoAnterior - vProyeccion.Interes, 2);
                        vProyeccion.NumeroCuota = i;
                        vSaldoAnterior = Math.Round(vProyeccion.Saldo, 2);
                        vProyeccion.FechaCorte = vFecha;

                        if (vModo == "C" && i <= vCantidadRegistros)
                        {
                            vProyeccion.Pago = vProyeccion.Cuota;
                            vSaldo2 = vProyeccion.Saldo;
                        }
                        else
                        {
                            if (vModo == "C")
                            {
                                vSaldo = Math.Round(vSaldoAnterior - vProyeccion.Interes, 2);
                                vProyeccion.Saldo = vSaldo2;
                                vSaldoAnterior = Math.Round(vSaldo, 2);
                            }
                        }
                    }
                    vListaProyeccion.Add(vProyeccion);
                }
                dgvProyeccion.DataSource = vListaProyeccion;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void LimpiarCampos()
        {
            try
            {
                txtCliente.Text = string.Empty;
                txtIdCliente.Text = string.Empty;
                txtTasa.Text = string.Empty;
                txtMontoCredito.Text = string.Empty;
                txtPlazo.Text = string.Empty;
                txtCuota.Text = string.Empty;
                dgvProyeccion.Rows.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void DeshabilitarControles() {
            try
            {
                switch (vModo)
                {
                    case "A":
                        txtCliente.Enabled = true;
                        txtIdCliente.Enabled = true;
                        txtTasa.Enabled = true;
                        txtMontoCredito.Enabled = true;
                        txtPlazo.Enabled = true;
                        txtCuota.Enabled = true;
                        btnCalcularCuota.Enabled = true;
                        btnAceptar.Enabled = true;
                        btnProyeccion.Enabled = true;
                        cboEmpresa.Enabled = true;
                        break;
                    case "B":
                        txtCliente.Enabled = false;
                        txtIdCliente.Enabled = false;
                        txtTasa.Enabled = false;
                        txtMontoCredito.Enabled = false;
                        txtPlazo.Enabled = false;
                        txtCuota.Enabled = false;
                        cboEmpresa.Enabled = false;
                        btnCalcularCuota.Enabled = false;
                        btnAceptar.Enabled = true;
                        btnProyeccion.Enabled = false;
                        break;
                    case "C":
                        txtCliente.Enabled = false;
                        txtIdCliente.Enabled = false;
                        txtTasa.Enabled = false;
                        txtMontoCredito.Enabled = false;
                        txtPlazo.Enabled = false;
                        txtCuota.Enabled = false;
                        btnCalcularCuota.Enabled = false;
                        btnProyeccion.Enabled = true;
                        btnAceptar.Enabled = false;
                        cboEmpresa.Enabled = false;
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
                if (ltvCreditos.SelectedItems.Count > 0) {
                    vCreditoSeleccionado = new CapaEntidad.Estructura.Credito()
                    {
                        IdCredito = Convert.ToInt32(ltvCreditos.SelectedItems[0].SubItems[0].Text),
                        IdCliente = Convert.ToInt32(ltvCreditos.SelectedItems[0].SubItems[1].Text),
                        MontoAprobado = Convert.ToDecimal(ltvCreditos.SelectedItems[0].SubItems[2].Text),
                        Tasa= Convert.ToDecimal(ltvCreditos.SelectedItems[0].SubItems[3].Text),
                        Saldo = Convert.ToDecimal(ltvCreditos.SelectedItems[0].SubItems[4].Text),
                        Cuota = Convert.ToDecimal(ltvCreditos.SelectedItems[0].SubItems[5].Text),
                        Plazo = Convert.ToInt32(ltvCreditos.SelectedItems[0].SubItems[6].Text),
                        UltimaProyeccion = Convert.ToString(ltvCreditos.SelectedItems[0].SubItems[7].Text)
                    };

                    vIdCredito = vCreditoSeleccionado.IdCredito;
                    txtCliente.Text = vCreditoSeleccionado.IdCliente.ToString();
                    txtTasa.Text = vCreditoSeleccionado.Tasa.ToString();
                    txtMontoCredito.Text = vCreditoSeleccionado.MontoAprobado.ToString();
                    txtPlazo.Text = vCreditoSeleccionado.Plazo.ToString();
                    txtCuota.Text = vCreditoSeleccionado.Cuota.ToString();
                    CargarCliente(Convert.ToInt32(txtIdCliente.Text));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
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
                CargarListaCreditos();
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
                MessageBox.Show("El proceso a finalizado correctamente", "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCalcularCuota_Click(object sender, EventArgs e)
        {
            double CouotaCalculada;
            try
            {
                CouotaCalculada = Financial.Pmt((Convert.ToDouble(txtTasa.Text)/100 ), Convert.ToInt32(txtPlazo.Text), Convert.ToDouble(txtMontoCredito.Text));
                CouotaCalculada = Math.Abs(Math.Round(CouotaCalculada, 2));
                txtCuota.Text = Convert.ToString(CouotaCalculada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnProyeccion_Click(object sender, EventArgs e)
        {
            try
            {
                GenerarProyeccion();
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
                CargarListaCreditos();
                LimpiarCampos();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                vModo = "C";
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


        #endregion



    }
}
