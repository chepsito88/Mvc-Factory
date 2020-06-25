using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MVC_MODELO;
using MVC_VISTAS;

namespace MVC_CONTROLADOR
{
    class Controlador_Cuadrado
    {
        Vista_Cuadrado Vista_Cuadrado;

        public Controlador_Cuadrado(Vista_Cuadrado Vista_Cuadrado)
        {
            this.Vista_Cuadrado = Vista_Cuadrado;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public void Eventos() {
            Vista_Cuadrado.MouseDown += Vista_MouseDown;
            Vista_Cuadrado.pnlImagen.MouseDown += Vista_MouseDown;
            Vista_Cuadrado.btnCerrar.Click += Cerrar_Click;
            Vista_Cuadrado.txtLado.KeyPress += Lado_KeyPress;
            Vista_Cuadrado.cmbOperacion.Click += Combo_Click;
            Vista_Cuadrado.cmbOperacion.SelectedIndexChanged += Combo_Seleccion;
            Vista_Cuadrado.btnLimpiar.Click += Limpiar_Click;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control objeto in Vista_Cuadrado.Controls)
                if (objeto is TextBox) ((TextBox)objeto).Clear();

            Vista_Cuadrado.txtLado.Clear();
            Vista_Cuadrado.cmbOperacion.Text = "Elije opcion:";            
        }

        private void Combo_Seleccion(object sender, EventArgs e)
        {
            double[] Datos = { double.Parse(Vista_Cuadrado.txtLado.Text) };
            IFiguras Cuadrado = Construye_Figuras.Instanciar(1, Datos);
            int opc = Vista_Cuadrado.cmbOperacion.SelectedIndex;
            switch (opc)
            {
                case 0:
                    Vista_Cuadrado.txtArea.Text = Cuadrado.Area();
                    break;
                case 1:
                    Vista_Cuadrado.txtPerimetro.Text = Cuadrado.Perimetro();
                    break;
                case 2:
                    Vista_Cuadrado.txtDescripcion.Text = Cuadrado.Descripcion();
                    break;
                default:
                    break;
            }
        }

        private void Combo_Click(object sender, EventArgs e)
        {
            if (Vista_Cuadrado.txtLado.Text=="" || Vista_Cuadrado.Text=="Lado")
            {
                Vista_Cuadrado.erpMensaje.SetError(Vista_Cuadrado.txtLado,"Ingrese Valor");
                Vista_Cuadrado.txtLado.Focus();
            }
        }

        private void Lado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Vista_Cuadrado.erpMensaje.Clear();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Vista_Cuadrado.Dispose();
        }

        private void Vista_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Vista_Cuadrado.Handle, 0x112, 0xf012, 0);
        }
    }
}
