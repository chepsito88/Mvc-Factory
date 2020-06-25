using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MODELO
{
    public class Modelo_Cuadrado : IFiguras
    {
        private double[] Datos;

        public Modelo_Cuadrado(double [] Datos)
        {
            this.Datos = Datos;
        }

        public string Area()
        {
            return Math.Pow(Datos[0], 2)+"";
        }

        public string Descripcion()
        {
            return "Un polígono de 4 lados (una figura plana de lados rectos) donde todos los lados tienen igual longitud y todos los ángulos son rectos (90°). ";
        }

        public string Perimetro()
        {
            return 4 * Datos[0]+"";
        }
    }
}
