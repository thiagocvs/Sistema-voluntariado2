public class Voluntario : Persona
{
    private double horasTrabajadas;

    public Voluntario(string nombre, string dni, double horasTrabajadas) : base(nombre, dni)
    {
        this.horasTrabajadas = horasTrabajadas;
    }
    

    public double HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
}