﻿namespace ProyectoPrograIV.Forms
{
    partial class mCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbcInformacion = new System.Windows.Forms.TabControl();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ltvCreditos = new System.Windows.Forms.ListView();
            this.colIdCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdInstitucion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpDatos = new System.Windows.Forms.TabPage();
            this.cboInstitucion = new System.Windows.Forms.ComboBox();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdInstitucion = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            this.tbcInformacion.SuspendLayout();
            this.tbpLista.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 61);
            this.panel1.TabIndex = 21;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(276, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mantenimiento de Clientes...";
            // 
            // tbcInformacion
            // 
            this.tbcInformacion.Controls.Add(this.tbpLista);
            this.tbcInformacion.Controls.Add(this.tbpDatos);
            this.tbcInformacion.Location = new System.Drawing.Point(12, 77);
            this.tbcInformacion.Name = "tbcInformacion";
            this.tbcInformacion.SelectedIndex = 0;
            this.tbcInformacion.Size = new System.Drawing.Size(564, 430);
            this.tbcInformacion.TabIndex = 20;
            // 
            // tbpLista
            // 
            this.tbpLista.Controls.Add(this.btnModificar);
            this.tbpLista.Controls.Add(this.btnEliminar);
            this.tbpLista.Controls.Add(this.btnAgregar);
            this.tbpLista.Controls.Add(this.ltvCreditos);
            this.tbpLista.Location = new System.Drawing.Point(4, 22);
            this.tbpLista.Name = "tbpLista";
            this.tbpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLista.Size = new System.Drawing.Size(556, 404);
            this.tbpLista.TabIndex = 0;
            this.tbpLista.Text = "Lista";
            this.tbpLista.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(248, 354);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(329, 354);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(167, 354);
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
            this.colIdCliente,
            this.colNombre,
            this.colApellido1,
            this.colApellido2,
            this.colIdInstitucion});
            this.ltvCreditos.GridLines = true;
            this.ltvCreditos.Location = new System.Drawing.Point(6, 6);
            this.ltvCreditos.MultiSelect = false;
            this.ltvCreditos.Name = "ltvCreditos";
            this.ltvCreditos.Size = new System.Drawing.Size(544, 342);
            this.ltvCreditos.TabIndex = 0;
            this.ltvCreditos.UseCompatibleStateImageBehavior = false;
            this.ltvCreditos.View = System.Windows.Forms.View.Details;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Text = "Id Cliente";
            this.colIdCliente.Width = 87;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 162;
            // 
            // colApellido1
            // 
            this.colApellido1.Text = "Apellido 1";
            this.colApellido1.Width = 107;
            // 
            // colApellido2
            // 
            this.colApellido2.Text = "Apellido 2";
            this.colApellido2.Width = 119;
            // 
            // colIdInstitucion
            // 
            this.colIdInstitucion.Text = "Institución";
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.cboInstitucion);
            this.tbpDatos.Controls.Add(this.lblInstitucion);
            this.tbpDatos.Controls.Add(this.txtApellido2);
            this.tbpDatos.Controls.Add(this.lblApellido2);
            this.tbpDatos.Controls.Add(this.btnRegresar);
            this.tbpDatos.Controls.Add(this.btnAceptar);
            this.tbpDatos.Controls.Add(this.txtApellido1);
            this.tbpDatos.Controls.Add(this.txtNombre);
            this.tbpDatos.Controls.Add(this.lblApellido1);
            this.tbpDatos.Controls.Add(this.lblNombre);
            this.tbpDatos.Controls.Add(this.lblId);
            this.tbpDatos.Controls.Add(this.lblIdInstitucion);
            this.tbpDatos.Location = new System.Drawing.Point(4, 22);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatos.Size = new System.Drawing.Size(556, 404);
            this.tbpDatos.TabIndex = 1;
            this.tbpDatos.Text = "Datos";
            this.tbpDatos.UseVisualStyleBackColor = true;
            // 
            // cboInstitucion
            // 
            this.cboInstitucion.FormattingEnabled = true;
            this.cboInstitucion.Location = new System.Drawing.Point(93, 126);
            this.cboInstitucion.Name = "cboInstitucion";
            this.cboInstitucion.Size = new System.Drawing.Size(357, 21);
            this.cboInstitucion.TabIndex = 32;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Location = new System.Drawing.Point(29, 129);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(55, 13);
            this.lblInstitucion.TabIndex = 31;
            this.lblInstitucion.Text = "Institucion";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(93, 100);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(357, 20);
            this.txtApellido2.TabIndex = 30;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(29, 103);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(53, 13);
            this.lblApellido2.TabIndex = 29;
            this.lblApellido2.Text = "Apellido 2";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(270, 195);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 23);
            this.btnRegresar.TabIndex = 28;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(174, 195);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 23);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(93, 74);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(357, 20);
            this.txtApellido1.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(357, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(29, 77);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(53, 13);
            this.lblApellido1.TabIndex = 3;
            this.lblApellido1.Text = "Apellido 1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(90, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // lblIdInstitucion
            // 
            this.lblIdInstitucion.AutoSize = true;
            this.lblIdInstitucion.Location = new System.Drawing.Point(29, 28);
            this.lblIdInstitucion.Name = "lblIdInstitucion";
            this.lblIdInstitucion.Size = new System.Drawing.Size(55, 13);
            this.lblIdInstitucion.TabIndex = 0;
            this.lblIdInstitucion.Text = "Institución";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(588, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcInformacion);
            this.Controls.Add(this.statusStrip1);
            this.Name = "mCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.mCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcInformacion.ResumeLayout(false);
            this.tbpLista.ResumeLayout(false);
            this.tbpDatos.ResumeLayout(false);
            this.tbpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tbcInformacion;
        private System.Windows.Forms.TabPage tbpLista;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView ltvCreditos;
        private System.Windows.Forms.ColumnHeader colIdCliente;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido1;
        private System.Windows.Forms.ColumnHeader colApellido2;
        private System.Windows.Forms.ColumnHeader colIdInstitucion;
        private System.Windows.Forms.TabPage tbpDatos;
        private System.Windows.Forms.ComboBox cboInstitucion;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdInstitucion;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}