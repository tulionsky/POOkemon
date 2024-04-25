using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOkemon.ClasesHijas
{
    //------------------------------------------------EJEMPLO INTERFACES----------------------------------------
    internal class PokemonFuego : Pokemon, IPokemonLegendario
    {
        private int poder;

        public int NivelPoder { get { return poder; } set { poder = value; } }

        public PokemonFuego(int p)
        {
            poder = p;
        }

        public string PoderLegendario()
        {
            return "El Poder de este legendario es de "+poder;
        }

        //--------------------------------------------EJEMPLO EVENTOS-----------------------------------------------
        public delegate void PokemonFuegoEventHandler();

        public event PokemonFuegoEventHandler Ataque;
        
        public void ComprobarAtaque()
        {
            if (Ataque != null)
            {
                Ataque();
            }
            else
            {
                Console.WriteLine("El ataque ha fallado");
            }
        }

        public void AtacarEvento()
        {
            Console.WriteLine("Ha usado Fuego Sagrado!");
        }

        

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine(PoderLegendario());
            //Atacar();
        }
    }
}
