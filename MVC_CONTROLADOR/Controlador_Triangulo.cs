using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_MODELO;
using MVC_VISTAS;
namespace MVC_CONTROLADOR
{
    class Controlador_Triangulo
    {
        Vista_Triangulo Vista_Triangulo;
        double[] Datos;

        string cadena = Directory.GetCurrentDirectory();
        public Controlador_Triangulo(Vista_Triangulo Vista_Triangulo)
        {
            this.Vista_Triangulo = Vista_Triangulo;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void Eventos()
        {
            Vista_Triangulo.MouseDown += Vista_MouseDown;
            Vista_Triangulo.pnlImagen.MouseDown += Vista_MouseDown;
            Vista_Triangulo.btnCerrar.Click += Cerrar_Click;
            Vista_Triangulo.txtLadoA.KeyPress += Lado_KeyPress;
            Vista_Triangulo.txtLadoB.KeyPress += Lado_KeyPress;
            Vista_Triangulo.txtLadoC.KeyPress += Lado_KeyPress;
            Vista_Triangulo.cmbOperacion.Click += Combo_Click;
            Vista_Triangulo.cmbOperacion.SelectedIndexChanged += Combo_Seleccion;
            Vista_Triangulo.btnLimpiar.Click += Limpiar_Click;

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {            
            foreach (Control objeto in Vista_Triangulo.Controls)         
                if (objeto is TextBox) ((TextBox)objeto).Clear();
            
            Vista_Triangulo.txtLadoA.Clear();
            Vista_Triangulo.txtLadoB.Clear();
            Vista_Triangulo.txtLadoC.Clear();
            Vista_Triangulo.cmbOperacion.Text = "Elije opcion:";
        }

        private void Combo_Seleccion(object sender, EventArgs e)
        {
            
            IFiguras Rectangulo = Construye_Figuras.Instanciar(4, Datos);
            int opc = Vista_Triangulo.cmbOperacion.SelectedIndex;            
            switch (opc)
            {
                case 0:
                    Vista_Triangulo.txtArea.Text = Rectangulo.Area();
                    break;
                case 1:
                    Vista_Triangulo.txtPerimetro.Text = Rectangulo.Perimetro();
                    break;
                case 2:
                    Vista_Triangulo.txtDescripcion.Text = Rectangulo.Descripcion();
                    break;
                default:
                    break;
            }
        }

        private void Imagen()
        {
            if ((Datos[0] != Datos[1]) && (Datos[0] != Datos[2]) && (Datos[1] != Datos[2]))
            {
               Vista_Triangulo.picImagen.Image= Image.FromFile(cadena + "/Escaleno.jpg");
            }
            else if ((Datos[0] == Datos[1]) && (Datos[0] == Datos[2]))
            {
                Vista_Triangulo.picImagen.Image = Image.FromFile(cadena + "/Equilatero.jpg");
            }else if (Datos[1] == Datos[2])
            {
                Vista_Triangulo.picImagen.Image = Image.FromFile(cadena + "/Isoceles.jpg");

            }
        }

        private void Combo_Click(object sender, EventArgs e)
        {
            int checa = 0;
            if (Vista_Triangulo.txtLadoA.Text == "" || Vista_Triangulo.txtLadoA.Text == "Lado A")
            {
                Vista_Triangulo.erpMensaje.SetError(Vista_Triangulo.txtLadoA, "Ingrese Valor");
                Vista_Triangulo.txtLadoA.Focus();
                checa++;
            }

            if (Vista_Triangulo.txtLadoB.Text == "" || Vista_Triangulo.txtLadoB.Text == "Lado B")
            {
                Vista_Triangulo.erpMensaje.SetError(Vista_Triangulo.txtLadoB, "Ingrese Valor");
                Vista_Triangulo.txtLadoB.Focus();
                checa++;
            }

            if (Vista_Triangulo.txtLadoC.Text == "" || Vista_Triangulo.txtLadoC.Text == "Lado C")
            {
                Vista_Triangulo.erpMensaje.SetError(Vista_Triangulo.txtLadoC, "Ingrese Valor");
                Vista_Triangulo.txtLadoC.Focus();
                checa++;
            }
            if (checa==0)
            {
                Datos = new double[] { double.Parse(Vista_Triangulo.txtLadoA.Text), double.Parse(Vista_Triangulo.txtLadoB.Text), double.Parse(Vista_Triangulo.txtLadoC.Text) };
                Imagen();
            }
           
        }

        private void Lado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Vista_Triangulo.erpMensaje.Clear();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Vista_Triangulo.Dispose();
        }

        private void Vista_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Vista_Triangulo.Handle, 0x112, 0xf012, 0);
        }

    }
}
