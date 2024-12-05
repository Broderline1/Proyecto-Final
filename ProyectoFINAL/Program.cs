using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFINAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selMenu;

            do
            {
                Console.Write("MENU PROYECTO FINAL\r\n---------------------------------------\r\n1.- Listas\r\n2.- Pilas\r\n3.- Colas\r\n4.- Árboles\r\n5.- Salir\r\n_________________________\r\nSelecciónar Opción => ");
                selMenu = Convert.ToInt32(Console.ReadLine());
                switch (selMenu)
                {
                    case 1:
                        /********************* LISTAS ************************/

                        Lista milista = new Lista(); // Creamos una nueva lista vacía.
                        // Este ciclo se repite hasta que el usuario elija salir (opción 8).
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("MENU LISTAS");
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("1.- Insertar Nodo");
                            Console.WriteLine("2.- Imprimir Tamaño");
                            Console.WriteLine("3.- Buscar Nodo por Posición");
                            Console.WriteLine("4.- Borrar Nodo");
                            Console.WriteLine("5.- Modificar Nodo");
                            Console.WriteLine("6.- Buscar Nodo por Valor");
                            Console.WriteLine("7.- Imprimir Lista");
                            Console.WriteLine("8.- Regresar");
                            Console.Write("Seleccionar Opción => ");
                            selMenu = int.Parse(Console.ReadLine()); // Leemos la opción del usuario.

                            switch (selMenu)
                            {
                                case 1:
                                    // Opción para insertar un nodo.
                                    Console.Write("Teclear valor del nodo a insertar: ");
                                    int valorInsertar = int.Parse(Console.ReadLine());
                                    milista.Add(valorInsertar); // Agregamos el nuevo valor a la lista.
                                    Console.WriteLine("Nodo insertado correctamente.");
                                    break;

                                case 2:
                                    // Opción para imprimir el tamaño de la lista.
                                    int tamano = milista.Count();
                                    Console.WriteLine($"La lista tiene {tamano} nodos.");
                                    break;

                                case 3:
                                    // Opción para buscar un nodo por su posición.
                                    Console.Write("Dame la posición del nodo a buscar: ");
                                    int posBuscar = int.Parse(Console.ReadLine());
                                    int valorNodo = milista.Find(posBuscar);
                                    if (valorNodo != -1)
                                        Console.WriteLine($"El valor en la posición {posBuscar} es: {valorNodo}");
                                    else
                                        Console.WriteLine("Posición no válida.");
                                    break;

                                case 4:
                                    // Opción para borrar un nodo por su posición.
                                    Console.Write("Dame la posición del nodo a borrar: ");
                                    int posBorrar = int.Parse(Console.ReadLine());
                                    if (milista.Delete(posBorrar))
                                        Console.WriteLine("Nodo borrado correctamente.");
                                    else
                                        Console.WriteLine("Posición no válida o lista vacía.");
                                    break;

                                case 5:
                                    // Opción para modificar el valor de un nodo.
                                    Console.Write("Dame la posición del nodo a modificar: ");
                                    int posModificar = int.Parse(Console.ReadLine());
                                    Console.Write("Dame el nuevo valor: ");
                                    int nuevoValor = int.Parse(Console.ReadLine());
                                    if (milista.Change(posModificar, nuevoValor))
                                        Console.WriteLine("Nodo modificado correctamente.");
                                    else
                                        Console.WriteLine("No se pudo modificar el nodo.");
                                    break;

                                case 6:
                                    // Opción para buscar un nodo por su valor.
                                    Console.Write("Dame el valor a buscar: ");
                                    int valorBuscar = int.Parse(Console.ReadLine());
                                    int posicion = milista.FindValue(valorBuscar);
                                    if (posicion != -1)
                                        Console.WriteLine($"El valor {valorBuscar} está en la posición {posicion}.");
                                    else
                                        Console.WriteLine("Valor no encontrado.");
                                    break;

                                case 7:
                                    // Opción para imprimir todos los nodos de la lista.
                                    Console.Write("Contenido de la lista: \n");
                                    milista.print();
                                    break;

                                case 8:
                                    // Opción para salir del programa.
                                    Console.WriteLine("Regresando...");
                                    break;

                                default:
                                    Console.WriteLine("Opción no válida.");
                                    break;
                            }

                            Console.WriteLine("\nPresiona Enter para continuar...");
                            Console.ReadLine(); // Pausa para que el usuario pueda leer el mensaje antes de continuar.

                        } while (selMenu != 8); // El ciclo se repite mientras la opción no sea 8 (salir).

                        break;

                    case 2:
                        /********************* PILAS **********************/

                        pila Pila = new pila();

                        do
                        {
                            Console.Write("\n\tMENU Pilas" +
                            "\n\r---------------------------------" +
                            "\n\t1.- Establecer Tamaño" +
                            "\n\t2.- Push" +
                            "\n\t3.- Pop" +
                            "\n\t4.- Imprimir" +
                            "\n\t5.- Regresar" +
                            "\n\r__________________________________" +
                            "\n\tSelecciónar Opción => ");
                            selMenu = Convert.ToInt32(Console.ReadLine());

                            switch (selMenu)
                            {
                                case 1:
                                    Console.WriteLine("1.- Establece el tamaño de la pila: \n");
                                    int tam = Convert.ToInt32(Console.ReadLine());
                                    Pila.EstablecerTamaño(tam);
                                    break;

                                case 2:
                                    Console.WriteLine("2.- Push. \n");

                                    Console.WriteLine("Incerta un valor: ");
                                    int num = Convert.ToInt32(Console.ReadLine());
                                    Pila.Push(num);
                                    break;

                                case 3:
                                    Console.WriteLine("2.- Pop. \n");
                                    Console.WriteLine($"Valor extraido: {Pila.Pop()}");
                                    break;

                                case 4:
                                    Console.WriteLine("2.- Imprimir. \n");
                                    Pila.PrintStack();
                                    break;

                                case 5:
                                    Console.WriteLine("5.- Regresar\n");
                                    Console.WriteLine("Fin\n");
                                    break;
                                default:
                                    Console.WriteLine("Ingresa un valor correcto.\n");
                                    break;
                            }
                        }
                        while (selMenu != 5);

                        break;

                    case 3:
                        /********************* COLAS ************************/

                        int count = 0;
                        Cola cola = new Cola(count);

                        do
                        {
                            Console.Write("MENU Colas\r\n---------------------------------\r\n1.- Establecer Tamaño\r\n2.- Count\r\n3.- Insert\r\n4.- Extract\r\n5.- Imprimir \r\n6.- Regresar\r\n_____________________\r\nSelecciónar Opción => ");
                            selMenu = Convert.ToInt32(Console.ReadLine());

                            switch (selMenu)
                            {
                                case 1:
                                    ;
                                    Console.WriteLine("Ingresa el tamaño de la pila");
                                    count = Convert.ToInt32(Console.ReadLine());
                                    cola.InsertarTamano(count);

                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 2:
                                    int conteo = cola.Count();
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine($"Los valores insertados en la cola son: {conteo}");
                                    Console.ResetColor();

                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 3:
                                    Console.WriteLine("Inserta el valor de una cola");
                                    int valCola = Convert.ToInt32(Console.ReadLine());
                                    cola.Insert(valCola);

                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 4:
                                    int valExtraido = cola.Extract();

                                    Console.ReadLine();
                                    Console.Clear();
                                break;

                                case 5:
                                    cola.Print();

                                    Console.ReadLine();
                                    Console.Clear();
                                break;

                                case 6:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Regresando...");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                break;

                                default:
                                    Console.WriteLine("El valor que ingresaste no existe en el menu");
                                break;
                            }
                        }
                        while (selMenu != 6);
                    break;

                    case 4:
                        /********************* ARBOLES BINARIOS ************************/
                        arbol arbolito = new arbol();
                        int numInsertado;

                        do
                        {
                            Console.Write("MENÚ ÁRBOLES\r\n---------------------------------------\r\n1.- Insertar nodo\r\n2.- Tamaño\r\n3.- Altura\r\n4.- LRP\r\n5.- Recorrido\r\n6.- Regresar\r\n---------------------------------------\r\nSelecciónar Opción => ");
                            selMenu = Convert.ToInt32(Console.ReadLine());

                            switch (selMenu)
                            {
                                case 1:

                                    Console.WriteLine("Ingresa un nodo");
                                    numInsertado = Convert.ToInt32(Console.ReadLine());

                                    arbolito.Insertar(numInsertado);
                                break;

                                case 2:

                                    Console.WriteLine("Tamaño del árbol:");
                                    int tamaño = arbolito.Tamaño(arbolito.raiz); // Llamamos al método desde la raíz.
                                    Console.WriteLine(tamaño);
                                break;

                                case 3:
                                    int altura = arbolito.CalcularAltura(arbolito.raiz);
                                    Console.WriteLine(altura);
                                break;

                                case 4:

                                    Console.WriteLine("Longitud de Ruta Promedio (LRP):");
                                    double lrp = arbolito.LRP();
                                    Console.WriteLine($"LRP: {lrp}");

                                break;

                                case 5:

                                    arbolito.Recorrido(arbolito.raiz);
                                    Console.WriteLine();

                                break;

                                case 6:

                                    Console.WriteLine("Regresando...");
                                    Console.ReadLine();

                                break;

                                default:

                                    Console.WriteLine("La opcion que usted ingreso no existe, seleccione otro porfavor");

                                break;
                            }
                        }
                        while (6 != selMenu);
                        break;

                    case 5:
                        Console.WriteLine("Saliendo...");
                        Console.ReadLine();
                    break;

                    default:
                        Console.WriteLine("la opcion que usted ingreso no existe, porfavor de ingresar un valor correcto");
                    break;
                }
            }
            while (selMenu != 5);
        }
    }
}