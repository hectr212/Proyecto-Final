using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoInteractivo
{
    internal class Nodo
    {
        // Propiedad que almacena la descripción del nodo, es decir, el texto que verá el jugador.
        public string Descripcion { get; set; }

        // Propiedad que representa la opción izquierda en el árbol de decisiones. Es un enlace a otro nodo.
        public Nodo OpcionIzquierda { get; set; }

        // Propiedad que representa la opción derecha en el árbol de decisiones. Es un enlace a otro nodo.
        public Nodo OpcionDerecha { get; set; }

        // Propiedad que almacena una acción opcional que se ejecutará cuando el jugador llegue a este nodo.
        public Action Accion { get; set; }

        // Constructor que inicializa un nodo con una descripción y opcionalmente una acción a ejecutar.
        public Nodo(string descripcion, Action accion = null)
        {
            Descripcion = descripcion; // Establece la descripción del nodo.
            Accion = accion; // Asigna la acción (si existe) a ejecutar en este nodo.
            OpcionIzquierda = null; // Inicialmente, no hay nodos enlazados a la izquierda.
            OpcionDerecha = null; // Inicialmente, no hay nodos enlazados a la derecha.
        }
    }
}
