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
            //si las dos estan vacias no hace nada
            if (a.isEmpty() && b.isEmpty())
            {
                return;
            }
            else
            {
                //si b esta vacia, mueve el disco de a -> b
                if (b.isEmpty())
                {
                    
                    b.push(a.pop());
                   
                    return;
                }
                //si a == 0 mueve el disco de b -> a
                if (a.isEmpty())
                {
                    a.push(b.pop());
                    return;
                }
                //si ninguna de las dos esta vacia procede:
                if (!b.isEmpty() && !a.isEmpty())
                {
                    //si discoA < discoB . Mueve el de a -> b
                    if (a.Top.valor < b.Top.valor)
                    {
                        b.push(a.pop());
                        return;
                    }//si discoA > discoB . Mueve el de a <- b
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
                    if (fin.Size == n) return contador;
                    mover_disco(ini, aux);
                    contador++;
                    if (fin.Size == n) return contador;
                    mover_disco(aux, fin);
                    contador++;
                    if (fin.Size == n) return contador;

                }
            }//si lo es ejecuta el siguiente
            else
            {
                while(fin.Size != n)
                {
                    if (fin.Size == n) return contador;
                    mover_disco(ini, aux);
                    contador++;
                    if (fin.Size == n) return contador;
                    mover_disco(ini, fin);
                    contador++;
                    if (fin.Size == n) return contador;
                    mover_disco(aux, fin);
                    contador++;
                    if (fin.Size == n) return contador;
                }
            }
            return contador;
        }

    }
}
