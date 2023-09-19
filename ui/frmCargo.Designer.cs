namespace appPlanillas_202320.ui
{
  partial class frmCargo
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
      this.dgvRegistros = new System.Windows.Forms.DataGridView();
      this.btnNuevo = new System.Windows.Forms.Button();
      this.btnEditar = new System.Windows.Forms.Button();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.lblID = new System.Windows.Forms.Label();
      this.lblDetalle = new System.Windows.Forms.Label();
      this.txtDetalle = new System.Windows.Forms.TextBox();
      this.txtID = new System.Windows.Forms.TextBox();
      this.txtBuscar = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvRegistros
      // 
      this.dgvRegistros.AllowUserToAddRows = false;
      this.dgvRegistros.AllowUserToDeleteRows = false;
      this.dgvRegistros.AllowUserToResizeColumns = false;
      this.dgvRegistros.AllowUserToResizeRows = false;
      this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvRegistros.ColumnHeadersVisible = false;
      this.dgvRegistros.Location = new System.Drawing.Point(13, 118);
      this.dgvRegistros.MultiSelect = false;
      this.dgvRegistros.Name = "dgvRegistros";
      this.dgvRegistros.ReadOnly = true;
      this.dgvRegistros.RowHeadersVisible = false;
      this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvRegistros.Size = new System.Drawing.Size(162, 233);
      this.dgvRegistros.TabIndex = 2;
      this.dgvRegistros.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellEnter);
      // 
      // btnNuevo
      // 
      this.btnNuevo.Location = new System.Drawing.Point(175, 45);
      this.btnNuevo.Name = "btnNuevo";
      this.btnNuevo.Size = new System.Drawing.Size(75, 23);
      this.btnNuevo.TabIndex = 1;
      this.btnNuevo.Text = "Nuevo";
      this.btnNuevo.UseVisualStyleBackColor = true;
      this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
      // 
      // btnEditar
      // 
      this.btnEditar.Location = new System.Drawing.Point(256, 45);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(75, 23);
      this.btnEditar.TabIndex = 2;
      this.btnEditar.Text = "Editar";
      this.btnEditar.UseVisualStyleBackColor = true;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(459, 45);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(75, 23);
      this.btnGuardar.TabIndex = 3;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(540, 45);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 4;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(337, 45);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(75, 23);
      this.btnEliminar.TabIndex = 5;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // lblID
      // 
      this.lblID.AutoSize = true;
      this.lblID.ForeColor = System.Drawing.Color.White;
      this.lblID.Location = new System.Drawing.Point(280, 162);
      this.lblID.Name = "lblID";
      this.lblID.Size = new System.Drawing.Size(24, 13);
      this.lblID.TabIndex = 9;
      this.lblID.Text = "ID :";
      // 
      // lblDetalle
      // 
      this.lblDetalle.AutoSize = true;
      this.lblDetalle.ForeColor = System.Drawing.Color.White;
      this.lblDetalle.Location = new System.Drawing.Point(280, 209);
      this.lblDetalle.Name = "lblDetalle";
      this.lblDetalle.Size = new System.Drawing.Size(46, 13);
      this.lblDetalle.TabIndex = 10;
      this.lblDetalle.Text = "Detalle :";
      // 
      // txtDetalle
      // 
      this.txtDetalle.Location = new System.Drawing.Point(357, 202);
      this.txtDetalle.MaxLength = 30;
      this.txtDetalle.Name = "txtDetalle";
      this.txtDetalle.Size = new System.Drawing.Size(177, 20);
      this.txtDetalle.TabIndex = 11;
      this.txtDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
      this.txtDetalle.Leave += new System.EventHandler(this.txtDetalle_Leave);
      // 
      // txtID
      // 
      this.txtID.Enabled = false;
      this.txtID.Location = new System.Drawing.Point(357, 162);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(177, 20);
      this.txtID.TabIndex = 8;
      // 
      // txtBuscar
      // 
      this.txtBuscar.Location = new System.Drawing.Point(13, 92);
      this.txtBuscar.MaxLength = 30;
      this.txtBuscar.Name = "txtBuscar";
      this.txtBuscar.Size = new System.Drawing.Size(161, 20);
      this.txtBuscar.TabIndex = 13;
      this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
      this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
      // 
      // frmCargo
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.ClientSize = new System.Drawing.Size(621, 383);
      this.Controls.Add(this.txtBuscar);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.txtDetalle);
      this.Controls.Add(this.lblDetalle);
      this.Controls.Add(this.lblID);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.btnNuevo);
      this.Controls.Add(this.dgvRegistros);
      this.Name = "frmCargo";
      this.Text = "frmCargo";
      this.Load += new System.EventHandler(this.frmCargo_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvRegistros;
    private System.Windows.Forms.Button btnNuevo;
    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Label lblID;
    private System.Windows.Forms.Label lblDetalle;
    private System.Windows.Forms.TextBox txtDetalle;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.TextBox txtBuscar;
  }
}