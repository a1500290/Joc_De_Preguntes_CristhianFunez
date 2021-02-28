using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc_De_Preguntes_CristhianFunez
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            string tema;
            Console.WriteLine("Juego de preguntas");
            //pas 1
            tema = escollirTema(); 


        }
        
        static string escollirTema()
        {
            string tema="", opcio;
            Console.WriteLine("escoge una opcio o prem 'Q' per surti");
            Console.WriteLine("1 - Geografia");
            Console.WriteLine("2 - Arte y literatura");
            Console.WriteLine("3 - Micelánea");
            do
            {
                opcio = Console.ReadLine();
                switch (opcio)
                {
                    
                }
            } while (opcio == "");
            return tema;
        }
    }
}
