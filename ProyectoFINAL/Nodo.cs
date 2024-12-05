using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class Nodo
    {
        public int Valor { get; set; }
        public Nodo Sig { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Sig = null;
        }
    }
}