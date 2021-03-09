using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
       public static  bool move;
        public void mover_disco(Pila a, Pila b)
        {
            //si la pila b esta vacia mueve el disco top de A a la B

            /*
            if (b.isEmpty())
            {
               b.push(a.pop());
                Console.WriteLine("moviendo disco de a a b");
                Console.WriteLine(a.Size +"Cantidad elementos de a");
                Console.WriteLine(b.Size + "Cantidad elementos de b");
                move = true;
            }else if (a.isEmpty() && move==false)
            {
                a.push(b.pop());
                move = true;
                Console.WriteLine("moviendo disco de B a A");
                Console.WriteLine(a.Size + "Cantidad elementos de a");
                Console.WriteLine(b.Size + "Cantidad elementos de b");

            }
            else if(a.Top.valor < b.Top.valor && move == false)
            {
                

                //si el valor de discoA es menor que el discoB se añade a la pila B.
                if(a.Top.valor < b.Top.valor)
                {
                    b.push(a.pop());
                    Console.WriteLine("moviendo disco de A a B, A siendo menor que B");
                    Console.WriteLine(a.Size + "Cantidad elementos de a");
                    Console.WriteLine(b.Size + "Cantidad elementos de b");

                }
                move = true;
            }
            else if(a.Top.valor > b.Top.valor && move == false)
            {
                //si no esta vacia, coje los dos discos top y los compara
                
                //si el valor de discoA es menor que el discoB se añade a la pila B.
                if (b.Top.valor < a.Top.valor)
                {
                    a.push(b.pop());
                    Console.WriteLine("moviendo disco de A a B, B siendo menor que A");
                    Console.WriteLine(a.Size + "Cantidad elementos de a");
                    Console.WriteLine(b.Size + "Cantidad elementos de b");

                }
                move = true;
            }*/
            /*
            move = false;
            if (!b.isEmpty() && !a.isEmpty())
            {
                if(a.Top.valor > b.Top.valor)
                {
                    b.push(a.pop());
                    move = true;
                }
                else if( move == false)
                {
                    a.push(b.pop());
                    move = true;
                }
            }
            if (b.isEmpty() && move == false)
            {
                b.push(a.pop());
                move = true;
            }
            if (a.isEmpty() && move == false)
            {
                b.push(a.pop());
                move = true;
            }
            */

            //si b esta vacia, coge a y va hacia b
            //si a esta vacia, coge de b y va hacia a
            //si a>b, a-->b
            //si a<b, b --->a

            if (a.isEmpty() && b.isEmpty())
            {
                return;
            }
            else
            {
                if (b.isEmpty())
                {
                    b.push(a.pop());
                    return;
                }

                if (!b.isEmpty() && !a.isEmpty())
                {
                    if (a.Top.valor < b.Top.valor)
                    {
                        b.push(a.pop());
                        return;
                    }
                    else if (b.Top.valor < a.Top.valor)
                    {
                        a.push(b.pop());
                        return;
                    }
                    else
                    {
                        return;
                    }
                }

                
                if (a.isEmpty() )
                {
                    a.push(b.pop());
                    return;
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int contador = 0;
            //si no es par ejecuta el codigo
            if(n%2 != 0)
            {
                while(fin.Size != n)
                {
                    if (fin.Size == n) return contador;
                    mover_disco(ini, fin);
                    contador++;
                    if (fin.Size == n)
                    {
                        return contador;
                    }

                    mover_disco(ini, aux);
                    contador++;
                    if (fin.Size == n)
                    {
                        return contador;
                    }

                    mover_disco(aux, fin);
                    contador++;
                    if (fin.Size == n)
                    {
                        return contador;
                    }

                }
            }//si lo es ejecuta el siguiente
            else
            {
                while(fin.Size != n)
                {
                    if (fin.Size == n) return contador;
                    mover_disco(ini, aux);
                    contador++;
                    //Console.WriteLine("contador: "+contador);
                    //Console.WriteLine("numero Fin.Size =====>" + fin.Size);
                    if (fin.Size == n) return contador;
                    mover_disco(ini, fin);
                    contador++;
                   // Console.WriteLine("contador: " + contador);
                   // Console.WriteLine("numero Fin.Size =====>" + fin.Size);
                    if (fin.Size == n) return contador;
                    mover_disco(aux, fin);
                   // Console.WriteLine("contador: " + contador);
                }
            }
            return contador;
        }

    }
}
