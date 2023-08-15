using DataAccessLayer.IDALs;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL
{
    public class DAL_Persona : IDAL_Persona
    {

        private List<Persona> personaList = new List<Persona>();

        // Agregar una persona a la lista
        void IDAL_Persona.AgregarPersona(List<Persona> listaPersonas, Persona nuevaPersona)
        {
            listaPersonas.Add(nuevaPersona);
        }

        // Mostrar la lista de personas
         void IDAL_Persona.MostrarListaPersonas(List<Persona> listaPersonas)
        {
            Console.WriteLine("Lista de Personas:");
            foreach (Persona persona in listaPersonas)
            {
                Console.WriteLine($"Nombre: {persona.nombre}");
                Console.WriteLine($"Apellido: {persona.apellido}");
                Console.WriteLine($"Documento: {persona.Documento}");
                Console.WriteLine($"Fecha de nacimiento: {persona.fechaNac.ToShortDateString()}");
                Console.WriteLine("-----");
            }
        }
    }
}