using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class Cola
    {
        private Nodo inicio;

        private int count = 0;

        private int Max;

        public Cola(int max)
        {
            Max = max;
            inicio = null;
        }

        private bool underflow()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        private bool overflow()
        {
            if (count == Max)
                return true;
            else
                return false;
        }

        public int Count()
        {
            return count;
        }

        //******************************************************************************
        //*                             METODOS DE FUNCIONAMIENTO                      *
        //******************************************************************************

        public void InsertarTamano(int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La cantidad a agregar debe ser mayor a 0");
                Console.ResetColor();
            }

            inicio = null;
            count = 0;
            Max = cantidad;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Capacidad de la cola incrementada.\nNuevo tope maximo: {Max}");
            Console.ResetColor();
        }

        public void Print()
        {
            if (underflow() == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La cola está vacía, no existe ningún valor.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Contenido de la cola:");

                Nodo act = inicio;
                Console.ForegroundColor = ConsoleColor.Yellow;

                while (act != null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"[{act.Valor}] ");


                    if (act.Sig != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("->");
                    }

                    Console.ResetColor();
                    act = act.Sig;
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public bool Insert(int num)
        {
            if (overflow())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La cola está llena, no se puede insertar más datos.");
                Console.ResetColor();
                return true;
            }
            else
            {
                Nodo nuevoNodo = new Nodo(num);
                nuevoNodo.Sig = null;

                if (inicio == null)
                {
                    inicio = nuevoNodo;
                }
                else
                {
                    Nodo act = inicio;
                    while (act.Sig != null)
                    { act = act.Sig; }

                    act.Sig = nuevoNodo;
                    count++;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Se ha insertado el valor {num} exitosamente en la cola.");
                Console.ResetColor();
                return false;
            }
        }

        public int Extract()
        {
            if (underflow())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La cola está vacía, no se puede extraer ningún valor.");
                Console.ResetColor();
                return -1;
            }

            int valorExtraido = inicio.Valor;
            inicio = inicio.Sig;
            count--;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Se ha extraído el valor {valorExtraido} de la cola.");
            Console.ResetColor();
            return valorExtraido;
        }
    }
}