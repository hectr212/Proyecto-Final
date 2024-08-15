using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoInteractivo
{
    internal class Nodo
    {
        public string Descripcion { get; set; }
        public Nodo OpcionIzquierda { get; set; }
        public Nodo OpcionDerecha { get; set; }
        public Action Accion { get; set; }

        public Nodo(string descripcion, Action accion = null)
        {
            Descripcion = descripcion;
            Accion = accion;
            OpcionIzquierda = null;
            OpcionDerecha = null;
        }
    }
}
