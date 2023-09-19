using System.Data;
using appPlanillas_202320.bean;

namespace appPlanillas_202320.dao
{
  internal class CargoDAO
  {
    db.Db db = new db.Db("cnPlanillas");

    public DataTable getCargo()
    {
      db.Sentencia( "select * from vCargos order by id" ); //sp_getCargos
      return db.getDataTable();
    }

    public bool Guardar(Cargo cargo)
    {
      //db.Sentencia(string.Format("sp_GuardarCentroCosto '{0}','{1}'", centroCosto.id,centroCosto.Detalle));
      db.Sentencia( "sp_GuardarCargo" );
      db.Parametros( cargo.getColumnas() );
      return db.Ejecutar() > 0;
    }
  }
}
