using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronauta
{
    internal class Combate
    {
        public static bool IniciarCombate(Personaje astronauta, int vidaEnemigo)
        {
            Random random = new Random();
            while (astronauta.Salud > 0 && vidaEnemigo > 0)
            {
                Console.WriteLine("Tu salud: " + astronauta.Salud);
                Console.WriteLine("Salud del enemigo: " + vidaEnemigo);
                Console.WriteLine("Elige tu acción:");
                Console.WriteLine("1. Ataque fuerte (50% de acierto, daño alto)");
                Console.WriteLine("2. Ataque rápido (80% de acierto, daño moderado)");
                Console.WriteLine("3. Defender (reduce el daño del próximo ataque)");
                string opcion = Console.ReadLine();

                bool esTurnoAstronauta = true;

                switch (opcion)
                {
                    case "1":
                        if (random.Next(0, 100) < 50)
                        {
                            int dano = random.Next(20, 40);
                            vidaEnemigo -= dano;
                            Console.WriteLine($"¡Ataque fuerte exitoso! Infligiste {dano} de daño.");
                        }
                        else
                        {
                            Console.WriteLine("¡Fallaste el ataque fuerte!");
                        }
                        break;

                    case "2":
                        if (random.Next(0, 100) < 80)
                        {
                            int dano = random.Next(10, 25);
                            vidaEnemigo -= dano;
                            Console.WriteLine($"¡Ataque rápido exitoso! Infligiste {dano} de daño.");
                        }
                        else
                        {
                            Console.WriteLine("¡Fallaste el ataque rápido!");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Te pones en posición defensiva, reduciendo el daño del próximo ataque enemigo.");
                        esTurnoAstronauta = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Pierdes tu turno.");
                        esTurnoAstronauta = false;
                        break;
                }

                // Turno del enemigo
                if (vidaEnemigo > 0 && !esTurnoAstronauta)
                {
                    int ataqueEnemigo = random.Next(10, 30);
                    if (opcion == "3")  // Si el jugador defendió
                    {
                        ataqueEnemigo /= 2;
                    }

                    astronauta.Salud -= ataqueEnemigo;
                    Console.WriteLine($"El enemigo te ataca y te inflige {ataqueEnemigo} de daño.");
                }
            }

            if (astronauta.Salud > 0)
            {
                Console.WriteLine("¡Has derrotado al enemigo!");
                return true;
            }
            else
            {
                Console.WriteLine("¡Has sido derrotado!");
                return false;
            }
        }
    }
}
