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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNumeroCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoPrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblMontoCredito = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblInterés = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumeroCuota,
            this.colMontoPrincipal,
            this.colCuota,
            this.colInteres,
            this.colPago,
            this.colSaldo});
            this.dataGridView1.Location = new System.Drawing.Point(30, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // colNumeroCuota
            // 
            this.colNumeroCuota.DataPropertyName = "NumeroCuota";
            this.colNumeroCuota.HeaderText = "Número Cuota";
            this.colNumeroCuota.Name = "colNumeroCuota";
            this.colNumeroCuota.ReadOnly = true;
            this.colNumeroCuota.Width = 174;
            // 
            // colMontoPrincipal
            // 
            this.colMontoPrincipal.DataPropertyName = "MontoPrincipal";
            this.colMontoPrincipal.HeaderText = "Monto Principal";
            this.colMontoPrincipal.Name = "colMontoPrincipal";
            this.colMontoPrincipal.ReadOnly = true;
            this.colMontoPrincipal.Width = 174;
            // 
            // colCuota
            // 
            this.colCuota.HeaderText = "Cuota";
            this.colCuota.Name = "colCuota";
            this.colCuota.ReadOnly = true;
            this.colCuota.Width = 174;
            // 
            // colInteres
            // 
            this.colInteres.HeaderText = "Interés";
            this.colInteres.Name = "colInteres";
            this.colInteres.ReadOnly = true;
            this.colInteres.Width = 174;
            // 
            // colPago
            // 
            this.colPago.HeaderText = "Pago";
            this.colPago.Name = "colPago";
            this.colPago.ReadOnly = true;
            this.colPago.Width = 174;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            this.colSaldo.Width = 175;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 66);
            this.panel1.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(56, 92);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente: ";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(131, 89);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(131, 115);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cboEmpresa.TabIndex = 4;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(56, 123);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 5;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblMontoCredito
            // 
            this.lblMontoCredito.AutoSize = true;
            this.lblMontoCredito.Location = new System.Drawing.Point(567, 89);
            this.lblMontoCredito.Name = "lblMontoCredito";
            this.lblMontoCredito.Size = new System.Drawing.Size(76, 13);
            this.lblMontoCredito.TabIndex = 6;
            this.lblMontoCredito.Text = "Monto Crédito:";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(649, 86);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(649, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(567, 123);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(76, 13);
            this.lblPlazo.TabIndex = 8;
            this.lblPlazo.Text = "Plazo (Meses):";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(649, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // lblInterés
            // 
            this.lblInterés.AutoSize = true;
            this.lblInterés.Location = new System.Drawing.Point(589, 164);
            this.lblInterés.Name = "lblInterés";
            this.lblInterés.Size = new System.Drawing.Size(39, 13);
            this.lblInterés.TabIndex = 10;
            this.lblInterés.Text = "Interés";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 616);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblInterés);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblPlazo);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lblMontoCredito);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblMontoCredito;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblInterés;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
    }
}

