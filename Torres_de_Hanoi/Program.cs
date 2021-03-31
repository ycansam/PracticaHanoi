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
            int number;

            Console.Write("Introduce numero de discos"+Environment.NewLine);

            bool success = Int32.TryParse(Console.ReadLine(), out number);
            if (success)
            {
                int numDiscos = number;

                if (numDiscos == 0)
                {
                    Console.Write("El resultado es: 0");
                    Console.ReadKey();
                }
                else if(numDiscos < 0)
                {
                    Console.Write("No se puede obtener un resultado, introduzca un numero de discos valido." +Environment.NewLine);
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Seleccione: 1-Iteravo, 2-Recursivo" + Environment.NewLine);
                    Int32.TryParse(Console.ReadLine(), out number);
                    if(number == 1)
                    {
                        List<Disco> l_discos = new List<Disco>();

                        for (int i = numDiscos; i > 0; i--)
                        {
                            ini.push(new Disco(i));
                            l_discos.Add(new Disco(i));
                        }

                        Hanoi hanoiManual = new Hanoi();
                        int numMan = hanoiManual.iterativo(numDiscos, ini, fin, aux);
                        Console.WriteLine("El resultado es: " + numMan);
                        int res = 1;
                        for (int i = 0; i < numDiscos; i++)
                        {
                            res = 2 * res;
                        }
                        res = res - 1;

                        Console.WriteLine("El resultado con operaciones es: " + res);
                        Console.ReadKey();
                    }
                    else
                    {
                        List<Disco> l_discos = new List<Disco>();

                        for (int i = numDiscos; i > 0; i--)
                        {
                            ini.push(new Disco(i));
                            l_discos.Add(new Disco(i));
                        }

                        Hanoi hanoiManual = new Hanoi();
                        int numMan = hanoiManual.recursivo(numDiscos, ini, fin, aux);
                        Console.WriteLine("El resultado de recursivo es: " + numMan);
                        int res = 1;
                        for (int i = 0; i < numDiscos; i++)
                        {
                            res = 2 * res;
                        }
                        res = res - 1;

                        Console.WriteLine("El resultado con operaciones es: " + res);
                        Console.ReadKey();
                    }

                }
            }
            else
            {
                Console.WriteLine("El valor introducido no es un numero ");
                Console.ReadKey();
            }
        }

    }
}
