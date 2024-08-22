using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoInteractivo
{
    internal class Historia
    {
        // Variables privadas para manejar la historia, inventario y personaje principal
        private Nodo _raiz; // Nodo raíz de la historia
        private Inventario _inventario; // Referencia al inventario del jugador
        private Personaje _astronauta; // Referencia al personaje principal (astronauta)

        // Método para obtener el nodo raíz de la historia
        public Nodo ObtenerRaiz()
        {
            return _raiz;
        }

        // Constructor de la clase Historia, inicializa el inventario y personaje, y crea la historia
        public Historia(Inventario inventario, Personaje astronauta)
        {
            _inventario = inventario;
            _astronauta = astronauta;
            CrearHistoria(); // Llama al método para crear la historia
        }

        // Método privado para crear la historia interactiva
        private void CrearHistoria()
        {
            // Nodo raíz de la historia: introducción al juego
            _raiz = new Nodo("Eres un astronauta en una misión espacial." +
                "\nTu nave se ha estrellado en una planicie desértica de un planeta desconocido. " +
                "Estás solo, salvo por la IA de la nave. Debes tomar una decisión rápida." +
                "\n1. Inspeccionar los restos de la nave." +
                "\n2. Explorar los alrededores.");

            // Nodo 1: Escenario cuando decides inspeccionar los restos de la nave
            Nodo nodo1 = new Nodo("Te acercas a los restos de la nave. La IA te indica un compartimento de emergencia intacto." +
                "\n1. Abrir el compartimento de emergencia" +
                "\n2. Ignorar la IA y seguir buscando");
            _raiz.OpcionIzquierda = nodo1;

            // Nodo 1.1: Escenario cuando decides abrir el compartimento de emergencia
            Nodo nodo1_1 = new Nodo("Encuentras suministros: tanque de oxígeno, pistola de bengalas y dispositivo de escaneo." +
                "\nVes una señal que guía hasta unas ruinas alienígenas" +
                "\n1. Seguir la señal" +
                "\n2. Permanecer cerca de la nave",
                () =>
                {
                    // Acción asociada a este nodo: agregar objetos al inventario
                    _inventario.AgregarObjeto("*Tanque de oxígeno");
                    _inventario.AgregarObjeto("*Pistola de bengalas");
                    _inventario.AgregarObjeto("*Dispositivo de escaneo");
                });
            nodo1.OpcionIzquierda = nodo1_1;

            // Nodo 1.1.1: Escenario cuando decides seguir la señal hacia las Ruinas Alienígenas
            Nodo nodo1_1_1 = new Nodo("Sigues una señal detectada por la IA hacia las Ruinas Alienígenas." +
                "\n1. Entrar a las ruinas." +
                "\n2. Seguir afuera.");
            nodo1_1.OpcionIzquierda = nodo1_1_1;

            // Nodo 1.1.2: Escenario cuando decides permanecer cerca de la nave
            Nodo nodo1_1_2 = new Nodo("Permaneces cerca de la nave buscando más recursos.", () =>
            {
                // Acción asociada a este nodo: disminuir la salud del astronauta debido al calor
                Console.WriteLine("El calor es abrumador y tu salud disminuye." +
                    "\n1. Continuar." +
                    "\n2. Ir a las ruinas.");
                _astronauta.Salud -= 20;
            });
            nodo1_1.OpcionDerecha = nodo1_1_2;

            // Nodo 1.1.2.1: Escenario cuando decides ir a las ruinas después de permanecer cerca de la nave
            Nodo nodo1_1_2_1 = new Nodo("Llegaste a la entrada de las ruinas." +
                "\n1. Entrar a las ruinas." +
                "\n2. Seguir afuera.");
            nodo1_1_2.OpcionDerecha = nodo1_1_2_1;

            // Nodo 1.2: Escenario cuando decides ignorar la IA y continuar buscando
            Nodo nodo1_2 = new Nodo("Decides ignorar la sugerencia de la IA y continúas buscando " +
                "en otros lugares de la nave. " +
                "Sin embargo, el calor y la falta de recursos te hacen desmayarte. Cuando despiertas, " +
                "la IA ha tomado decisiones automáticas para preservar tu vida." +
                "\n1. Salir a explorar." +
                "\n2. Seguir en la nave.");
            nodo1.OpcionDerecha = nodo1_2;

            // Nodo 1.2.1: Escenario cuando decides explorar la cueva cercana
            Nodo nodo1_2_1 = new Nodo("La IA ha detectado una cueva cercana." +
                "\n1. Entrar." +
                "\n2. Quedarse afuera.");
            nodo1_2.OpcionIzquierda = nodo1_2_1;

            // Nodo 1.2.1.1: Escenario cuando decides tomar el cristal alienígena dentro de la cueva
            Nodo nodo1_2_1_1 = new Nodo("Al entrar encuentras un cristal alienígena." +
                "\n1. Tomarlo." +
                "\n2. Salir de la cueva.",
                () =>
                {
                    // Acción asociada a este nodo: agregar el cristal al inventario
                    _inventario.AgregarObjeto("Cristal alienígena");
                });
            nodo1_2_1.OpcionIzquierda = nodo1_2_1_1;

            // Nodo 1.2.2: Escenario cuando decides intentar reparar la nave
            Nodo nodo1_2_2 = new Nodo("Intentas reparar la nave con las piezas que has encontrado, " +
                "pero el daño es demasiado grande. Finalmente, la IA deja de funcionar y quedas solo.");
            nodo1_2.OpcionDerecha = nodo1_2_2;

            // Nodo 2: Escenario cuando decides explorar los alrededores en busca de refugio
            Nodo nodo2 = new Nodo("Te alejas de la nave y encuentras una cueva que podría ofrecer refugio." +
                "\n1. Entrar a la cueva." +
                "\n2. Ignorar la cueva y seguir explorando.");
            _raiz.OpcionDerecha = nodo2;

            // Nodo 2.1: Escenario cuando decides entrar en la cueva
            Nodo nodo2_1 = new Nodo("Dentro de la cueva encuentras cristales brillantes. " +
                "La IA detecta fluctuaciones de energía." +
                "\n1. Explorar la cueva más a fondo." +
                "\n2. Salir de la cueva.");
            nodo2.OpcionIzquierda = nodo2_1;

            // Nodo 2.1.1: Escenario cuando decides explorar la cueva más a fondo
            Nodo nodo2_1_1 = new Nodo("Decides explorar más a fondo y te enfrentas a una criatura alienígena.", () =>
            {
                // Acción asociada a este nodo: iniciar un combate con la criatura
                bool resultadoCombate = Combate.IniciarCombate(_astronauta, 50);
                if (resultadoCombate)
                {
                    // Si el combate es exitoso, agrega artefactos alienígenas al inventario
                    Console.WriteLine("Has derrotado a la criatura y encuentras dos artefactos alienígenas." +
                        "\n1. Usar artefacto 1." +
                        "\n2. Usar artefacto 2.");
                    _inventario.AgregarObjeto("Artefacto alienígena");
                }
                else
                {
                    // Si pierdes el combate, termina la historia
                    Console.WriteLine("La criatura te ha derrotado. Fin de la historia.");
                }
            });
            nodo2_1.OpcionIzquierda = nodo2_1_1;

            // Nodo 2.2: Escenario cuando decides ignorar la cueva y seguir explorando
            Nodo nodo2_2 = new Nodo("Decides ignorar la cueva y seguir explorando la planicie. " +
                "El terreno se vuelve más difícil y los recursos se agotan rápidamente. " +
             "\nDe repente, encuentras una estructura alienígena en la distancia." +
             "\n1. Acercarte a la estructura alienígena" +
             "\n2. Regresar a la nave para buscar más suministros");
            _raiz.OpcionDerecha.OpcionDerecha = nodo2_2;

            // Nodo 2.2.1: Interacción con la estructura alienígena (clave de 4 dígitos)
            Nodo nodo2_2_1 = new Nodo("Te acercas a la estructura alienígena. " +
                "La IA detecta un mecanismo de entrada que requiere una clave de 4 dígitos.");

            // Acción asociada a este nodo: manejo de la clave de 4 dígitos
            nodo2_2_1.Accion = () =>
            {
                Console.WriteLine("Introduce la clave de 4 dígitos:");
                string clave = Console.ReadLine();

                // Clave correcta es 1234
                if (clave == "1234")
                {
                    // Si la clave es correcta, avanzas a un nuevo escenario
                    Console.WriteLine("¡Clave correcta! La puerta se abre, revelando un complejo subterráneo lleno de tecnología avanzada.");
                    _inventario.AgregarObjeto("Acceso al complejo subterráneo alienígena");
                }
                else
                {
                    // Si la clave es incorrecta, sufres una penalización
                    Console.WriteLine("Clave incorrecta. Una descarga eléctrica te golpea.");
                    _astronauta.Salud -= 10;
                }
            };
            nodo2_2.OpcionIzquierda = nodo2_2_1;
        }
    }
}