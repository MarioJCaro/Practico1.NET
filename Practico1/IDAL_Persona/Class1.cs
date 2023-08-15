using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace DataAccessLayer.IDALs
{
    public interface IDAL_Persona
    {

        void AgregarPersona(List<Persona> listaPersonas, Persona nuevaPersona);
        void MostrarListaPersonas(List<Persona> listaPersonas);

       


    }
}