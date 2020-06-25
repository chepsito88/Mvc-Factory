using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_MODELO;
using MVC_VISTAS;

namespace MVC_CONTROLADOR
{
    class Controladro_Rectangulo
    {
        Vista_Rectangulo Vista_Rectangulo;

        public Controladro_Rectangulo(Vista_Rectangulo Vista_Rectangulo)
        {
            this.Vista_Rectangulo = Vista_Rectangulo;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void Eventos()
        {
            Vista_Rectangulo.MouseDown += Vista_MouseDown;
            Vista_Rectangulo.pnlImagen.MouseDown += Vista_MouseDown;
            Vista_Rectangulo.btnCerrar.Click += Cerrar_Click;
            Vista_Rectangulo.txtBase.KeyPress += Lado_KeyPress;
            Vista_Rectangulo.txtAltura.KeyPress += Lado_KeyPress;
            Vista_Rectangulo.cmbOperacion.Click += Combo_Click;
            Vista_Rectangulo.cmbOperacion.SelectedIndexChanged += Combo_Seleccion;
            Vista_Rectangulo.btnLimpiar.Click += Limpiar_Click;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control objeto in Vista_Rectangulo.Controls)
                if (objeto is TextBox) ((TextBox)objeto).Clear();

            Vista_Rectangulo.txtBase.Clear();
            Vista_Rectangulo.txtAltura.Clear();
            Vista_Rectangulo.cmbOperacion.Text = "Elije opcion:";
        }

        private void Combo_Seleccion(object sender, EventArgs e)
        {
            double[] Datos = { double.Parse(Vista_Rectangulo.txtBase.Text),double.Parse(Vista_Rectangulo.txtAltura.Text)};
            IFiguras Rectangulo = Construye_Figuras.Instanciar(3, Datos);
            int opc = Vista_Rectangulo.cmbOperacion.SelectedIndex;
            switch (opc)
            {
                case 0:
                    Vista_Rectangulo.txtArea.Text = Rectangulo.Area();
                    break;
                case 1:
                    Vista_Rectangulo.txtPerimetro.Text = Rectangulo.Perimetro();
                    break;
                case 2:
                    Vista_Rectangulo.txtDescripcion.Text = Rectangulo.Descripcion();
                    break;
                default:
                    break;
            }
        }

        private void Combo_Click(object sender, EventArgs e)
        {
            if (Vista_Rectangulo.txtBase.Text == "" || Vista_Rectangulo.txtBase.Text == "Base")
            {
                Vista_Rectangulo.erpMensaje.SetError(Vista_Rectangulo.txtBase, "Ingrese Valor");
                Vista_Rectangulo.txtBase.Focus();
            }

            if (Vista_Rectangulo.txtAltura.Text == "" || Vista_Rectangulo.txtAltura.Text == "Altura")
            {
                Vista_Rectangulo.erpMensaje.SetError(Vista_Rectangulo.txtAltura, "Ingrese Valor");
                Vista_Rectangulo.txtAltura.Focus();
            }
        }

        private void Lado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Vista_Rectangulo.erpMensaje.Clear();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Vista_Rectangulo.Dispose();
        }

        private void Vista_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Vista_Rectangulo.Handle, 0x112, 0xf012, 0);
        }
    }
}
