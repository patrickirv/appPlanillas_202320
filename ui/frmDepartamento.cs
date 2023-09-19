using System;
using System.Data;
using System.Windows.Forms;

namespace appPlanillas_202320.ui
{
  public partial class frmDepartamento : Form
  {
    dao.DepartamentoDAO DepartamentoDAO = new dao.DepartamentoDAO();
    util.Util util = new util.Util();

    DataTable dtRegistros;
    bool bHayRegistros;
    int indexRegistro;

    public frmDepartamento()
    {
      InitializeComponent();
    }

    private void frmDepartamento_Load(object sender, EventArgs e)
    {
      getRegistros();
      Navegar( true );
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      Navegar( false );
      verRegistro( -1 );
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      Navegar( false );
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {

    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      int id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
      string detalle = txtDetalle.Text;
      string cuenta = txtCuenta.Text;

      //Validar

      if ( DepartamentoDAO.Guardar( new bean.Departamento( id, detalle, cuenta) ) ) {
        getRegistros();
        txtBuscar_TextChanged( null, null );
        for ( int i = 0; i < dgvRegistros.Rows.Count; i++ )
          if ( dgvRegistros.Rows[i].Cells["Detalle"].Value.ToString().Equals( detalle ) == dgvRegistros.Rows[i].Cells["Cuenta"].Value.ToString().Equals( cuenta ) )
          { dgvRegistros.Rows[i].Cells["Detalle"].Selected  = dgvRegistros.Rows[i].Cells["Cuenta"].Selected == true; break; }

        MessageBox.Show( "Registro " + ( id == 0 ? "Guardado" : "Actualizado" ) );
      }
      Navegar( true );
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      Navegar( true );
      verRegistro( indexRegistro );
    }

    private void dgvRegistros_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      verRegistro( indexRegistro = e.RowIndex );
    }

    private void txt_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = util.LetterSpaceBack( sender, e );
    }

    private void txtDetalle_Leave(object sender, EventArgs e)
    {
      txtDetalle.Text = txtDetalle.Text.Trim();
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {
      dtRegistros.DefaultView.RowFilter = string.Format( "Detalle like '%{0}%'", txtBuscar.Text );
    }

    private void getRegistros()
    {
      dtRegistros = DepartamentoDAO.getDepartamentos();
      if ( bHayRegistros = dtRegistros != null ) {
        dgvRegistros.DataSource = dtRegistros;
        dgvRegistros.Columns["id"].Visible = dgvRegistros.Columns["Cuenta"].Visible = false;
        dgvRegistros.Columns["Detalle"].Width = dgvRegistros.Width - 5;
      }
    }

    private void Navegar(bool bOnOff) {
      btnNuevo.Visible = bOnOff;
      btnEditar.Visible = btnEliminar.Visible = bOnOff && bHayRegistros;
      btnGuardar.Visible = btnCancelar.Visible = !bOnOff;

      dgvRegistros.Enabled = bOnOff && bHayRegistros;
      txtBuscar.Visible = bOnOff && bHayRegistros;
      txtDetalle.ReadOnly = bOnOff;
      txtCuenta.ReadOnly = bOnOff;

      if ( !bOnOff ) txtDetalle.Focus();
    }

    private void verRegistro(int index) {
      bool bLimpiar = index == -1;

      txtID.Text = bLimpiar ? "" : dgvRegistros.Rows[index].Cells["id"].Value.ToString(); // ToString();
      txtDetalle.Text = bLimpiar ? "" : dgvRegistros.Rows[index].Cells["Detalle"].Value.ToString();
      txtCuenta.Text = bLimpiar ? "" : dgvRegistros.Rows[index].Cells["Cuenta"].Value.ToString();
    }
  }
}