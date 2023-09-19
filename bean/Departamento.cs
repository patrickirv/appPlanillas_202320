namespace appPlanillas_202320.bean
{
  internal class Departamento
  {
    #region Propiedades

    public int id { get; set; }
    public string Detalle { get; set; }
    public string Cuenta { get; set; }

    #endregion


    #region Metodos

    public Departamento(int id, string detalle, string  cuenta)
    {
      this.id = id;
      this.Detalle = detalle;
      this.Cuenta = cuenta;
    }

    public object[] getColumnas()
    {
      return new object[] { id, Detalle, Cuenta };
    }

    #endregion
  }
}
