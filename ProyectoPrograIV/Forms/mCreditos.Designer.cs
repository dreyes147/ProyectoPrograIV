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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbcInformacion = new System.Windows.Forms.TabControl();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ltvCreditos = new System.Windows.Forms.ListView();
            this.colIdCredito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMontoAprobado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTasa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSaldoCre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCuotaCre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPlazoCre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUltimaProyeccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpDatos = new System.Windows.Forms.TabPage();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gboInformacion = new System.Windows.Forms.GroupBox();
            this.btnCalcularCuota = new System.Windows.Forms.Button();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.lblCuota = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnProyeccion = new System.Windows.Forms.Button();
            this.lblMontoCredito = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.txtMontoCredito = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblTasa = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.dgvProyeccion = new System.Windows.Forms.DataGridView();
            this.colNumeroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoPrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tbcInformacion.SuspendLayout();
            this.tbpLista.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            this.gboInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 61);
            this.panel1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(278, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mantenimiento de Créditos...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbcInformacion
            // 
            this.tbcInformacion.Controls.Add(this.tbpLista);
            this.tbcInformacion.Controls.Add(this.tbpDatos);
            this.tbcInformacion.Location = new System.Drawing.Point(12, 75);
            this.tbcInformacion.Name = "tbcInformacion";
            this.tbcInformacion.SelectedIndex = 0;
            this.tbcInformacion.Size = new System.Drawing.Size(771, 516);
            this.tbcInformacion.TabIndex = 14;
            // 
            // tbpLista
            // 
            this.tbpLista.Controls.Add(this.btnConsultar);
            this.tbpLista.Controls.Add(this.btnEliminar);
            this.tbpLista.Controls.Add(this.btnAgregar);
            this.tbpLista.Controls.Add(this.ltvCreditos);
            this.tbpLista.Location = new System.Drawing.Point(4, 22);
            this.tbpLista.Name = "tbpLista";
            this.tbpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLista.Size = new System.Drawing.Size(763, 490);
            this.tbpLista.TabIndex = 0;
            this.tbpLista.Text = "Lista";
            this.tbpLista.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(431, 430);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(350, 430);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(269, 430);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ltvCreditos
            // 
            this.ltvCreditos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdCredito,
            this.colIdCliente,
            this.ColMontoAprobado,
            this.colTasa,
            this.colSaldoCre,
            this.colCuotaCre,
            this.colPlazoCre,
            this.colUltimaProyeccion});
            this.ltvCreditos.GridLines = true;
            this.ltvCreditos.Location = new System.Drawing.Point(6, 6);
            this.ltvCreditos.MultiSelect = false;
            this.ltvCreditos.Name = "ltvCreditos";
            this.ltvCreditos.Size = new System.Drawing.Size(751, 398);
            this.ltvCreditos.TabIndex = 0;
            this.ltvCreditos.UseCompatibleStateImageBehavior = false;
            this.ltvCreditos.View = System.Windows.Forms.View.Details;
            // 
            // colIdCredito
            // 
            this.colIdCredito.Text = "Crédito";
            this.colIdCredito.Width = 99;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Text = "Id Cliente";
            this.colIdCliente.Width = 97;
            // 
            // ColMontoAprobado
            // 
            this.ColMontoAprobado.Text = "Monto Aprobado";
            this.ColMontoAprobado.Width = 127;
            // 
            // colTasa
            // 
            this.colTasa.Text = "Tasa";
            // 
            // colSaldoCre
            // 
            this.colSaldoCre.Text = "Saldo";
            this.colSaldoCre.Width = 92;
            // 
            // colCuotaCre
            // 
            this.colCuotaCre.Text = "Cuota";
            // 
            // colPlazoCre
            // 
            this.colPlazoCre.Text = "Plazo";
            this.colPlazoCre.Width = 98;
            // 
            // colUltimaProyeccion
            // 
            this.colUltimaProyeccion.Text = "Ultima Proyección";
            this.colUltimaProyeccion.Width = 114;
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.btnRegresar);
            this.tbpDatos.Controls.Add(this.btnAceptar);
            this.tbpDatos.Controls.Add(this.gboInformacion);
            this.tbpDatos.Controls.Add(this.dgvProyeccion);
            this.tbpDatos.Location = new System.Drawing.Point(4, 22);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatos.Size = new System.Drawing.Size(763, 490);
            this.tbpDatos.TabIndex = 1;
            this.tbpDatos.Text = "Datos";
            this.tbpDatos.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(413, 459);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 23);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(317, 459);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 23);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gboInformacion
            // 
            this.gboInformacion.Controls.Add(this.btnCalcularCuota);
            this.gboInformacion.Controls.Add(this.txtCuota);
            this.gboInformacion.Controls.Add(this.lblCuota);
            this.gboInformacion.Controls.Add(this.txtIdCliente);
            this.gboInformacion.Controls.Add(this.btnProyeccion);
            this.gboInformacion.Controls.Add(this.lblMontoCredito);
            this.gboInformacion.Controls.Add(this.lblEmpresa);
            this.gboInformacion.Controls.Add(this.txtTasa);
            this.gboInformacion.Controls.Add(this.cboEmpresa);
            this.gboInformacion.Controls.Add(this.txtMontoCredito);
            this.gboInformacion.Controls.Add(this.txtCliente);
            this.gboInformacion.Controls.Add(this.lblTasa);
            this.gboInformacion.Controls.Add(this.lblCliente);
            this.gboInformacion.Controls.Add(this.lblPlazo);
            this.gboInformacion.Controls.Add(this.txtPlazo);
            this.gboInformacion.Location = new System.Drawing.Point(11, 7);
            this.gboInformacion.Name = "gboInformacion";
            this.gboInformacion.Size = new System.Drawing.Size(741, 128);
            this.gboInformacion.TabIndex = 24;
            this.gboInformacion.TabStop = false;
            // 
            // btnCalcularCuota
            // 
            this.btnCalcularCuota.Location = new System.Drawing.Point(643, 71);
            this.btnCalcularCuota.Name = "btnCalcularCuota";
            this.btnCalcularCuota.Size = new System.Drawing.Size(92, 20);
            this.btnCalcularCuota.TabIndex = 17;
            this.btnCalcularCuota.Text = "Calcular Cuota";
            this.btnCalcularCuota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcularCuota.UseVisualStyleBackColor = true;
            this.btnCalcularCuota.Click += new System.EventHandler(this.btnCalcularCuota_Click);
            // 
            // txtCuota
            // 
            this.txtCuota.Enabled = false;
            this.txtCuota.Location = new System.Drawing.Point(506, 71);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(131, 20);
            this.txtCuota.TabIndex = 16;
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Location = new System.Drawing.Point(424, 74);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(38, 13);
            this.lblCuota.TabIndex = 15;
            this.lblCuota.Text = "Cuota:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(81, 19);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(35, 20);
            this.txtIdCliente.TabIndex = 14;
            this.txtIdCliente.Leave += new System.EventHandler(this.txtIdCliente_Leave);
            // 
            // btnProyeccion
            // 
            this.btnProyeccion.Image = global::ProyectoPrograIV.Properties.Resources.configuracion_simbolo_de_interfaz_de_dos_ruedas_dentadas;
            this.btnProyeccion.Location = new System.Drawing.Point(611, 97);
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Size = new System.Drawing.Size(124, 23);
            this.btnProyeccion.TabIndex = 13;
            this.btnProyeccion.Text = "Hacer Proyección";
            this.btnProyeccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProyeccion.UseVisualStyleBackColor = true;
            this.btnProyeccion.Click += new System.EventHandler(this.btnProyeccion_Click);
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
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(81, 72);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(258, 20);
            this.txtTasa.TabIndex = 11;
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
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Location = new System.Drawing.Point(24, 75);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(34, 13);
            this.lblTasa.TabIndex = 10;
            this.lblTasa.Text = "Tasa:";
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
            this.colFechaCorte,
            this.colMontoPrincipal,
            this.colCuota,
            this.colInteres,
            this.colPago,
            this.colSaldo});
            this.dgvProyeccion.Location = new System.Drawing.Point(11, 154);
            this.dgvProyeccion.Name = "dgvProyeccion";
            this.dgvProyeccion.RowHeadersVisible = false;
            this.dgvProyeccion.Size = new System.Drawing.Size(741, 299);
            this.dgvProyeccion.TabIndex = 23;
            // 
            // colNumeroCuota
            // 
            this.colNumeroCuota.DataPropertyName = "NumeroCuota";
            this.colNumeroCuota.HeaderText = "Número Cuota";
            this.colNumeroCuota.Name = "colNumeroCuota";
            this.colNumeroCuota.ReadOnly = true;
            this.colNumeroCuota.Width = 105;
            // 
            // colFechaCorte
            // 
            this.colFechaCorte.DataPropertyName = "FechaCorte";
            this.colFechaCorte.HeaderText = "FechaCorte";
            this.colFechaCorte.Name = "colFechaCorte";
            this.colFechaCorte.ReadOnly = true;
            this.colFechaCorte.Width = 105;
            // 
            // colMontoPrincipal
            // 
            this.colMontoPrincipal.DataPropertyName = "MontoPrincipal";
            this.colMontoPrincipal.HeaderText = "Monto Principal";
            this.colMontoPrincipal.Name = "colMontoPrincipal";
            this.colMontoPrincipal.ReadOnly = true;
            this.colMontoPrincipal.Width = 105;
            // 
            // colCuota
            // 
            this.colCuota.DataPropertyName = "Cuota";
            this.colCuota.HeaderText = "Cuota";
            this.colCuota.Name = "colCuota";
            this.colCuota.ReadOnly = true;
            this.colCuota.Width = 105;
            // 
            // colInteres
            // 
            this.colInteres.DataPropertyName = "Interes";
            this.colInteres.HeaderText = "Interés";
            this.colInteres.Name = "colInteres";
            this.colInteres.ReadOnly = true;
            this.colInteres.Width = 105;
            // 
            // colPago
            // 
            this.colPago.DataPropertyName = "Pago";
            this.colPago.HeaderText = "Pago";
            this.colPago.Name = "colPago";
            this.colPago.ReadOnly = true;
            this.colPago.Width = 105;
            // 
            // colSaldo
            // 
            this.colSaldo.DataPropertyName = "Saldo";
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            this.colSaldo.Width = 108;
            // 
            // mCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 619);
            this.Controls.Add(this.tbcInformacion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "mCreditos";
            this.Text = "Créditos";
            this.Load += new System.EventHandler(this.mCreditos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcInformacion.ResumeLayout(false);
            this.tbpLista.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnProyeccion;
        private System.Windows.Forms.Label lblMontoCredito;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.TextBox txtMontoCredito;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.DataGridView dgvProyeccion;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListView ltvCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.ColumnHeader colIdCredito;
        private System.Windows.Forms.ColumnHeader colIdCliente;
        private System.Windows.Forms.ColumnHeader ColMontoAprobado;
        private System.Windows.Forms.ColumnHeader colTasa;
        private System.Windows.Forms.ColumnHeader colSaldoCre;
        private System.Windows.Forms.ColumnHeader colCuotaCre;
        private System.Windows.Forms.ColumnHeader colPlazoCre;
        private System.Windows.Forms.ColumnHeader colUltimaProyeccion;
        private System.Windows.Forms.Button btnCalcularCuota;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}

