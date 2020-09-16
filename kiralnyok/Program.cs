using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiralnyok
{
    class Tabla
    {
        private char UresCella;
        private char UresOszlopSzam;
        private char UresSorokSzama;
        private char[,] T ;
        public void elhelyezes(int N)
        {
            //Véletlen helyiérték létrehozása:
            // - Random osztály értékkészlet: [0,7]
            // - Véletlen sor és oszlop
            // - Elhelyezzük a k-t;
            // - HA ÜRES -> "#"
            Random r = new Random();
            int sor = r.Next(0, 8);
            int oszlop = r.Next(0, 8);
            T[sor, oszlop] = 'K';
            if (T[sor,oszlop] == '#')
            {
                T[sor, oszlop] = 'k';
            }


        }
        public void megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(T[i,j] + " ");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine();
            
            
        }


        public Tabla(char ch)
        {
            T = new char[8, 8];
            UresCella = ch;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    T[i, j] = UresCella;
                }
            }
        }
        public int Uresoszlopok()
        {
            return 0;
        }
        public int uressor()
        {
            return 0;
        }

        public void fajlbair()
        {

        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Tabla t = new Tabla('#');
            Console.WriteLine("Üres tábla");
            t.megjelenit();
            t.elhelyezes(1);
            Console.WriteLine();
            t.megjelenit();

                    
            

            Console.ReadKey();
        }
    }
}