﻿using System.Data;

namespace appPlanillas_202320.bean
{
  internal class Sede
  {
    #region Propiedades

    public int id { get; set; }
    public string NombreSede { get; set; }
    public string Direccion { get; set; }
    public int idDepartamento { get; set; }
    public int idProvincia { get; set; }
    public int idDistrito { get; set; }
    public int idEstado { get; set; }

    #endregion

    #region Métodos


    public void setRegistro(DataRow dr)
    {
      if ( dr == null ) return;

      id = int.Parse( dr["id"].ToString() );
      NombreSede = ( dr["NombreSede"].ToString() );
      Direccion = ( dr["Direccion"].ToString() );
      idDepartamento = int.Parse( dr["idDepartamento"].ToString() );
      idProvincia = int.Parse( dr["idProvincia"].ToString() );
      idDistrito = int.Parse( dr["idDistrito"].ToString() );
      idEstado = int.Parse( dr["idEstado"].ToString() );
    }

    #endregion
  }
}
