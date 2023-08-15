namespace Shared
{
    public class Persona
    {

        public string nombre { get; set; } = "Sin nombre";
        public string apellido { get; set; } = "Sin apellido";

        private string documento = "";
        public string Documento { get { return documento; }
            set { if (value.Length < 7)
                    throw new Exception("Formato de documento erróneo");
            else
                    documento = value.ToUpper();
            }
        }

        public DateTime fechaNac { get; set; }

        // Constructor
        public Persona() { }
  
    }

    public class ComparadorFechaNacimiento : IComparer<Persona>
    {
        public int Compare(Persona persona1, Persona persona2)
        {
            return persona1.fechaNac.CompareTo(persona2.fechaNac);
        }
    }
}