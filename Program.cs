using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {

        public static void pulsacionesMujer()
        {
            int pulsacionesM = 220;
            int edad;
            int segundosAerobicos = 10;

            int pulsaciones;



            Console.WriteLine("Edad de la mujer: ");
            edad = Convert.ToInt32(Console.ReadLine());

            pulsaciones = (pulsacionesM - edad) / segundosAerobicos;

            Console.WriteLine("Este Mujer cuenta con : {0} ", pulsaciones + " pulsaciones por segundo ");
        }

        public  static void  pulsacionesHombre()
        {
            int pulsacionesF = 210;
            int edad;
            int segundosAerobicos = 10;

            int pulsaciones;



            Console.WriteLine("Edad de Hombre: ");
            edad = Convert.ToInt32(Console.ReadLine());

            pulsaciones = (pulsacionesF - edad) / segundosAerobicos;

            Console.WriteLine("Este Hombre cuneta con : {0} ", pulsaciones +" pulsaciones por segundo ");
        }
    

        static void Main(string[] args)
        {

            //int pulsacionesF = 220;
            //int pulsacionesM = 210;
            //int edad;
            //int segundosAerobicos = 10;

            int pulsaciones;

            ConsoleKeyInfo op;

            do
            {

                
                Console.WriteLine("Seleccione una Opcion:\n " +
                    "\nOp1. Hombre"+
                    "\nOp2. Mujer"+
                    "\nEsc");
                op = Console.ReadKey(true);

                switch (op.Key)
                {
                    case ConsoleKey.D1 :

                        pulsacionesHombre();
                       
                        break;


                    case ConsoleKey.D2 :

                        pulsacionesMujer();

                        break;

                    case ConsoleKey.Escape:
                        break;
                }

            } while (op.Key != ConsoleKey.Escape);
            



        }

        

        

    }
}
