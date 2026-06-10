using System;
using System.Collections.Generic;

namespace Sistema_voluntariado2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Voluntario> voluntarios = new List<Voluntario>();
            List<Coordinadores> coordinadores = new List<Coordinadores>();
            
            bool continuar = true;
            while (continuar) 
            {
                Console.WriteLine("----------Menu Voluntariado----------");
                Console.WriteLine("1. Agregar voluntario");
                Console.WriteLine("2. Agregar coordinador");
                Console.WriteLine("3. Mostrar Datos");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

            
             
                switch (opcion)
                {
                    case "1":
                        AgregarVoluntario(voluntarios);
                        break;
                    case "2":
                        AgregarCoordinador(coordinadores);
                        break;
                    case "3":
                        MostrarDatos(voluntarios, coordinadores);
                        break;
                    case "4":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                        break;
                }
            }
        }

        static void AgregarVoluntario(List<Voluntario> voluntarios)
        {
            Console.Write("Ingrese el nombre del voluntario: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el DNI del voluntario: ");
            string dni = Console.ReadLine();
            Console.Write("Ingrese las horas trabajadas por el voluntario: ");
            double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            Voluntario nuevoVoluntario = new Voluntario(nombre, dni, horasTrabajadas);
            voluntarios.Add(nuevoVoluntario);
            Console.WriteLine("Voluntario agregado exitosamente.");
        }

        static void AgregarCoordinador(List<Coordinadores> coordinadores)
        {
            Console.Write("Ingrese el nombre del coordinador: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el DNI del coordinador: ");
            string dni = Console.ReadLine();
            Console.Write("Ingrese el área del coordinador: ");
            string area = Console.ReadLine();
            Console.Write("Ingrese la cantidad de personas a cargo del coordinador: ");
            int cantPersonas = Convert.ToInt32(Console.ReadLine());

            Coordinadores nuevoCoordinador = new Coordinadores(nombre, dni, area, cantPersonas);
            coordinadores.Add(nuevoCoordinador);
            Console.WriteLine("Coordinador agregado exitosamente.");
        }

        static void MostrarDatos(List<Voluntario> voluntarios, List<Coordinadores> coordinadores)
        {
            Console.WriteLine("-----Voluntarios-----");
            foreach (var voluntario in voluntarios)
            {
                Console.WriteLine($"Nombre: {voluntario.Nombre}, DNI: {voluntario.Dni}, Horas Trabajadas: {voluntario.HorasTrabajadas}");
            }

            Console.WriteLine("-----Coordinadores-----");
            foreach (var coordinador in coordinadores)
            {
                Console.WriteLine($"Nombre: {coordinador.Nombre}, DNI: {coordinador.Dni}, Área: {coordinador.Area}, Cantidad de Personas a Cargo: {coordinador.CantPersonas}");
            }
        }
    }
}    