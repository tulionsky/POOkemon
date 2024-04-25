using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOkemon.parte2
{
    internal class Pkmn
    {
        private string nombre;
        private string region;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Region { get { return region; } set { region = value; } }
       

        public Pkmn (string n, string r)
        {
            nombre = n;
            region = r;
        }

        public void MostrarEquipo()
        {
            Console.WriteLine("El Pokemon: "+nombre);
            Console.WriteLine("Es de la Region: "+region);
            Console.WriteLine("-----------------");
        }
    }
}
