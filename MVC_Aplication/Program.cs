using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_CONTROLADOR;
using MVC_VISTAS; 

namespace MVC_Aplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Vista_MDI Vista = new Vista_MDI();
            Controldor_MDI Controlador = new Controldor_MDI(Vista);
            Controlador.Iniciar();
            Vista.ShowDialog();
        }
    }
}
