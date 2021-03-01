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
            //si el disco existe no se añase
            if (!this.Elementos.Contains(d))
            {
                this.Elementos.Add(d);
                this.Size = Elementos.Count();
                this.Top = Elementos.ElementAt(Elementos.Count());
            }
        }
        public Disco pop()
        {
            //cogemos el ultimo disco de la pila
            Disco DiscoTop = Elementos.ElementAt(Elementos.Count());
            //removemos el ultimo disco
            Elementos.RemoveAt(Elementos.Count());
            //ponemos el nuevo ultimo disco y restablecemos el tamaño
            this.Size = Elementos.Count();
            this.Top = Elementos.ElementAt(Elementos.Count());

            //devolvemos el disco recogido
            return DiscoTop;
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
