using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class Lista
    {
        Nodo inicio;

        // Constructor: inicializa la lista sin ningún nodo (inicio es null).
        public Lista()
        {
            inicio = null;
        }

        // Método para agregar un nuevo nodo al final de la lista.
        public void Add(int num)
        {
            Nodo nuevo = new Nodo(num); // Crea un nuevo nodo con el valor que recibimos como parámetro.

            if (inicio == null)
            {
                // Si la lista está vacía, el nuevo nodo será el primer nodo.
                inicio = nuevo;
            }
            else
            {
                // Si la lista no está vacía, recorremos hasta llegar al último nodo.
                Nodo act = inicio;

                // Recorremos hasta que encontremos un nodo cuyo siguiente sea null.
                while (act.Sig != null)
                    act = act.Sig;

                // Cuando encontramos el último nodo, le asignamos el nuevo nodo como siguiente.
                act.Sig = nuevo;
            }
        }

        // Método para imprimir la lista
        public void print()
        {
            if (inicio == null)
                Console.Write("La lista está vacía ");
            else
            {
                Nodo act = inicio;

                // Recorre la lista e imprime el valor de cada nodo.
                while (act != null)
                {
                    Console.Write($"{act.Valor} => ");
                    act = act.Sig;
                }
                Console.Write("null");
            }
        }

        // Método para buscar un nodo por su posición en la lista.
        public int Find(int pos)
        {
            if (inicio == null || pos < 0)
                return -1;

            Nodo act = inicio;
            int contador = 0;

            // Recorremos la lista nodo por nodo.
            while (act != null)
            {
                if (contador == pos)
                    return act.Valor; // Si llegamos a la posición deseada, devolvemos el valor del nodo.

                act = act.Sig;
                contador++;
            }

            return -1; // Si la posición no es válida, devolvemos -1.
        }

        // Método para contar cuántos nodos tiene la lista.
        public int Count()
        {
            if (inicio == null)
                return 0; // Si la lista está vacía, devolvemos 0.

            Nodo act = inicio;
            int contador = 0;

            // Recorremos la lista incrementando el contador.
            while (act != null)
            {
                contador++;
                act = act.Sig;
            }

            return contador; // Devolvemos el total de nodos.
        }

        // Método para buscar la posición de un valor específico en la lista.
        public int FindValue(int num)
        {
            if (inicio == null)
                return -1; // Si la lista está vacía, devolvemos -1.

            Nodo act = inicio;
            int posicion = 0;

            // Recorremos la lista buscando el valor.
            while (act != null)
            {
                if (act.Valor == num)
                    return posicion; // Si encontramos el valor, devolvemos su posición.

                act = act.Sig;
                posicion++;
            }

            return -1; // Si no se encuentra el valor, devolvemos -1.
        }

        // Método para cambiar el valor de un nodo en una posición específica.
        public bool Change(int pos, int num)
        {
            if (inicio == null || pos < 0)
                return false; // Si la lista está vacía o la posición no es válida, devolvemos false.

            Nodo act = inicio;
            int contador = 0;

            // Recorremos la lista buscando la posición.
            while (act != null)
            {
                if (contador == pos)
                {
                    act.Valor = num; // Si encontramos la posición, cambiamos el valor del nodo.
                    return true;
                }

                act = act.Sig;
                contador++;
            }

            return false; // Si no se encuentra la posición, devolvemos false.
        }

        // Método para eliminar un nodo en una posición específica.
        public bool Delete(int pos)
        {
            if (inicio == null || pos < 0)
                return false;

            // Si queremos eliminar el primer nodo
            if (pos == 0)
            {
                inicio = inicio.Sig;
                return true;
            }

            Nodo act = inicio;
            int contador = 0;

            // Recorremos la lista buscando el nodo anterior al que queremos eliminar
            while (act.Sig != null)
            {
                if (contador == pos - 1) // Buscamos el nodo anterior
                {
                    act.Sig = act.Sig.Sig; // Comprobamos que el siguiente nodo no sea null
                    return true;

                }

                act = act.Sig; // Avanzamos al siguiente nodo
                contador++; // Incrementamos el contador
            }

            return false; // Si no se encuentra la posición, devolvemos false.
        }
    }
}