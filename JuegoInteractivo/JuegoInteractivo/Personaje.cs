using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoInteractivo
{
    internal class Personaje
    {
        // Propiedad pública para manejar la salud del personaje
        public int Salud { get; set; }

        // Constructor por defecto que inicializa la salud a 100
        public Personaje()
        {
            Salud = 100;
        }

        // Método que verifica si el personaje está vivo (si la salud es mayor que 0)
        public bool EstaVivo()
        {
            return Salud > 0;
        }
    }
}
