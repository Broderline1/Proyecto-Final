using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class NodoArbol
    {
        public int valor;
        public NodoArbol izq;
        public NodoArbol der;
        public NodoArbol(int Valor)
        {
            valor = Valor;
            izq = null;
            der = null;
        }
    }
}