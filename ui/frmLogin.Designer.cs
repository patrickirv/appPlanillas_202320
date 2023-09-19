namespace appPlanillas_202320.ui
{
  partial class frmLogin
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
      this.name = new System.Windows.Forms.Label();
      this.lbl = new System.Windows.Forms.Label();
      this.txtDni = new System.Windows.Forms.TextBox();
      this.txtPasswordd = new System.Windows.Forms.TextBox();
      this.btnIngresar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // name
      // 
      this.name.AutoSize = true;
      this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.name.ForeColor = System.Drawing.Color.White;
      this.name.Location = new System.Drawing.Point(164, 100);
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size(32, 13);
      this.name.TabIndex = 0;
      this.name.Text = "DNI :";
      // 
      // lbl
      // 
      this.lbl.AutoSize = true;
      this.lbl.ForeColor = System.Drawing.Color.White;
      this.lbl.Location = new System.Drawing.Point(164, 144);
      this.lbl.Name = "lbl";
      this.lbl.Size = new System.Drawing.Size(59, 13);
      this.lbl.TabIndex = 0;
      this.lbl.Text = "Password :";
      // 
      // txtDni
      // 
      this.txtDni.Location = new System.Drawing.Point(264, 97);
      this.txtDni.Name = "txtDni";
      this.txtDni.Size = new System.Drawing.Size(100, 20);
      this.txtDni.TabIndex = 1;
      // 
      // txtPasswordd
      // 
      this.txtPasswordd.Location = new System.Drawing.Point(264, 144);
      this.txtPasswordd.Name = "txtPasswordd";
      this.txtPasswordd.Size = new System.Drawing.Size(100, 20);
      this.txtPasswordd.TabIndex = 2;
      // 
      // btnIngresar
      // 
      this.btnIngresar.Location = new System.Drawing.Point(280, 206);
      this.btnIngresar.Name = "btnIngresar";
      this.btnIngresar.Size = new System.Drawing.Size(75, 23);
      this.btnIngresar.TabIndex = 0;
      this.btnIngresar.Text = "&Iniciar";
      this.btnIngresar.UseVisualStyleBackColor = true;
      this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
      // 
      // frmLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.ClientSize = new System.Drawing.Size(604, 381);
      this.Controls.Add(this.btnIngresar);
      this.Controls.Add(this.txtPasswordd);
      this.Controls.Add(this.txtDni);
      this.Controls.Add(this.lbl);
      this.Controls.Add(this.name);
      this.Name = "frmLogin";
      this.Text = "frmLogin";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label name;
    private System.Windows.Forms.Label lbl;
    private System.Windows.Forms.TextBox txtDni;
    private System.Windows.Forms.TextBox txtPasswordd;
    private System.Windows.Forms.Button btnIngresar;
  }
}