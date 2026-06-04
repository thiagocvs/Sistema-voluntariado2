public class Coordinadores : Persona
{
    private string area;
    private int cantPersonas;

    public Coordinadores(string nombre, string dni, string area, int cantPersonas) : base(nombre, dni)
    {
        Area = area;
        CantPersonas = cantPersonas;
    }

    public string Area { get => area; set => area = value; }
    public int CantPersonas { get => cantPersonas; set => cantPersonas = value; }
}