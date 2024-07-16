using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArbol
{
    internal class ArbolBinario
    {
        Nodo raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        public void Insertar(int info)
        {
            Nodo nuevo = new Nodo(info);
            if(raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                Nodo anterior, reco;
                anterior = null;
                reco = raiz;

                while(reco != null)
                {
                    anterior = reco;
                    if(info < reco.Info)
                    {
                        reco = reco.Izq;
                    }
                    else
                    {
                        reco = reco.Der;
                    }
                }
                if(info < anterior.Info)
                {
                    anterior.Izq = nuevo;
                }
                else
                {
                    anterior.Der = nuevo;
                }
            }
        }

        private void ImprimirPre (Nodo reco)
        {
            if(reco != null)
            {
                Console.Write(reco.Info + " ");
                ImprimirPre(reco.Izq);
                ImprimirPre(reco.Der);
            }
        }

        public void ImprimirPre()
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }

        private void ImprimirEntre (Nodo reco)
        {
            if(reco != null)
            {
                ImprimirEntre(reco.Izq);
                Console.Write(reco.Info+" ");
                ImprimirEntre(reco.Der);
            }
        }

        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }

        private void ImprimirPost(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirPost(reco.Izq);
                ImprimirPost(reco .Der);
                Console.Write(reco.Info+" ");
            }
        }

        public void ImprimirPost()
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }

        public void Buscar(int criterio)
        {
            bool encontrado = false;
            Nodo anterior = null;
            Nodo reco = raiz;

            while(!encontrado && reco != null)
            {
                if (reco.Info == criterio)
                {
                    encontrado = true;
                }
                else
                {
                    anterior = reco;
                    
                    if (reco.Info > criterio)
                    {
                        reco = reco.Izq;
                    }
                    else
                    {
                        reco = reco.Der;
                    }
                }                
            }
            if(!encontrado)
            {
                Console.WriteLine("El elemento "+criterio+" no existe dentro del árbol.");
            }
            else
            {
                Console.WriteLine("El elemento " + criterio + " si existe dentro del árbol.");
            }
        }
    }
}