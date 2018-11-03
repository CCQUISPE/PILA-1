using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PILA_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Stack miPila = new Stack();
            int opcion;//opcion del menu 
            do
            {
                Console.Clear();//se limpia consola
                opcion = menu();//muestra menu y espera opción
                switch (opcion)
                {
                    case 1:
                        agregar(ref miPila);
                        break;
                    case 2:
                        eliminar(ref miPila);
                        break;
                    case 3:
                        limpiar(ref miPila);
                        break;
                    case 4:
                        imprimir(miPila);
                        break;
                    case 5: break; //salir
                    default:
                        Console.WriteLine("ERROR: la opción no es valida. Intente de nuevo.");
                        break;
                }
            }
            while (opcion != 5);
            Console.WriteLine("El programa a finalizado.");
            Console.ReadKey();
        }
        /** añade un nuevo elemento a la pila */
        static void agregar(ref Stack pila)
        {
            Console.Write("\n Ingrese valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            if (valor > 99 || valor < 0)
            {
                Console.WriteLine("Solo números del 1 al 99");
            }
            else
            {
                pila.Push(valor);
                imprimir(pila);
            }

        }
        /** Elimina todo los elementos de la pila */
        static void limpiar(ref Stack pila)
        {
            pila.Clear();
            imprimir(pila);
        }
        /** Elimina elemento de la pila */
        static void eliminar(ref Stack pila)
        {

            if (pila.Count > 0)
            {
                int valor = (int)pila.Pop();
                Console.WriteLine("Elemento " + valor + " eliminado");
            }
            else if (pila.Count == 0)
            {
                Console.WriteLine("La pila no posees elementos");

                ///imprimir(pila);
            }
        }
        /** muestra menu y retorna opción */
        static int menu()
        {
            //Console.Clear();
            Console.WriteLine("\n            Stack Menu\n");
            Console.WriteLine(" 1.- Agregar elemento");
            Console.WriteLine(" 2.- Eliminar elemento");
            Console.WriteLine(" 3.- Vaciar Pila");
            Console.WriteLine(" 4.- Ver pila");
            Console.WriteLine(" 5.- Termina programa");
            Console.Write(" Ingresa tu opción: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                return 0;
            }
        }

        /** Muestra mensaje del programa al usuario */
        static void mensaje(String texto)
        {
            if (texto.Length == 0)
            {
                Console.WriteLine("\n =======================================================");
                Console.WriteLine("\n {0}", texto);
                Console.WriteLine(" =======================================================");
                Console.WriteLine("\n Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        /** Imprime pila */
        static void imprimir(Stack pila)
        {
            if (pila.Count != 0)
            {
                Console.WriteLine("");
                foreach (int dato in pila)
                {
                    Console.WriteLine("|     |");
                    if (dato < 10)
                        Console.WriteLine("|  {0}  |", dato);
                    else
                        Console.WriteLine("|  {0}  |", dato);
                    Console.WriteLine("|_____|");
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar ...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La Pila esta vacia");
            }
        }
    }
}
