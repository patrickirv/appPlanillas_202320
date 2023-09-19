using System;
using System.Windows.Forms;

namespace appPlanillas_202320
{
  internal static class Program
  {
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault( false );
      Application.Run( new ui.frmSedes());
    }
  }
}
