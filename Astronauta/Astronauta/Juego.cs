using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronauta
{
    internal class Juego
    {
        private Historia _historia;
        private Inventario _inventario;
        private Personaje _astronauta;
        private Nodo _nodoActual;

        public Juego()
        {
            _inventario = new Inventario();
            _astronauta = new Personaje();
            _historia = new Historia(_inventario, _astronauta);
            _nodoActual = _historia.ObtenerRaiz(); // Inicializar el nodo actual
        }

        public Inventario ObtenerInventario()
        {
            return _inventario;
        }

        public int ObtenerSalud()
        {
            return _astronauta.Salud;
        }

        public Nodo ObtenerNodoActual()
        {
            return _nodoActual;
        }

        public void EstablecerNodoActual(Nodo nodo)
        {
            _nodoActual = nodo;
        }

        public void Iniciar()
        {
            Nodo actual = _historia.ObtenerRaiz();
            _nodoActual = actual;  // Inicializar el nodo actual al comienzo

            while (actual != null && _astronauta.Salud > 0)
            {
                Console.WriteLine(actual.Descripcion);
                actual.Accion?.Invoke();

                if (_astronauta.Salud <= 0)
                {
                    Console.WriteLine("Tu salud se ha agotado. Fin de la historia.");
                    break;
                }

                if (actual.OpcionIzquierda == null && actual.OpcionDerecha == null)
                {
                    Console.WriteLine("Fin de la historia.");
                    break;
                }

                Console.WriteLine("Opción 1");
                Console.WriteLine("Opción 2");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    actual = actual.OpcionIzquierda;
                }
                else if (opcion == "2")
                {
                    actual = actual.OpcionDerecha;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                }

                Console.WriteLine();
            }
        }
    }
}
