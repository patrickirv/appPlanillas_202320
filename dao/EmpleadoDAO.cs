using System;

namespace appPlanillas_202320.dao
{
  internal class EmpleadoDAO
  {
    db.Db db = new db.Db("cnPlanillas");
    internal bool Login(bean.Empleado empleado)
    {
      db.Sentencia( String.Format( "sp_EmpleadoLogin '{0}','{1}'", empleado.Dni, empleado.Passwordd ) );
      empleado.setEmpleado( db.getDataRow() );
      return empleado.id > 0;
    }
  }
}
