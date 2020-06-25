using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_VISTAS;
using MVC_MODELO;

namespace MVC_CONTROLADOR
{
    class Controlador_Circulo
    {
        Vista_Circulo Vista_Circulo;

        public Controlador_Circulo(Vista_Circulo Vista_Circulo)
        {
            this.Vista_Circulo = Vista_Circulo;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public void Eventos()
        {
            Vista_Circulo.MouseDown += Vista_MouseDown;
            Vista_Circulo.pnlImagen.MouseDown += Vista_MouseDown;
            Vista_Circulo.btnCerrar.Click += Cerrar_Click;
            Vista_Circulo.txtRadio.KeyPress += Lado_KeyPress;
            Vista_Circulo.cmbOperacion.Click += Combo_Click;
            Vista_Circulo.cmbOperacion.SelectedIndexChanged += Combo_Seleccion;
            Vista_Circulo.btnLimpiar.Click += Limpiar_Click;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control objeto in Vista_Circulo.Controls)
                if (objeto is TextBox) ((TextBox)objeto).Clear();

            Vista_Circulo.txtRadio.Clear();
            Vista_Circulo.cmbOperacion.Text = "Elije opcion:";
        }

        private void Combo_Seleccion(object sender, EventArgs e)
        {
            double[] Datos = { double.Parse(Vista_Circulo.txtRadio.Text),3.1416 };
            IFiguras Cuadrado = Construye_Figuras.Instanciar(2, Datos);
            int opc = Vista_Circulo.cmbOperacion.SelectedIndex;
            switch (opc)
            {
                case 0:
                    Vista_Circulo.txtArea.Text = Cuadrado.Area();
                    break;
                case 1:
                    Vista_Circulo.txtPerimetro.Text = Cuadrado.Perimetro();
                    break;
                case 2:
                    Vista_Circulo.txtDescripcion.Text = Cuadrado.Descripcion();
                    break;
                default:
                    break;
            }
        }

        private void Combo_Click(object sender, EventArgs e)
        {
            if (Vista_Circulo.txtRadio.Text == "" || Vista_Circulo.txtRadio.Text == "Radio")
            {
                Vista_Circulo.erpMensaje.SetError(Vista_Circulo.txtRadio, "Ingrese Valor");
                Vista_Circulo.txtRadio.Focus();
            }
        }

        private void Lado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Vista_Circulo.erpMensaje.Clear();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Vista_Circulo.Dispose();
        }

        private void Vista_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Vista_Circulo.Handle, 0x112, 0xf012, 0);
        }

    }
}
