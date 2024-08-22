using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoInteractivo
{
    internal class Inventario
    {
        private List<string> objetos; // Lista privada para almacenar los objetos del inventario

        public Inventario()
        {
            objetos = new List<string>(); // Inicializa la lista de objetos cuando se crea un nuevo inventario
        }

        // Método para agregar un objeto al inventario
        public void AgregarObjeto(string objeto)
        {
            objetos.Add(objeto); // Añade el objeto a la lista
            Console.WriteLine($"{objeto} ha sido añadido al inventario."); // Confirma al usuario que el objeto ha sido añadido
        }

        // Método para verificar si un objeto específico está en el inventario
        public bool TieneObjeto(string objeto)
        {
            return objetos.Contains(objeto); // Devuelve true si el objeto está en la lista, false si no lo está
        }

        // Método para mostrar todos los objetos en el inventario
        public void MostrarInventario()
        {
            Console.WriteLine("Inventario:");
            foreach (var item in objetos) // Recorre cada objeto en la lista y lo muestra en la consola
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}