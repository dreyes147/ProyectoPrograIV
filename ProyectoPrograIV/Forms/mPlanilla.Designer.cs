namespace ProyectoPrograIV.Forms
{
    partial class mPlanilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTipoFile = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtgPlanilla = new System.Windows.Forms.DataGridView();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtBuscarP = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPlanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoFile
            // 
            this.cmbTipoFile.FormattingEnabled = true;
            this.cmbTipoFile.Items.AddRange(new object[] {
            "XML",
            "TXT",
            "EXCEL"});
            this.cmbTipoFile.Location = new System.Drawing.Point(360, 260);
            this.cmbTipoFile.Name = "cmbTipoFile";
            this.cmbTipoFile.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoFile.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(501, 258);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtgPlanilla
            // 
            this.dtgPlanilla.AllowUserToAddRows = false;
            this.dtgPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPlanilla.Location = new System.Drawing.Point(86, 92);
            this.dtgPlanilla.Name = "dtgPlanilla";
            this.dtgPlanilla.Size = new System.Drawing.Size(361, 150);
            this.dtgPlanilla.TabIndex = 2;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(92, 263);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(239, 13);
            this.lblInstruccion.TabIndex = 3;
            this.lblInstruccion.Text = "Seleccione el tipo de archivo que desea generar:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(372, 36);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Location = new System.Drawing.Point(117, 36);
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarP.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(246, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 6;
            // 
            // mPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 328);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBuscarP);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.dtgPlanilla);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbTipoFile);
            this.Name = "mPlanilla";
            this.Text = "Planilla";
            this.Load += new System.EventHandler(this.Planilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPlanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoFile;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dtgPlanilla;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtBuscarP;
        private System.Windows.Forms.Label lblNombre;
    }
}