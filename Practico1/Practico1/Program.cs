using DataAccessLayer.DAL;
using Shared;
using System;
using System.Collections.Generic;
using System.Globalization;
using DataAccessLayer.IDALs;

namespace Practico_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDAL_Persona dalPersona = new DAL_Persona();  // Crear instancia de la clase DAL_Persona
            List<Persona> listaPersonas = new List<Persona>();

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido Usuario");
                    Persona persona = new Persona();

                    Console.Write("Ingrese el Nombre: ");
                    persona.nombre = Console.ReadLine();

                    Console.Write("Ingrese el Apellido: ");
                    persona.apellido = Console.ReadLine();

                    Console.Write("Ingrese el documento: ");
                    persona.Documento = Console.ReadLine();

                    Console.Write("Ingrese Fecha de nacimiento (dd/MM/yyyy): ");
                    string fechaNacString = Console.ReadLine();
                    persona.fechaNac = DateTime.ParseExact(fechaNacString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    // Agregar persona a la lista utilizando el objeto DAL_Persona
                    dalPersona.AgregarPersona(listaPersonas, persona);

                    Console.Clear() ;

                    Console.WriteLine("Persona registrada:");
                    Console.WriteLine($"Nombre: {persona.nombre}");
                    Console.WriteLine($"Apellido: {persona.apellido}");
                    Console.WriteLine($"Documento: {persona.Documento}");
                    Console.WriteLine($"Fecha de nacimiento: {persona.fechaNac.ToShortDateString()}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                Console.Write("Presione Enter para continuar o escriba 'EXIT' para salir: ");
            } while (!Console.ReadLine().Equals("EXIT", StringComparison.OrdinalIgnoreCase));

            Console.Clear();
            // Ordenar la lista de personas por fecha de nacimiento utilizando el objeto DAL_Persona
            listaPersonas.Sort(new ComparadorFechaNacimiento());

            // Mostrar la lista de personas ordenada utilizando el objeto DAL_Persona
            dalPersona.MostrarListaPersonas(listaPersonas);
        }
    }
}
