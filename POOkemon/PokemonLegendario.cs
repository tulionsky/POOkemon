using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOkemon
{
    internal interface IPokemonLegendario
    {
        public int NivelPoder { get; set; }

        public string PoderLegendario();
    }
}
