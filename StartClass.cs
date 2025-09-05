using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24_Ckeel
{
    internal class StartClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            //2. Osa Valikud
            int kuu_number=rnd.Next(1,12);
            string nimetus = Osa1_funktsioonid.Kuu_nimetus(kuu_number);
            Console.WriteLine( $"Nr: {kuu_number}-{nimetus}");
            Console.WriteLine("Kas tahad dekodeerida arv->nimetusse?");
            string vastus=Console.ReadLine();
            if (vastus.ToLower() != "jah")
            {
                Console.WriteLine("Ei taha, siis ei taha");
            }
            else
            {
                try
                {
                    Console.Write("Nr: ");
                    kuu_number=int.Parse(Console.ReadLine());
                    Console.WriteLine(Osa1_funktsioonid.Hooaeg(kuu_number));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }  
            }


            ////I. Osa Andmetüübid, Alamfunktsioon
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.DarkRed;

            //Console.WriteLine("Tere tulemast! Mis on simu nimi?");
            //string tekst=Console.ReadLine();
            //Console.WriteLine($"{tekst}, Rõõm näha!");
            //int a = 1000;
            //char taht = 'A';
            //Console.Write($"Esimene arv on {a}, Sisesta b=...");
            //int b=int.Parse(Console.ReadLine());
            //Console.WriteLine("Esimene arv on {0}, Sisesta {1}. Summa on {2}",a,b,a +b);
            //Console.WriteLine("Ujukomaarv");
            //double d=double.Parse(Console.ReadLine());
            //Console.WriteLine(d);
            //float f=float.Parse(Console.ReadLine());
            //Console.WriteLine(f);
            //bool t = true;

            //a = rnd.Next(-100,200);
            //Console.WriteLine(a);
            //float vastus=Osa1_funktsioonid.Kalkulaator(f,a);
            //Console.WriteLine($"Kalkulaatori tulemus: {vastus}");

        }
    }

}
