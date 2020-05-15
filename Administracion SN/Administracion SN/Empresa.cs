using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_SN
{
    [Serializable]
    public class Empresa
    {
        private string nombre;
        private string rut;
        private List<Division> div = new List<Division>();

        public Empresa(string nombre, string rut)
        {
            this.Nombre = nombre;
            this.Rut = rut;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }
        public List<Division> Div { get => div; set => div = value; }

        public string Get_Nombre()
        {
            return nombre;
        }

        public string Get_RUT()
        {
            return rut;
        }

        public List<Division> Get_Div()
        {
            return div;
        }

        public void Add_to_Div(Division division)
        {
            div.Add(division);
        }

    }
}
