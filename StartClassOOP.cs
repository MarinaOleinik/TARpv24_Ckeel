using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24_Ckeel
{
    public class StartClassOOP
    {
        public static void Main(string[] args)
        {
            //Inimene inimene1 = new Inimene();

            Inimene inimene1 = new Õpilane();
            inimene1.Nimi = "Juku";
            inimene1.Vanus = 12;
            inimene1.Tervita();

            Õpilane inimene2 = new Õpilane("Kati", 28);
            inimene2.Mida_teeb();

            Töötaja töötaja1 = new Töötaja();
            töötaja1.Nimi = "Mati";
            töötaja1.Vanus = 45;
            töötaja1.Ametikoht = "Autojuht";
            töötaja1.Tervita();
            töötaja1.Töötan();
            töötaja1.Mida_teeb();

            töötaja1.Tunnid = 160;
            double palk = töötaja1.ArvutaPalk();
            Console.WriteLine($"Töötaja {töötaja1.Nimi} teenib kuus {palk} eurot.");
            Console.WriteLine($"Algne konto on {töötaja1.Konto.Saldo} eurot.");
            töötaja1.Konto.Saldo += palk;
            Console.WriteLine($"Pärast palka on kontol {töötaja1.Konto.Saldo} eurot.");
            töötaja1.Konto.VõtaRaha(200);
            Console.WriteLine($"Pärast sularaha võtmist on kontol {töötaja1.Konto.Saldo} eurot.");
            töötaja1.Konto.LisaRaha(500);
            Console.WriteLine($"Pärast raha lisamist on kontol {töötaja1.Konto.Saldo} eurot.");


            //1 ülesanne
            //3- Tee ise vähemalt 2 alamklassi ja kasuta neid siin
            //4.5- Tee enda põhiklass ja 2 alamklassi ning kasuta neid siin
            //2 ülesanne
            /*- Tee enda põhiklass(Loom) ja 2-3 alamklassi(Kass, Koer, Lehm)
            ning kasuta 2-3 abstraktset meetodit*/
        }

    }
}
