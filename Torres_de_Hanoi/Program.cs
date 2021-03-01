using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();

            Disco A = new Disco(1);
            Disco B = new Disco(2);
            Disco C = new Disco(3);

            ini.push(C);
            ini.push(B);
            ini.push(A);

            Hanoi hanoi = new Hanoi();
            int num = hanoi.iterativo(3, ini, fin, aux);
            Console.WriteLine(num);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
 
        }

    }
}
