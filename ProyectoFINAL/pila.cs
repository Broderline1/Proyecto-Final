using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class pila
    {
        private int tope = 0;
        private int MAX;
        private Nodo inicio;

        public pila()
        {
            inicio = null;
        }

        public bool Empty()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }
        public bool Full()
        {
            if (tope == MAX)
                return true;
            else
                return false;
        }
        public void EstablecerTamaño(int tam)
        {
            if (tam <= 0)
            {
                Console.WriteLine("La cantidad a agregar debe ser mayor que 0°");
            }

            MAX += tam;
            Console.WriteLine($"Tope maximo : {MAX}. \n\n");

        }

        public bool Push(int num)
        {
            if (!Full())
            {
                Nodo nodoNuevo = new Nodo(num);
                nodoNuevo.Sig = inicio;
                inicio = nodoNuevo;
                tope++;
                return false;
            }
            else
            {
                Console.WriteLine("Pila llena.");
                return true;
            }

        }

        public int Pop()
        {
            if (!Empty())
            {
                int valExt = inicio.Valor;
                inicio = inicio.Sig;
                tope--;
                return valExt;
            }
            else
            {
                Console.WriteLine("Pila Vacía.");
                return -1;
            }
        }

        public void PrintStack()
        {
            if (Empty() == true)
            {
                Console.WriteLine("Pila vacía.");
            }
            else
            {
                Console.WriteLine("Contenido: ");
                Nodo act = inicio;
                int pos = tope;
                while (act != null)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine($"| Posición nodo: {pos}.   |");
                    Console.WriteLine($"| Valor nodo:    {act.Valor}.  |");
                    Console.WriteLine("-----------------------");
                    act = act.Sig;
                    pos--;
                }
                Console.WriteLine("");

            }
        }
    }
}