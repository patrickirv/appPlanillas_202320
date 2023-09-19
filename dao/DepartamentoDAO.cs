using System.Data;
using appPlanillas_202320.bean;

namespace appPlanillas_202320.dao
{
  internal class DepartamentoDAO
  {
    db.Db db = new db.Db("cnPlanillas");

    public DataTable getDepartamentos()
    {
      db.Sentencia( "select * from vDepartamentos order by id" ); //sp_getDepartamentos
      return db.getDataTable();
    }

    public bool Guardar(Departamento departamento)
    {
      //db.Sentencia(string.Format("sp_GuardarDepartamento '{0}','{1}'", departamento.id,departamento.Detalle, departamento.Cuenta));
      db.Sentencia( "sp_GuardarDepartamento" );
      db.Parametros( departamento.getColumnas() );
      return db.Ejecutar() > 0;
    }
  }
}
