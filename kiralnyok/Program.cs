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
        public void elhelyezes()
        {

        }
        public void megjelenit()
        {

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
            //Tabla t = new Tabla();
            
            

            Console.ReadKey();
        }
    }
}
