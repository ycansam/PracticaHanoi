using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public void mover_disco(Pila a, Pila b)
        {
            //si la pila b esta vacia mueve el disco top de A a la B
            if (b.isEmpty())
            {
                Disco discoA = new Disco();
               discoA = a.pop();     
               b.push(discoA);
            }else if (a.isEmpty())
            {
                Disco discoB = b.pop();
                a.push(discoB);
            }
            else if(a.Top.valor < b.Top.valor)
            {
                //si no esta vacia, coje los dos discos top y los 
                Disco discoTopA = new Disco();
                Disco discoTopB = new Disco();

                discoTopB = b.Top;
                discoTopA = a.Top;

                //si el valor de discoA es menor que el discoB se añade a la pila B.
                if(discoTopA.valor < discoTopB.valor)
                {
                    b.push(a.pop());
                }
            }else if(a.Top.valor > b.Top.valor)
            {
                //si no esta vacia, coje los dos discos top y los compara
                Disco discoTopA = new Disco();
                Disco discoTopB = new Disco();

                discoTopA = a.Top;
                discoTopB = b.Top;
                //si el valor de discoA es menor que el discoB se añade a la pila B.
                if (discoTopB.valor < discoTopA.valor)
                {
                    a.push(b.pop());
                }
            }
            /*
            if (a.isEmpty())
            {
                Disco discoB = b.pop();
                a.push(discoB);
            }
            else
            {
                //si no esta vacia, coje los dos discos top y los compara
                Disco discoTopA = new Disco();
                Disco discoTopB = new Disco();

                discoTopA = a.Top;
                discoTopB = b.Top;
                //si el valor de discoA es menor que el discoB se añade a la pila B.
                if (discoTopB.valor < discoTopA.valor)
                {
                    a.push(b.pop());
                }
            }
            */

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int contador = 0;
            //si no es par ejecuta el codigo
            if(n%2 != 0)
            {
                while(fin.Size != n)
                {
                    Console.WriteLine("numero Fin.Size =====>" + fin.Size);
                    if (fin.Size == n)
                    {
                        return contador;
                    }
                    mover_disco(ini, fin);
                    contador++;
                    Console.WriteLine(contador);
                    Console.WriteLine("numero Fin.Size =====>" + fin.Size);
                    if (fin.Size == n)
                    {
                        return contador;
                    }

                    mover_disco(ini, aux);
                    contador++;
                    Console.WriteLine(contador);
                    Console.WriteLine("numero Fin.Size =====>" + fin.Size);
                    if (fin.Size == n)
                    {
                        return contador;
                    }

                    mover_disco(aux, fin);
                    contador++;
                    Console.WriteLine(contador);
                    Console.WriteLine("numero n =====>" + n);
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
                    mover_disco(ini, aux);
                    contador++;
                    mover_disco(ini, fin);
                    contador++;
                    mover_disco(aux, fin);
                }
            }
            return contador;
        }

    }
}
