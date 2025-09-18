using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24_Ckeel
{
    public abstract class Inimene
    {
        public string Nimi;
        public int Vanus;
        public Inimene()
        {
            //Nimi = "Mati";
            //Vanus = 99;
        }
        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public void Tervita()
        {
            Console.WriteLine("Tere! Mina olen " + Nimi);
        }
        public abstract void Mida_teeb();
    }
   
}
