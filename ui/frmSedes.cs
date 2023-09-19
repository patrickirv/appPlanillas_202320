using System;
using System.Data;
using System.Windows.Forms;

namespace appPlanillas_202320.ui
{
  public partial class frmSedes : Form
  {
    bean.Sede sede        = new bean.Sede();
    dao.SedesDAO sedesDAO = new dao.SedesDAO();
    util.Util util        = new util.Util();

    DataTable dtRegistros;
    bool  bHayRegistros;
    int   indexRegistro;
    bool  bCombo;

    public frmSedes()
    {
      InitializeComponent();
    }

    private void frmSedes_Load(object sender, EventArgs e)
    {
      getRegistros();
      Navegar( true );

      bCombo = false;
      sedesDAO.getDepartamentos( cboDepartamento, "-- Seleccionar --" );
      LimpiarCombo( cboProvincia );
      LimpiarCombo( cboDistrito );
      bCombo = true;
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

    /*private void txtDireccion_Leave(object sender, EventArgs e)
    {
      txtDireccion.Text = txtDireccion.Text.Trim();
    }*/

    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {

    }

    private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
    {
      if ( bCombo )
        if ( cboDepartamento.SelectedIndex > 0 )
        {
          bCombo = false;
          sedesDAO.getProvincias( cboProvincia, cboDepartamento.SelectedValue, "-- Seleccionar --" );
          bCombo = true;
        }
        else LimpiarCombo( cboProvincia );
      LimpiarCombo( cboDistrito );

    }

    private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
    {
      if ( bCombo )
        if ( cboProvincia.SelectedIndex > 0 )
        {
          bCombo = false;
          sedesDAO.getDistritos( cboDistrito, cboProvincia.SelectedValue, "-- Seleccionar --" );
          bCombo = true;
        }
        else LimpiarCombo( cboDistrito );
    }

    private void getRegistros()
    {
      dtRegistros = sedesDAO.getSedes();
      if ( bHayRegistros = dtRegistros != null )
      {
        dgvRegistros.DataSource                  = dtRegistros;
        dgvRegistros.Columns["id"].Visible       = false;
        dgvRegistros.Columns["NombreSede"].Width = dgvRegistros.Width - 5;
      }
    }

    private void Navegar(bool bOnOff)
    {
      btnNuevo.Visible    = bOnOff;
      btnEditar.Visible   = btnEliminar.Visible = bOnOff && bHayRegistros;
      btnGuardar.Visible  = btnCancelar.Visible = !bOnOff;

      dgvRegistros.Enabled    = bOnOff && bHayRegistros;
      txtBuscar.Visible       = bOnOff && bHayRegistros;
      txtSede.ReadOnly        = bOnOff;
      txtDireccion.ReadOnly   = bOnOff;
      cboDepartamento.Enabled = cboProvincia.Enabled = cboDistrito.Enabled = cboEstado.Enabled = !bOnOff;

      if ( !bOnOff ) txtSede.Focus();
    }

    private void verRegistro(int index)
    {
      bool bLimpiar = index == -1;

      txtID.Text                    = bLimpiar ? "" : dgvRegistros.Rows[index].Cells["id"].Value.ToString();
      txtSede.Text                  = bLimpiar ? "" : dgvRegistros.Rows[index].Cells["NombreSede"].Value.ToString();
      txtDireccion.Text             = bLimpiar ? "" : dgvRegistros.Rows[index].Cells["Direccion"].Value.ToString();
      cboDepartamento.SelectedValue = bLimpiar ?  -1 : sede.idDepartamento;
      cboProvincia.SelectedValue    = bLimpiar ?  -1 : sede.idProvincia;
      cboDistrito.SelectedValue     = bLimpiar ?  -1 : sede.idDistrito;
      cboEstado.SelectedValue       = bLimpiar ?  -1 : sede.idEstado;
    }
    
    private void LimpiarCombo( ComboBox cbo )
    {
      cbo.DataSource = null;
      cbo.Items.Clear();
      cbo.Items.Add( "-- Seleccionar --" );
      cbo.SelectedIndex = 0;
    }

  }
}
