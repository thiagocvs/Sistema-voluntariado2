public abstract class Persona
{
    private string nombre;
    private string dni;

    public Persona(string nombre, string dni)
    {
        Nombre = nombre;
        Dni = dni;
    }

    public string Dni { get => dni; set => dni = value; }
    public string Nombre { get => nombre; set => nombre = value; }
}