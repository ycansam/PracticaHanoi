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
               Disco discoA = a.pop();  
               b.push(discoA);
            }
            else
            {
                //si no esta vacia, coje los dos discos top y los compara
                Disco discoTopA = a.Top;
                Disco discoTopB = b.Top;
                //si el valor de discoA es menor que el discoB se añade a la pila B.
                if(discoTopA.valor < discoTopB.valor)
                {
                    b.push(a.pop());
                }
            } 

            if (a.isEmpty())
            {
                Disco discoB = b.pop();
                a.push(discoB);
            }
            else
            {
                //si no esta vacia, coje los dos discos top y los compara
                Disco discoTopA = a.Top;
                Disco discoTopB = b.Top;
                //si el valor de discoA es menor que el discoB se añade a la pila B.
                if (discoTopB.valor < discoTopA.valor)
                {
                    a.push(b.pop());
                }
            }


        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
