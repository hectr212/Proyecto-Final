using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoInteractivo
{
    internal class Historia
    {
        private Nodo _raiz;
        private Inventario _inventario;
        private Personaje _astronauta;

        public Nodo ObtenerRaiz()
        {
            return _raiz;
        }

        public Historia(Inventario inventario, Personaje astronauta)
        {
            _inventario = inventario;
            _astronauta = astronauta;
            CrearHistoria();
        }

        private void CrearHistoria()
        {
            _raiz = new Nodo("Eres un astronauta en una misión espacial." +
                "\nTu nave se ha estrellado en una planicie desértica de un planeta desconocido. Estás solo, salvo por la IA de la nave. Debes tomar una decisión rápida." +
                "\n1. Inspeccionar los restos de la nave." +
                "\n2. Explorar los alrededores.");

            // Nodo 1: Inspeccionar los restos de la nave
            Nodo nodo1 = new Nodo("Te acercas a los restos de la nave. La IA te indica un compartimento de emergencia intacto." +
                "\n1. Abrir el compartimento de emergencia" +
                "\n2. Ignorar la IA y seguir buscando");
            _raiz.OpcionIzquierda = nodo1;

            // Nodo 1.1: Abrir el compartimento de emergencia
            Nodo nodo1_1 = new Nodo("Encuentras suministros: tanque de oxígeno, pistola de bengalas y dispositivo de escaneo." +
                "\nVes una señal que guía hasta unas ruinas alienígenas" +
                "\n1. Seguir la señal" +
                "\n2. Permanecer cerca de la nave",
                () =>
                {
                    _inventario.AgregarObjeto("*Tanque de oxígeno");
                    _inventario.AgregarObjeto("*Pistola de bengalas");
                    _inventario.AgregarObjeto("*Dispositivo de escaneo");
                });
            nodo1.OpcionIzquierda = nodo1_1;

            // Nodo 1.1.1: Seguir la señal hacia las Ruinas Alienígenas
            Nodo nodo1_1_1 = new Nodo("Sigues una señal detectada por la IA hacia las Ruinas Alienígenas." +
                "\n1. Entrar a las ruinas." +
                "\n2. Seguir afuera.");
            nodo1_1.OpcionIzquierda = nodo1_1_1;

            // Nodo 1.1.2: Permanecer cerca de la nave
            Nodo nodo1_1_2 = new Nodo("Permaneces cerca de la nave buscando más recursos.", () =>
            {
                Console.WriteLine("El calor es abrumador y tu salud disminuye." +
                    "\n1. Continuar." +
                    "\n2. Ir a las ruinas.");
                _astronauta.Salud -= 20;
            });
            nodo1_1.OpcionDerecha = nodo1_1_2;

            Nodo nodo1_1_2_1 = new Nodo("Llegaste a la entrada de las ruinas." +
                "\n1. Entrar a las ruinas." +
                "\n2. Seguir afuera.");
            nodo1_1_2.OpcionDerecha = nodo1_1_2_1;

            // Nodo 1.2: Ignorar la IA y continuar buscando
            Nodo nodo1_2 = new Nodo("Decides ignorar la sugerencia de la IA y continúas buscando en otros lugares de la nave. " +
                "Sin embargo, el calor y la falta de recursos te hacen desmayarte. Cuando despiertas, la IA ha tomado decisiones automáticas para preservar tu vida." +
                "\n1. Salir a explorar." +
                "\n2. Seguir en la nave.");
            nodo1.OpcionDerecha = nodo1_2;

            // Nodo 1.2.1: Explorar la cueva cercana
            Nodo nodo1_2_1 = new Nodo("La IA ha detectado una cueva cercana." +
                "\n1. Entrar." +
                "\n2. Quedarse afuera.");
            nodo1_2.OpcionIzquierda = nodo1_2_1;

            Nodo nodo1_2_1_1 = new Nodo("Al entrar encuentras un cristal alienígena." +
                "\n1. Tomarlo." +
                "\n2. Salir de la cueva.",
                () =>
                {
                    _inventario.AgregarObjeto("Cristal alienígena");
                });
            nodo1_2_1.OpcionIzquierda = nodo1_2_1_1;

            // Nodo 1.2.2: Intentar reparar la nave
            Nodo nodo1_2_2 = new Nodo("Intentas reparar la nave con las piezas que has encontrado, pero el daño es demasiado grande. Finalmente, la IA deja de funcionar y quedas solo.");
            nodo1_2.OpcionDerecha = nodo1_2_2;

            // Nodo 2: Explorar los alrededores en busca de refugio
            Nodo nodo2 = new Nodo("Te alejas de la nave y encuentras una cueva que podría ofrecer refugio." +
                "\n1. Entrar a la cueva." +
                "\n2. Ignorar la cueva y seguir explorando.");
            _raiz.OpcionDerecha = nodo2;

            // Nodo 2.1: Entrar en la cueva
            Nodo nodo2_1 = new Nodo("Dentro de la cueva encuentras cristales brillantes. La IA detecta fluctuaciones de energía." +
                "\n1. Explorar la cueva más a fondo." +
                "\n2. Salir de la cueva.");
            nodo2.OpcionIzquierda = nodo2_1;

            // Nodo 2.1.1: Explorar la cueva más a fondo
            Nodo nodo2_1_1 = new Nodo("Decides explorar más a fondo y te enfrentas a una criatura alienígena.", () =>
            {
                bool resultadoCombate = Combate.IniciarCombate(_astronauta, 50);
                if (resultadoCombate)
                {
                    Console.WriteLine("Has derrotado a la criatura y encuentras dos artefactos alienígenas." +
                        "\n1. Usar artefacto 1." +
                        "\n2. Usar artefacto 2.");
                    _inventario.AgregarObjeto("Artefacto alienígena");
                }
                else
                {
                    Console.WriteLine("La criatura te ha derrotado. Fin de la historia.");
                }
            });
            nodo2_1.OpcionIzquierda = nodo2_1_1;

            // Nodo 2.2: Ignorar la cueva y seguir explorando
            Nodo nodo2_2 = new Nodo("Decides ignorar la cueva y seguir explorando la planicie. El terreno se vuelve más difícil y los recursos se agotan rápidamente. " +
             "\nDe repente, encuentras una estructura alienígena en la distancia." +
             "\n1. Acercarte a la estructura alienígena" +
             "\n2. Regresar a la nave para buscar más suministros");
            _raiz.OpcionDerecha.OpcionDerecha = nodo2_2;

            // Nodo 2.2.1: Interacción con la estructura alienígena (clave de 4 dígitos)
            Nodo nodo2_2_1 = new Nodo("Te acercas a la estructura alienígena. La IA detecta un mecanismo de entrada que requiere una clave de 4 dígitos.");

            // Manejo de la clave de 4 dígitos
            nodo2_2_1.Accion = () =>
            {
                Console.WriteLine("Introduce la clave de 4 dígitos:");
                string clave = Console.ReadLine();

                // Clave correcta es 1234
                if (clave == "1234")
                {
                    Console.WriteLine("La clave es correcta. La puerta se abre y entras en la estructura donde encuentras una nave espacial intacta, la cual usas para escapar. ¡Has sobrevivido!");
                    nodo2_2_1.OpcionIzquierda = null; // Terminar la historia
                    nodo2_2_1.OpcionDerecha = null;
                }
                else
                {
                    Console.WriteLine("Clave incorrecta. Se activa un mecanismo de defensa." +
                        "\n1. Pulsar botón 1." +
                        "\n2. Pulsar botón 2.");
                    // Redirigir al final malo
                    Nodo finalMalo = new Nodo("Un campo de energía se activa y te desintegra.");
                    Nodo finalBueno1 = new Nodo("Se desactiva el mecanismo de defensa. La puerta se abre y entras en la estructura donde encuentras una nave espacial intacta, la cual usas para escapar. ¡Has sobrevivido!");
                    nodo2_2_1.OpcionIzquierda = finalMalo;
                    nodo2_2_1.OpcionDerecha = finalBueno1;
                }
            };

            nodo2_2.OpcionIzquierda = nodo2_2_1;

            // Nodo 2.2.2: Regresar a la nave para buscar más suministros
            Nodo nodo2_2_2 = new Nodo("Decides regresar a la nave para buscar más suministros, pero cuando llegas ya no está...");
            nodo2_2.OpcionDerecha = nodo2_2_2;

            // Finales posibles
            Nodo finalBueno = new Nodo("Has encontrado el artefacto alienígena correcto y logras contactar con una estación espacial cercana. Eres rescatado.");
            nodo1_1_1.OpcionIzquierda = finalBueno;
            nodo2_1_1.OpcionIzquierda = finalBueno;
            nodo1_1_2_1.OpcionIzquierda = finalBueno;

            Nodo finalAlternativo = new Nodo("El artefacto alienígena que has elegido es en realidad una trampa. Mueres a causa de la radiación que este transmite.");
            nodo2_1_1.OpcionDerecha = finalAlternativo;

            Nodo finalAlternativo2 = new Nodo("Encuentras un cristal alienígena que resulta ser una máquina que te permite teletransportarte. Logras llegar a salvo a la tierra.");
            nodo1_2_1.OpcionIzquierda = finalAlternativo2;
            nodo2_1.OpcionDerecha = finalAlternativo2;

            Nodo finalMalo2 = new Nodo("El ambiente hostil y la falta de recursos acaban con tu vida.");
            nodo2_2_1.OpcionIzquierda = finalMalo2;
            nodo1_1_2.OpcionIzquierda = finalMalo2;
            nodo1_1_1.OpcionDerecha = finalMalo2;
            nodo1_2_1.OpcionDerecha = finalMalo2;
            nodo1_1_2_1.OpcionDerecha = finalMalo2;
            // Finales posibles adicionales
        }

        public void ComenzarHistoria()
        {
            Nodo nodoActual = _raiz;

            while (nodoActual != null)
            {
                Console.WriteLine(nodoActual.Descripcion);

                if (nodoActual.Accion != null)
                {
                    nodoActual.Accion();
                }

                if (nodoActual.OpcionIzquierda == null && nodoActual.OpcionDerecha == null)
                {
                    Console.WriteLine("Fin de la historia.");
                    break;
                }

                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1. " + (nodoActual.OpcionIzquierda?.Descripcion != null ? nodoActual.OpcionIzquierda.Descripcion.Substring(0, 30) + "..." : ""));
                Console.WriteLine("2. " + (nodoActual.OpcionDerecha?.Descripcion != null ? nodoActual.OpcionDerecha.Descripcion.Substring(0, 30) + "..." : ""));

                string opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    nodoActual = nodoActual.OpcionIzquierda;
                }
                else if (opcion == "2")
                {
                    nodoActual = nodoActual.OpcionDerecha;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, elige 1 o 2.");
                }
            }
        }
    }
}