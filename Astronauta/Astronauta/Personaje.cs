using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronauta
{
    internal class Personaje
    {
        public int Salud { get; set; }

        public Personaje()
        {
            Salud = 100;
        }

        public bool EstaVivo()
        {
            return Salud > 0;
        }
    }
}
