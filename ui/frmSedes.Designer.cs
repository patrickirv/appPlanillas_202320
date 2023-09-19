namespace appPlanillas_202320.ui
{
    partial class frmSedes
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
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.cboDepartamento = new System.Windows.Forms.ComboBox();
      this.cboDistrito = new System.Windows.Forms.ComboBox();
      this.cboProvincia = new System.Windows.Forms.ComboBox();
      this.txtBuscar = new System.Windows.Forms.TextBox();
      this.txtID = new System.Windows.Forms.TextBox();
      this.lblNombreSede = new System.Windows.Forms.Label();
      this.lblID = new System.Windows.Forms.Label();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.btnEditar = new System.Windows.Forms.Button();
      this.btnNuevo = new System.Windows.Forms.Button();
      this.dgvRegistros = new System.Windows.Forms.DataGridView();
      this.lblEstado = new System.Windows.Forms.Label();
      this.lblDistrito = new System.Windows.Forms.Label();
      this.lblProvincia = new System.Windows.Forms.Label();
      this.lblDireccion = new System.Windows.Forms.Label();
      this.lblDepartamento = new System.Windows.Forms.Label();
      this.txtSede = new System.Windows.Forms.TextBox();
      this.txtDireccion = new System.Windows.Forms.TextBox();
      this.cboEstado = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
      this.SuspendLayout();
      // 
      // cboDepartamento
      // 
      this.cboDepartamento.FormattingEnabled = true;
      this.cboDepartamento.Location = new System.Drawing.Point(332, 221);
      this.cboDepartamento.Name = "cboDepartamento";
      this.cboDepartamento.Size = new System.Drawing.Size(282, 21);
      this.cboDepartamento.TabIndex = 0;
      this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
      // 
      // cboDistrito
      // 
      this.cboDistrito.FormattingEnabled = true;
      this.cboDistrito.Location = new System.Drawing.Point(332, 275);
      this.cboDistrito.Name = "cboDistrito";
      this.cboDistrito.Size = new System.Drawing.Size(282, 21);
      this.cboDistrito.TabIndex = 1;
      // 
      // cboProvincia
      // 
      this.cboProvincia.FormattingEnabled = true;
      this.cboProvincia.Location = new System.Drawing.Point(332, 248);
      this.cboProvincia.Name = "cboProvincia";
      this.cboProvincia.Size = new System.Drawing.Size(282, 21);
      this.cboProvincia.TabIndex = 2;
      this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
      // 
      // txtBuscar
      // 
      this.txtBuscar.Location = new System.Drawing.Point(41, 104);
      this.txtBuscar.MaxLength = 30;
      this.txtBuscar.Name = "txtBuscar";
      this.txtBuscar.Size = new System.Drawing.Size(161, 20);
      this.txtBuscar.TabIndex = 24;
      this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
      this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
      // 
      // txtID
      // 
      this.txtID.Enabled = false;
      this.txtID.Location = new System.Drawing.Point(332, 143);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(89, 20);
      this.txtID.TabIndex = 20;
      // 
      // lblNombreSede
      // 
      this.lblNombreSede.AutoSize = true;
      this.lblNombreSede.ForeColor = System.Drawing.Color.White;
      this.lblNombreSede.Location = new System.Drawing.Point(246, 176);
      this.lblNombreSede.Name = "lblNombreSede";
      this.lblNombreSede.Size = new System.Drawing.Size(78, 13);
      this.lblNombreSede.TabIndex = 22;
      this.lblNombreSede.Text = "Nombre Sede :";
      // 
      // lblID
      // 
      this.lblID.AutoSize = true;
      this.lblID.ForeColor = System.Drawing.Color.White;
      this.lblID.Location = new System.Drawing.Point(246, 150);
      this.lblID.Name = "lblID";
      this.lblID.Size = new System.Drawing.Size(24, 13);
      this.lblID.TabIndex = 21;
      this.lblID.Text = "ID :";
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(384, 48);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(75, 23);
      this.btnEliminar.TabIndex = 19;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(639, 48);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 18;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(558, 48);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(75, 23);
      this.btnGuardar.TabIndex = 17;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // btnEditar
      // 
      this.btnEditar.Location = new System.Drawing.Point(303, 48);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(75, 23);
      this.btnEditar.TabIndex = 15;
      this.btnEditar.Text = "Editar";
      this.btnEditar.UseVisualStyleBackColor = true;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // btnNuevo
      // 
      this.btnNuevo.Location = new System.Drawing.Point(222, 48);
      this.btnNuevo.Name = "btnNuevo";
      this.btnNuevo.Size = new System.Drawing.Size(75, 23);
      this.btnNuevo.TabIndex = 14;
      this.btnNuevo.Text = "Nuevo";
      this.btnNuevo.UseVisualStyleBackColor = true;
      this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
      // 
      // dgvRegistros
      // 
      this.dgvRegistros.AllowUserToAddRows = false;
      this.dgvRegistros.AllowUserToDeleteRows = false;
      this.dgvRegistros.AllowUserToResizeColumns = false;
      this.dgvRegistros.AllowUserToResizeRows = false;
      this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvRegistros.ColumnHeadersVisible = false;
      this.dgvRegistros.Location = new System.Drawing.Point(41, 130);
      this.dgvRegistros.MultiSelect = false;
      this.dgvRegistros.Name = "dgvRegistros";
      this.dgvRegistros.ReadOnly = true;
      this.dgvRegistros.RowHeadersVisible = false;
      this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvRegistros.Size = new System.Drawing.Size(162, 233);
      this.dgvRegistros.TabIndex = 16;
      this.dgvRegistros.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellEnter);
      // 
      // lblEstado
      // 
      this.lblEstado.AutoSize = true;
      this.lblEstado.ForeColor = System.Drawing.Color.White;
      this.lblEstado.Location = new System.Drawing.Point(246, 310);
      this.lblEstado.Name = "lblEstado";
      this.lblEstado.Size = new System.Drawing.Size(46, 13);
      this.lblEstado.TabIndex = 25;
      this.lblEstado.Text = "Estado :";
      // 
      // lblDistrito
      // 
      this.lblDistrito.AutoSize = true;
      this.lblDistrito.ForeColor = System.Drawing.Color.White;
      this.lblDistrito.Location = new System.Drawing.Point(246, 283);
      this.lblDistrito.Name = "lblDistrito";
      this.lblDistrito.Size = new System.Drawing.Size(45, 13);
      this.lblDistrito.TabIndex = 26;
      this.lblDistrito.Text = "Distrito :";
      // 
      // lblProvincia
      // 
      this.lblProvincia.AutoSize = true;
      this.lblProvincia.ForeColor = System.Drawing.Color.White;
      this.lblProvincia.Location = new System.Drawing.Point(246, 256);
      this.lblProvincia.Name = "lblProvincia";
      this.lblProvincia.Size = new System.Drawing.Size(57, 13);
      this.lblProvincia.TabIndex = 27;
      this.lblProvincia.Text = "Provincia :";
      // 
      // lblDireccion
      // 
      this.lblDireccion.AutoSize = true;
      this.lblDireccion.ForeColor = System.Drawing.Color.White;
      this.lblDireccion.Location = new System.Drawing.Point(246, 202);
      this.lblDireccion.Name = "lblDireccion";
      this.lblDireccion.Size = new System.Drawing.Size(58, 13);
      this.lblDireccion.TabIndex = 28;
      this.lblDireccion.Text = "Dirección :";
      // 
      // lblDepartamento
      // 
      this.lblDepartamento.AutoSize = true;
      this.lblDepartamento.ForeColor = System.Drawing.Color.White;
      this.lblDepartamento.Location = new System.Drawing.Point(246, 229);
      this.lblDepartamento.Name = "lblDepartamento";
      this.lblDepartamento.Size = new System.Drawing.Size(80, 13);
      this.lblDepartamento.TabIndex = 29;
      this.lblDepartamento.Text = "Departamento :";
      // 
      // txtSede
      // 
      this.txtSede.Location = new System.Drawing.Point(332, 169);
      this.txtSede.Name = "txtSede";
      this.txtSede.Size = new System.Drawing.Size(212, 20);
      this.txtSede.TabIndex = 30;
      this.txtSede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
      // 
      // txtDireccion
      // 
      this.txtDireccion.Location = new System.Drawing.Point(332, 195);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new System.Drawing.Size(212, 20);
      this.txtDireccion.TabIndex = 31;
      // 
      // cboEstado
      // 
      this.cboEstado.FormattingEnabled = true;
      this.cboEstado.Location = new System.Drawing.Point(332, 302);
      this.cboEstado.Name = "cboEstado";
      this.cboEstado.Size = new System.Drawing.Size(177, 21);
      this.cboEstado.TabIndex = 32;
      // 
      // frmSedes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.cboEstado);
      this.Controls.Add(this.txtDireccion);
      this.Controls.Add(this.txtSede);
      this.Controls.Add(this.lblDepartamento);
      this.Controls.Add(this.lblDireccion);
      this.Controls.Add(this.lblProvincia);
      this.Controls.Add(this.lblDistrito);
      this.Controls.Add(this.lblEstado);
      this.Controls.Add(this.txtBuscar);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.lblNombreSede);
      this.Controls.Add(this.lblID);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.btnNuevo);
      this.Controls.Add(this.dgvRegistros);
      this.Controls.Add(this.cboProvincia);
      this.Controls.Add(this.cboDistrito);
      this.Controls.Add(this.cboDepartamento);
      this.Name = "frmSedes";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmSede";
      this.Load += new System.EventHandler(this.frmSedes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombreSede;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cboEstado;
    }
}