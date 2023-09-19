using System;
using System.Data;
using System.Windows.Forms;

namespace appPlanillas_202320.dao
{
  internal class SedesDAO
  {
    db.Db db = new db.Db("cnPlanillas");
    db.Db dbOnpe = new db.Db("cnOnpe");

    internal void getDepartamentos( ComboBox cboDepartamento, string sTexto = null)
    {
      dbOnpe.Sentencia( "usp_getDepartamentos 1,25" );
      dbOnpe.getComboBox( cboDepartamento, sTexto );
    }

    internal void getProvincias(ComboBox cboProvincia, object idDepartamento, string sTexto = null)
    {
      dbOnpe.Sentencia( "usp_getProvincias " + idDepartamento );
      dbOnpe.getComboBox( cboProvincia, sTexto );
    }

    internal void getDistritos(ComboBox cboDistrito, object idProvincia, string sTexto = null)
    {
      dbOnpe.Sentencia( "usp_getDistritos " + idProvincia );
      dbOnpe.getComboBox( cboDistrito, sTexto );
    }

    internal DataTable getSedes()
    {
      db.Sentencia( "sp_getSedes" );
      return db.getDataTable(); 
    }
  }
}