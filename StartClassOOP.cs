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
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Juku";
            inimene1.Vanus = 12;
            inimene1.Tervita();

            Inimene inimene2 = new Inimene("Kati", 28);
            
            Töötaja töötaja1 = new Töötaja();
            töötaja1.Nimi = "Mati";
            töötaja1.Vanus = 45;
            töötaja1.Ametikoht = "Autojuht";
            töötaja1.Tervita();
            töötaja1.Töötan();
            //3- Tee ise vähemalt 2 alamklassi ja kasuta neid siin
            //4.5- Tee enda põhiklass ja 2 alamklassi ning kasuta neid siin
        }

    }
}
