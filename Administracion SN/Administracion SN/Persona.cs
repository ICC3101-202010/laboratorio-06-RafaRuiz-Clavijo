using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_SN
{
    [Serializable]
    public class Persona
    {
        private string name;
        private string last_name;
        private string rut;
        private int edad;

        public Persona(string name, string last_name, string rut, int edad)
        {
            this.Name = name;
            this.Last_name = last_name;
            this.Rut = rut;
            this.Edad = edad;
        }

        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Rut { get => rut; set => rut = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
