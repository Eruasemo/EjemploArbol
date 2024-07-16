using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario test = new ArbolBinario();
            test.Insertar(100);
            test.Insertar(50);
            test.Insertar(25);
            test.Insertar(75);
            test.Insertar(150);
            Console.WriteLine("Impresion preorden: ");
            test.ImprimirPre();
            Console.WriteLine("Impresion entreorden: ");
            test.ImprimirEntre();
            Console.WriteLine("Imprimir postorden: ");
            test.ImprimirPost();
            

            test.Buscar(200);
        }
    }
}
