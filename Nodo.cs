using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArbol
{
    internal class Nodo
    {
        private int info;
        private Nodo izq, der;

        public Nodo(int info, Nodo izq, Nodo der)
        {
            this.info = info;
            this.izq = izq;
            this.der = der;
        }

        public Nodo() { 
            this.info=0;
            this.izq=null;
            this.der=null;
        }

        public Nodo(int info)
        { 
            this.info=info; 
            this.izq=null;
            this.der=null;
        }

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public Nodo Izq 
        { 
            get { return izq; } 
            set { izq = value; }
        }

        public Nodo Der
        {
            get { return der; }
            set { der = value; }
        }
    }
}
