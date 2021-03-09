using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        public Disco Top { get; set; }
        public List<Disco> Elementos { get; set; }

        public Pila()
        {
            this.Size = 0;
            Elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
                if (!this.Elementos.Contains(d))
                {
                    this.Elementos.Add(d);
                    this.Size++;
                    this.Top = d;
            }
            //si el disco existe no se añase  
        }
        public Disco pop()
        {
            Disco DiscoTop = new Disco();
            //cogemos el ultimo disco de la pila
            DiscoTop = Elementos.ElementAt(Elementos.Count()-1);
            //removemos el ultimo disco
            Elementos.RemoveAt(Elementos.Count()-1);
            //ponemos el nuevo ultimo disco y restablecemos el tamaño
            this.Size--;
            if(Elementos.Count() > 0)
            {
                this.Top = Elementos.ElementAt(Elementos.Count() - 1);
            }
            
            //devolvemos el disco recogido
            return DiscoTop;
        }                

        public bool isEmpty()
        {
            if(Elementos.Count() == 0)
            {
                return true;
            }
            return false;
        }

    }
}
