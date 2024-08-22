using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoInteractivo
{
    internal class Juego
    {
        // Campos privados que representan los componentes principales del juego.
        private Historia _historia;
        private Inventario _inventario;
        private Personaje _astronauta;
        private int ContadorMovimientos;
        private bool Error;

        // Método que inicializa los componentes del juego.
        public void IniciarComponentes()
        {
            _inventario = new Inventario();
            _astronauta = new Personaje();
            _historia = new Historia(_inventario, _astronauta);
            ContadorMovimientos = 0;
            Error = true;
        }

        // Constructor del juego que llama a la inicialización de componentes.
        public Juego()
        {
            IniciarComponentes();
        }

        // Método principal que controla el flujo del juego.
        public void Iniciar()
        {
            bool jugarDeNuevo;
            do
            {
                Nodo actual = _historia.ObtenerRaiz();
                jugarDeNuevo = false;

                while (actual != null && _astronauta.Salud > 0)
                {
                    Console.WriteLine(actual.Descripcion); // Muestra la descripción del nodo actual.
                    actual.Accion?.Invoke(); // Ejecuta la acción del nodo, si existe.

                    // Verifica si el jugador ha perdido toda la salud.
                    if (_astronauta.Salud <= 0)
                    {
                        Console.WriteLine("Tu salud se ha agotado. Fin de la historia.");
                        break;
                    }

                    // Verifica si es el final de la historia.
                    if (actual.OpcionIzquierda == null && actual.OpcionDerecha == null)
                    {
                        Console.WriteLine("Fin de la historia.");
                        break;
                    }

                    // Muestra el contador de movimientos y pide al jugador que elija una opción.
                    Console.WriteLine($"Contador de movimientos: {ContadorMovimientos}");
                    Console.Write("Elige una opción: ");
                    string opcion = Console.ReadLine();

                    // Lógica para cambiar al siguiente nodo según la opción elegida.
                    if (opcion == "1")
                    {
                        actual = actual.OpcionIzquierda;
                        ContadorMovimientos++;
                        Console.Clear();
                    }
                    else if (opcion == "2")
                    {
                        actual = actual.OpcionDerecha;
                        ContadorMovimientos++;
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    }

                    Console.WriteLine();
                }

                // Bucle que maneja la opción de jugar de nuevo.
                do
                {
                    Console.WriteLine("¿Deseas jugar de nuevo? (S/N)");
                    string respuesta = Console.ReadLine().ToUpper();
                    if (respuesta == "S")
                    {
                        IniciarComponentes();
                        jugarDeNuevo = true;
                        Console.Clear();
                    }
                    else if (respuesta == "N")
                    {
                        IniciarComponentes();
                        jugarDeNuevo = false;
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        Error = false;
                    }
                } while (Error == false);

            } while (jugarDeNuevo);
        }
    }
}