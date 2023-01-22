using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_oop2
{
    internal class Program
    {
        class GeometrijskiLik
        {
            protected byte BrojStranica;
            protected double[] Stranice = new double[10];
            public void UcitajStranice()
            {
                for (int i = 0; i < BrojStranica; i++)
                {
                    Console.WriteLine("Upišite duljinu {0}. stranice", i + 1);
                    Stranice[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            public double Opseg()
            {
                double opseg = 0;
                for (int i = 0; i < BrojStranica; i++)
                    opseg += Stranice[i];
                return opseg;
            }
        }
        class Trokut : GeometrijskiLik
        {
            public Trokut()
            {
                BrojStranica = 3;
            }
        }
        class Cetverokut : GeometrijskiLik
        {
            public Cetverokut()
            {
                BrojStranica = 4;
            }
        }

        static void Main(string[] args)
        {
            Trokut t = new Trokut();
            t.UcitajStranice();
            Console.WriteLine("Opseg trokuta je {0}", t.Opseg());
            Cetverokut c = new Cetverokut();
            c.UcitajStranice();
            Console.WriteLine("Opseg četverokuta je {0}", c.Opseg());
        }
    }
}
