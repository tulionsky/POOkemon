using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POOkemon.ClasesHijas
{
    //-----------------------------------------------EJEMPLO HERENCIA-----------------------------------------------------
    internal class PokemonElectrico:Pokemon
    {
        private bool resistenciaelectrica;
        private bool agilidad;

        public bool ResistenciaElectrica {  get {  return resistenciaelectrica; } set {  resistenciaelectrica = value; } }
        public bool Agilidad { get {  return agilidad; } set {  agilidad = value; } }

        public PokemonElectrico(bool re, bool ag)
        {
            agilidad = ag;
            resistenciaelectrica=re;
        }

        public override void Atacar()
        {
            base.Atacar();
            Console.WriteLine("Ha usado Rayo!");
        }


        //--------------------------------------------EJEMPLO DELEGADO-----------------------------------------------
        public delegate void MiGrito(string gri);
        public void MostrarGrito()
        {
            MiGrito migrito = new MiGrito(Pokemon.grito);

            migrito("Pika Pika Pikachuu");

        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Su agilidad es de: "+agilidad);
            Console.WriteLine("La resistencia electrica de este pokemon es: "+resistenciaelectrica);
            Atacar();
        }
    }
}
