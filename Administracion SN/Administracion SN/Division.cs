using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_SN
{
    [Serializable]
    public class Division
    {
        private string nombre;
        private List<Persona> encargados = new List<Persona>();

        public Division(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Persona> Encargados { get => encargados; set => encargados = value; }

        public string Get_Name()
        {
            return Nombre;
        }

        public List<Persona> Get_Personas()
        {
            return Encargados;
        }

        

        public void Crear_Encargado(int n)
        {
            Console.Write("Ingrese el nombre del encargado " + n + " del " + Nombre + ": ");
            string name = Console.ReadLine();
            Console.Write("Ingrese el apellido del encargado " + n + " del " + Nombre + ": ");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese el RUT del encargado " + n + " del " + Nombre + ": ");
            string rut = Console.ReadLine();
            Console.Write("Ingrese la edad del encargado " + n + " del " + Nombre + ": ");
            int edad = 0;
            int.TryParse(Console.ReadLine(), out edad);
            Persona persona = new Persona(name, apellido, rut, edad);
            Encargados.Add(persona);

        }
    }
}
