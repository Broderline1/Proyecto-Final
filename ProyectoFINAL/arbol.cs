using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class arbol
    {
        public NodoArbol raiz;
        private NodoArbol obs;

        public void Insertar(int v)
        {
            NodoArbol nuevo, psave;
            Boolean Found = false;
            psave = obs;
            Found = FindKey(v);

            if (Found)
            {
                Console.WriteLine("El nodo ya existe");
                obs = psave;
            }
            else
            {
                nuevo = new NodoArbol(v);
                if (raiz == null)
                {
                    raiz = nuevo;
                    obs = nuevo;
                }
                else
                {
                    if (v < obs.valor)
                        obs.izq = nuevo;
                    else
                        obs.der = nuevo;
                    obs = nuevo;
                }
            }
        }

        private bool FindKey(int v)
        {
            Boolean Found = false;
            NodoArbol q;
            q = raiz;

            while (!Found && q != null)
            {
                if (v == q.valor)
                {
                    obs = q;
                    Found = true;
                }
                else
                {
                    if (v < q.valor)
                    {
                        if (q.izq == null)
                            obs = q;
                        q = q.izq;
                    }
                    else
                    {
                        if (q.der == null)
                            obs = q;
                        q = q.der;
                    }
                }
            }
            return Found;
        }

        public void Recorrido(NodoArbol q)
        {
            if (q != null)
            {
                Console.Write($"{q.valor},");
                Recorrido(q.izq);
                Console.Write($"{q.valor},");
                Recorrido(q.der);
                Console.Write($"{q.valor},");
            }
        }

        public int CalcularAltura(NodoArbol q)
        {
            if (q == null)
                return 0;

            int altIzq = CalcularAltura(q.izq);
            int altDer = CalcularAltura(q.der);
            return Math.Max(altIzq, altDer) + 1;
        }

        public int Tamaño(NodoArbol q)
        {
            if (q == null)
                return 0; // Caso base: Si no hay nodo, no sumamos nada.

            // Calculamos el tamaño recursivamente
            int tamañoIzq = Tamaño(q.izq);
            int tamañoDer = Tamaño(q.der);
            return 1 + tamañoIzq + tamañoDer; // 1 por el nodo actual + los tamaños de los subárboles.
        }

        public double LRP()
        {
            var resultado = CalcularLRP(raiz, 1); // Empieza desde nivel 1
            return resultado.TotalLongitud / resultado.TotalNodos;
        }

        private (double TotalLongitud, int TotalNodos) CalcularLRP(NodoArbol q, int nivel)
        {
            if (q == null)
                return (0, 0);

            // Llamamos recursivamente para izq y der
            var nodosIzq = CalcularLRP(q.izq, nivel + 1);
            var nodosDer = CalcularLRP(q.der, nivel + 1);

            // Acumulamos la longitud actual y contamos el nodo
            return (
                nivel + nodosIzq.TotalLongitud + nodosDer.TotalLongitud,
                1 + nodosIzq.TotalNodos + nodosDer.TotalNodos
            );
        }
    }
}