using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1 , n2, res ;
          
            Console.WriteLine("\n\n\tCALCULADORA");
            
            Console.WriteLine("\n\n\tIngresa solo dos números para ser sumados");
            si

            Console.WriteLine("\n\n\tIngresa el primero número");
            n1 =float.Parse( Console.ReadLine());

            Console.WriteLine("\n\n\tIngresa el segundo número");
            n2 =float.Parse(Console.ReadLine());

            if ((n1 % 2 == 0) && ( n2 % 2 == 0))
                {

                
                    Console.WriteLine("\n\n\n\tEs una suma par ");
                }

            else
                    {

                       
                        Console.WriteLine("\n\n\n\tEs una suma impar");
                    }

            res = n1 + n2;

            Console.WriteLine("\n\n\tEl Resultado de la operación es  S = " + n1 + " + " + n2 + " = " + res);
            Console.WriteLine("\n\n\n\tLa Parte Entera es : ");
            Console.WriteLine(Math.Truncate(res));
            Console.WriteLine("\n\tPresiona Enter para Salir");

            Console.ReadKey();



        }
    }
}
