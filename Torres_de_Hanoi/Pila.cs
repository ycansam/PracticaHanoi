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
        public Disco Top { get =>this.Top; set => this.Top = value; }
        public List<Disco> Elementos { get; set; }

        public Pila()
        {
            this.Size = 0;
        }

        public void push(Disco d)
        {
            if (!this.Elementos.Contains(d))
            {
                this.Elementos.Add(d);
                this.Size++;
                this.Top = Elementos.ElementAt(Elementos.Count());
            }
        }
        public Disco pop()
        {
            return this.Top;
        }                

        public bool isEmpty()
        {
            if(this.Elementos.Count() != 0)
            {
                return true;
            }
            return false;
        }

    }
}
