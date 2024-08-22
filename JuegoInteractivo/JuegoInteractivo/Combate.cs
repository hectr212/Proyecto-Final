using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoInteractivo
{
    internal class Combate // Este es el sistema de combate
    {
        // Método estático que inicia un combate entre el astronauta y un enemigo
        public static bool IniciarCombate(Personaje astronauta, int vidaEnemigo)
        {
            Random random = new Random(); // Generador de números aleatorios para manejar la aleatoriedad en el combate

            // Bucle que continúa el combate hasta que uno de los dos pierde toda su salud
            while (astronauta.Salud > 0 && vidaEnemigo > 0)
            {
                // Mostrar la salud actual del astronauta y del enemigo
                Console.WriteLine("Tu salud: " + astronauta.Salud);
                Console.WriteLine("Salud del enemigo: " + vidaEnemigo);

                // Presentar las opciones de combate al jugador
                Console.WriteLine("Elige tu acción:");
                Console.WriteLine("1. Ataque fuerte (50% de acierto, daño alto)");
                Console.WriteLine("2. Ataque rápido (80% de acierto, daño moderado)");
                Console.WriteLine("3. Defender (reduce el daño del próximo ataque)");
                string opcion = Console.ReadLine();

                // Indica si es el turno del astronauta para atacar
                bool esTurnoAstronauta = true;

                // Manejar la opción elegida por el jugador
                switch (opcion)
                {
                    case "1": // Ataque fuerte
                        if (random.Next(0, 100) < 50) // 50% de probabilidad de acierto
                        {
                            int dano = random.Next(20, 40); // Daño aleatorio entre 20 y 40
                            vidaEnemigo -= dano; // Reducir la salud del enemigo
                            Console.WriteLine($"¡Ataque fuerte exitoso! Infligiste {dano} de daño.");
                        }
                        else
                        {
                            Console.WriteLine("¡Fallaste el ataque fuerte!");
                        }
                        break;

                    case "2": // Ataque rápido
                        if (random.Next(0, 100) < 80) // 80% de probabilidad de acierto
                        {
                            int dano = random.Next(10, 25); // Daño aleatorio entre 10 y 25
                            vidaEnemigo -= dano; // Reducir la salud del enemigo
                            Console.WriteLine($"¡Ataque rápido exitoso! Infligiste {dano} de daño.");
                        }
                        else
                        {
                            Console.WriteLine("¡Fallaste el ataque rápido!");
                        }
                        break;

                    case "3": // Defender
                        Console.WriteLine("Te pones en posición defensiva, reduciendo el daño del próximo ataque enemigo.");
                        esTurnoAstronauta = false; // Cambia a turno del enemigo
                        break;

                    default: // Si la opción ingresada es inválida
                        Console.WriteLine("Opción inválida. Pierdes tu turno.");
                        esTurnoAstronauta = false; // Cambia a turno del enemigo
                        break;
                }

                // Turno del enemigo para atacar si aún tiene salud y no fue el turno del astronauta
                if (vidaEnemigo > 0 && !esTurnoAstronauta)
                {
                    int ataqueEnemigo = random.Next(10, 30); // Daño aleatorio entre 10 y 30

                    // Si el jugador eligió defender, el daño se reduce a la mitad
                    if (opcion == "3")
                    {
                        ataqueEnemigo /= 2;
                    }

                    // Reducir la salud del astronauta
                    astronauta.Salud -= ataqueEnemigo;
                    Console.WriteLine($"El enemigo te ataca y te inflige {ataqueEnemigo} de daño.");
                }
            }

            // Verificar quién ganó el combate
            if (astronauta.Salud > 0)
            {
                Console.WriteLine("¡Has derrotado al enemigo!");
                return true; // El astronauta ganó
            }
            else
            {
                Console.WriteLine("¡Has sido derrotado!");
                return false; // El enemigo ganó
            }
        }
    }
}
