using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_SN
{
    [Serializable]
    public class Area : Division
    {
        public Area(string nombre) : base(nombre)
        {

        }
    }
}
