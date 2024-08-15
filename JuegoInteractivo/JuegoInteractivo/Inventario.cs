using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoInteractivo
{
    internal class Inventario
    {
        private List<string> objetos;

        public Inventario()
        {
            objetos = new List<string>();
        }

        public void AgregarObjeto(string objeto)
        {
            objetos.Add(objeto);
            Console.WriteLine($"{objeto} ha sido añadido al inventario.");
        }

        public bool TieneObjeto(string objeto)
        {
            return objetos.Contains(objeto);
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario:");
            foreach (var item in objetos)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
