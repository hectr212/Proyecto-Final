using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronauta
{
    public partial class Form1 : Form
    {
        private Juego _juego;
        private Nodo _nodoActual;

        public Form1()
        {
            InitializeComponent();
            _juego = new Juego();
            _nodoActual = _juego.ObtenerNodoActual();

            ActualizarUI();
        }

        private void textBoxClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerificarClave();
                e.SuppressKeyPress = true; // Evita el sonido de "ding" al presionar Enter
            }
        }
        private void VerificarClave()
        {
            string claveIngresada = txtClave.Text;

            // Verificar si estamos en el nodo2_2_1
            if (_nodoActual.Descripcion.Contains("Te acercas a la estructura alienígena"))
            {
                if (claveIngresada == "1234")
                {
                    MessageBox.Show("¡Clave correcta! La puerta se abre.");
                    _nodoActual = _nodoActual.OpcionIzquierda; // Continuar en la historia
                }
                else
                {
                    MessageBox.Show("Clave incorrecta. Se activa un mecanismo de defensa.");
                    _nodoActual = _nodoActual.OpcionDerecha; // Continuar en la historia hacia un mal final
                }

                // Limpia el TextBox para que esté listo para la próxima entrada
                txtClave.Clear();
                ActualizarHistoria();
            }
            else
            {
                MessageBox.Show("No estás en el nodo correcto para ingresar una clave.");
            }
        }
        private void ActualizarUI()
        {
            // Actualizar la descripción del nodo actual
            lblDescripcion.Text = _nodoActual.Descripcion;

            // Actualizar las opciones de botones
            if (_nodoActual.OpcionIzquierda != null)
            {
                btnOpcion1.Text = "Opción 1";
                btnOpcion1.Enabled = true;
            }
            else
            {
                btnOpcion1.Enabled = false;
            }

            if (_nodoActual.OpcionDerecha != null)
            {
                btnOpcion2.Text = "Opción 2";
                btnOpcion2.Enabled = true;
            }
            else
            {
                btnOpcion2.Enabled = false;
            }

            // Actualizar la salud del astronauta
            lblSaludAstronauta.Text = $"Salud: {_juego.ObtenerSalud()}";

            // Mostrar el inventario
            lstInventario.Items.Clear();
            //foreach (var item in _juego.ObtenerInventario())
            //{
            //    lstInventario.Items.Add(item);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            _nodoActual = _nodoActual.OpcionIzquierda;
            _nodoActual.Accion?.Invoke(); // Ejecutar la acción si existe
            ActualizarUI();
        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            _nodoActual = _nodoActual.OpcionDerecha;
            _nodoActual.Accion?.Invoke(); // Ejecutar la acción si existe
            ActualizarUI();
        }

        private void btnEnviarClave_Click(object sender, EventArgs e)
        {
            VerificarClave();
        }
        private void ActualizarHistoria()
        {
            lblDescripcion.Text = _nodoActual.Descripcion;
        }

        private void btnDefender_Click(object sender, EventArgs e)
        {

        }
    }
}
