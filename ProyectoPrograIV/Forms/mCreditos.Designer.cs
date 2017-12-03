namespace ProyectoPrograIV
{
    partial class mCreditos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbcInformacion = new System.Windows.Forms.TabControl();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.tbpDatos = new System.Windows.Forms.TabPage();
            this.gboInformacion = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMontoCredito = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.txtMontoCredito = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblInterés = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.dgvProyeccion = new System.Windows.Forms.DataGridView();
            this.colNumeroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoPrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.tbcInformacion.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            this.gboInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 61);
            this.panel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbcInformacion
            // 
            this.tbcInformacion.Controls.Add(this.tbpLista);
            this.tbcInformacion.Controls.Add(this.tbpDatos);
            this.tbcInformacion.Location = new System.Drawing.Point(12, 67);
            this.tbcInformacion.Name = "tbcInformacion";
            this.tbcInformacion.SelectedIndex = 0;
            this.tbcInformacion.Size = new System.Drawing.Size(771, 492);
            this.tbcInformacion.TabIndex = 14;
            // 
            // tbpLista
            // 
            this.tbpLista.Location = new System.Drawing.Point(4, 22);
            this.tbpLista.Name = "tbpLista";
            this.tbpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLista.Size = new System.Drawing.Size(763, 498);
            this.tbpLista.TabIndex = 0;
            this.tbpLista.Text = "Lista";
            this.tbpLista.UseVisualStyleBackColor = true;
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.gboInformacion);
            this.tbpDatos.Controls.Add(this.dgvProyeccion);
            this.tbpDatos.Location = new System.Drawing.Point(4, 22);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatos.Size = new System.Drawing.Size(763, 466);
            this.tbpDatos.TabIndex = 1;
            this.tbpDatos.Text = "Datos";
            this.tbpDatos.UseVisualStyleBackColor = true;
            // 
            // gboInformacion
            // 
            this.gboInformacion.Controls.Add(this.txtIdCliente);
            this.gboInformacion.Controls.Add(this.btnCalcular);
            this.gboInformacion.Controls.Add(this.lblMontoCredito);
            this.gboInformacion.Controls.Add(this.lblEmpresa);
            this.gboInformacion.Controls.Add(this.txtInteres);
            this.gboInformacion.Controls.Add(this.cboEmpresa);
            this.gboInformacion.Controls.Add(this.txtMontoCredito);
            this.gboInformacion.Controls.Add(this.txtCliente);
            this.gboInformacion.Controls.Add(this.lblInterés);
            this.gboInformacion.Controls.Add(this.lblCliente);
            this.gboInformacion.Controls.Add(this.lblPlazo);
            this.gboInformacion.Controls.Add(this.txtPlazo);
            this.gboInformacion.Location = new System.Drawing.Point(11, 7);
            this.gboInformacion.Name = "gboInformacion";
            this.gboInformacion.Size = new System.Drawing.Size(741, 116);
            this.gboInformacion.TabIndex = 24;
            this.gboInformacion.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::ProyectoPrograIV.Properties.Resources.configuracion_simbolo_de_interfaz_de_dos_ruedas_dentadas;
            this.btnCalcular.Location = new System.Drawing.Point(660, 75);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblMontoCredito
            // 
            this.lblMontoCredito.AutoSize = true;
            this.lblMontoCredito.Location = new System.Drawing.Point(424, 22);
            this.lblMontoCredito.Name = "lblMontoCredito";
            this.lblMontoCredito.Size = new System.Drawing.Size(76, 13);
            this.lblMontoCredito.TabIndex = 6;
            this.lblMontoCredito.Text = "Monto Crédito:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(24, 48);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 5;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(81, 72);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(258, 20);
            this.txtInteres.TabIndex = 11;
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(81, 45);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(258, 21);
            this.cboEmpresa.TabIndex = 4;
            // 
            // txtMontoCredito
            // 
            this.txtMontoCredito.Location = new System.Drawing.Point(506, 19);
            this.txtMontoCredito.Name = "txtMontoCredito";
            this.txtMontoCredito.Size = new System.Drawing.Size(229, 20);
            this.txtMontoCredito.TabIndex = 7;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(119, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(220, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // lblInterés
            // 
            this.lblInterés.AutoSize = true;
            this.lblInterés.Location = new System.Drawing.Point(24, 75);
            this.lblInterés.Name = "lblInterés";
            this.lblInterés.Size = new System.Drawing.Size(39, 13);
            this.lblInterés.TabIndex = 10;
            this.lblInterés.Text = "Interés";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(24, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente: ";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(424, 48);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(76, 13);
            this.lblPlazo.TabIndex = 8;
            this.lblPlazo.Text = "Plazo (Meses):";
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(506, 45);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(229, 20);
            this.txtPlazo.TabIndex = 9;
            // 
            // dgvProyeccion
            // 
            this.dgvProyeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumeroCuota,
            this.colMontoPrincipal,
            this.colCuota,
            this.colInteres,
            this.colPago,
            this.colSaldo});
            this.dgvProyeccion.Location = new System.Drawing.Point(11, 133);
            this.dgvProyeccion.Name = "dgvProyeccion";
            this.dgvProyeccion.RowHeadersVisible = false;
            this.dgvProyeccion.Size = new System.Drawing.Size(741, 320);
            this.dgvProyeccion.TabIndex = 23;
            // 
            // colNumeroCuota
            // 
            this.colNumeroCuota.DataPropertyName = "NumeroCuota";
            this.colNumeroCuota.HeaderText = "Número Cuota";
            this.colNumeroCuota.Name = "colNumeroCuota";
            this.colNumeroCuota.ReadOnly = true;
            this.colNumeroCuota.Width = 123;
            // 
            // colMontoPrincipal
            // 
            this.colMontoPrincipal.DataPropertyName = "MontoPrincipal";
            this.colMontoPrincipal.HeaderText = "Monto Principal";
            this.colMontoPrincipal.Name = "colMontoPrincipal";
            this.colMontoPrincipal.ReadOnly = true;
            this.colMontoPrincipal.Width = 123;
            // 
            // colCuota
            // 
            this.colCuota.HeaderText = "Cuota";
            this.colCuota.Name = "colCuota";
            this.colCuota.ReadOnly = true;
            this.colCuota.Width = 123;
            // 
            // colInteres
            // 
            this.colInteres.HeaderText = "Interés";
            this.colInteres.Name = "colInteres";
            this.colInteres.ReadOnly = true;
            this.colInteres.Width = 123;
            // 
            // colPago
            // 
            this.colPago.HeaderText = "Pago";
            this.colPago.Name = "colPago";
            this.colPago.ReadOnly = true;
            this.colPago.Width = 123;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            this.colSaldo.Width = 123;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(81, 19);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(35, 20);
            this.txtIdCliente.TabIndex = 14;
            // 
            // mCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 587);
            this.Controls.Add(this.tbcInformacion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "mCreditos";
            this.Text = "Form1";
            this.tbcInformacion.ResumeLayout(false);
            this.tbpDatos.ResumeLayout(false);
            this.gboInformacion.ResumeLayout(false);
            this.gboInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tbcInformacion;
        private System.Windows.Forms.TabPage tbpLista;
        private System.Windows.Forms.TabPage tbpDatos;
        private System.Windows.Forms.GroupBox gboInformacion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMontoCredito;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.TextBox txtMontoCredito;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblInterés;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.DataGridView dgvProyeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.TextBox txtIdCliente;
    }
}

