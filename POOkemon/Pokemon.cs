using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOkemon
{
    internal class Pokemon
    {
        //---------------------------------------------------EJEMPLO ABSTRACCION--------------------------------------------------
        //---------------------------------------------------EJEMPLO ENCAPSULACION-----------------------------------------------
        private string nombre;
        private string region;
        private int nivel;

        public string Nombre {  get { return nombre; } set {  nombre = value; } }
        public string Region { get { return region; } set {  region = value; } }
        public int Nivel
        {
            get { return nivel; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    nivel = value;
                }
                else
                {
                    Console.WriteLine("Ese nivel no es valido para tu pookemon");

                }
            }
        }

        //------------------------------------------EJEMPLO POLIMORFISMO-------------------------------------------------
        public virtual void Atacar()
        {
            Console.WriteLine(nombre + " ha atacado!");
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("\nNombre: " + Nombre);
            Console.WriteLine("Nivel: " + Nivel);
            Console.WriteLine("Region: " + Region);
        }

        public static void grito(string gr)
        {
            Console.WriteLine("El Pokemon ha gritado " + gr);
        }
    }
}
