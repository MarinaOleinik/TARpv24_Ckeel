using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24_Ckeel
{
    internal class Osa3_funktsioonid
    {
        public static double[] Tekstist_arvud()
        {
            Console.WriteLine("Sisesta arvud koma või tühikuga eraldatult: ");
            string sisend = Console.ReadLine();
            char[] eraldajad = new char[] {' '};//
            
            string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);
            
            double[] arvud = new double[osad.Length];
            for (int i = 0; i < osad.Length; i++)
            {
                arvud[i] = Convert.ToDouble(osad[i]);
            }
            return arvud;
        }
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }
        
    }
}
