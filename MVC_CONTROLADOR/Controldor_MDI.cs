using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_VISTAS;
using MVC_MODELO;
using System.Windows.Forms;
using System.Drawing;

namespace MVC_CONTROLADOR
{
    public class Controldor_MDI
    {
        Vista_MDI Vista_MDI;      
        public Controldor_MDI(Vista_MDI Vista_MDI)
        {
            this.Vista_MDI = Vista_MDI;

            this.Vista_MDI.BackColor = Color.Red;
        }

        public void Iniciar() {
           

            Vista_MDI.StartPosition = FormStartPosition.CenterScreen;
            Vista_MDI.WindowState = FormWindowState.Maximized;
            Vista_MDI.mnuCuadrado.Click += Click_Cuadrado;
            Vista_MDI.mnuRectangulo.Click += Click_Rectangulo;
            Vista_MDI.mnuCirculo.Click += Click_Circulo;
            Vista_MDI.mnuTriangulo.Click += Click_Triangulo;
            Vista_MDI.btnSalir.Click += Click_Salir;

        }

        private void Click_Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Click_Triangulo(object sender, EventArgs e)
        {
            Vista_Triangulo Vista_Triangulo = new Vista_Triangulo();
            Controlador_Triangulo Control_Triangulo = new Controlador_Triangulo(Vista_Triangulo);
            Vista_Triangulo.MdiParent = Vista_MDI;
            Vista_Triangulo.StartPosition = FormStartPosition.CenterScreen;
            Control_Triangulo.Eventos();
            Vista_Triangulo.Show();
        }

        private void Click_Circulo(object sender, EventArgs e)
        {
            Vista_Circulo Vista_Circulo = new Vista_Circulo();
            Controlador_Circulo Control_Cicrulo = new Controlador_Circulo(Vista_Circulo);
            Vista_Circulo.MdiParent = Vista_MDI;
            Vista_Circulo.StartPosition = FormStartPosition.CenterScreen;
            Control_Cicrulo.Eventos();
            Vista_Circulo.Show();
        }

        private void Click_Rectangulo(object sender, EventArgs e)
        {
            Vista_Rectangulo Vista_Rectangulo = new Vista_Rectangulo();
            Controladro_Rectangulo Control_Rectangulo = new Controladro_Rectangulo(Vista_Rectangulo);
            Vista_Rectangulo.MdiParent = Vista_MDI;
            Vista_Rectangulo.StartPosition = FormStartPosition.CenterScreen;
            Control_Rectangulo.Eventos();
            Vista_Rectangulo.Show();
        }

        private void Click_Cuadrado(object sender, EventArgs e)
        {
            Vista_Cuadrado Vista_Cuadrado = new Vista_Cuadrado();
            Controlador_Cuadrado Control_Cuadrado = new Controlador_Cuadrado(Vista_Cuadrado);
            Vista_Cuadrado.MdiParent = Vista_MDI;
            Vista_Cuadrado.StartPosition = FormStartPosition.CenterScreen;
            Control_Cuadrado.Eventos();
            Vista_Cuadrado.Show();

        }
    }
}
