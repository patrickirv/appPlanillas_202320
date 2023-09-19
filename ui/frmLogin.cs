using System;
using System.Windows.Forms;

namespace appPlanillas_202320.ui
{
  public partial class frmLogin : Form
  {
    public frmLogin()
    {
      InitializeComponent();
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
      bean.Empleado empleado = new bean.Empleado();
      dao.EmpleadoDAO empleadoDAO = new dao.EmpleadoDAO();

      empleado.Dni = txtDni.Text;
      empleado.Passwordd = txtPasswordd.Text;

      if ( empleadoDAO.Login( empleado ) )
        MessageBox.Show( empleado.Nombres );
    }
  }
}
