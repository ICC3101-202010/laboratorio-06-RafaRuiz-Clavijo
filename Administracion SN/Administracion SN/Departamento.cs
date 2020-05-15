using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_SN
{
    [Serializable]
    class Departamento : Division
    {
        public Departamento(string nombre) : base(nombre)
        {

        }
    }
}
