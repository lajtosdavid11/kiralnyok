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
        private char[,] t ;
        
        public void elhelyezes(int N)
        {
            //Véletlen helyiérték létrehozása:
            // - Random osztály értékkészlet: [0,7]
            // - Véletlen sor és oszlop
            // - Elhelyezzük a k-t;
            // - HA ÜRES -> "#"
            Console.Write("Hány királynő legyen: ");
            

            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                bool igaz = true;
                while (igaz)
                {
                    int sor = rnd.Next(0, 8);
                    int oszlop = rnd.Next(0, 8);
                    if (t[sor, oszlop] == '#')
                    {
                        t[sor, oszlop] = 'K';
                        igaz = false;
                    }

                }
            }



        }
        public void megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(t[i,j] + " ");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine();
            
            
        }


        public Tabla(char ch)
        {
            t = new char[8, 8];
            UresCella = ch;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    t[i, j] = UresCella;
                }
            }
        }
        public bool Uresoszlopok(int oszlop)
        {
            int i = 0;
            
            
            while (i<8 && t[i,oszlop] != 'K')
            {
                
                i++;
            }
            if (i < 8 )
            {
                return false;
            }
            else
            {
                return true;
            }
            


        }
        public bool uressor(int sor)
        {
            int i = 0;


            while (i < 8 && t[sor,i] != 'K')
            {

                i++;
            }
            if (i < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
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
            t.elhelyezes(5);
            Console.WriteLine();
            t.megjelenit();
            Console.WriteLine("Melyik sor?");
            int sor = int.Parse(Console.ReadLine());
            int oszlop = int.Parse(Console.ReadLine());
            if (t.uressor(sor))
            {
                Console.WriteLine("A megadott sor üres");
            }
            else
            {
                Console.WriteLine("A megadott sor nem üres");
            }
            if (t.Uresoszlopok(oszlop))
            {
                Console.WriteLine("A megadott oszlop üres");
            }
            else
            {
                Console.WriteLine("A megadott oszlop nem üres");
            }

            Console.WriteLine("Az üres oszlopok és sorok száma:");
            int uresSor = 0;
            int uresOszlop = 0;
            for (int i = 0; i < 8; i++)
            {
                if (t.Uresoszlopok(i) == true)
                {
                    uresOszlop++;
                }
                if (t.uressor(i) == true)
                {
                    uresSor++;
                }
            }
            Console.WriteLine("Üres sorok száma: {0}",uresSor);
            Console.WriteLine("Üres oszlopok száma:{0}",uresOszlop);





            Console.ReadKey();
        }
    }
}