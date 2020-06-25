using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MODELO
{
    class Modelo_Rectangulo : IFiguras
    {
        double[] Datos;

        public Modelo_Rectangulo(double []Datos)
        {
            this.Datos = Datos;
        }

        public string Area()
        {
            return Datos[0] * Datos[1]+"";
        }

        public string Descripcion()
        {
            return "Un rectángulo es un polígono de 4 lados (una figura plana de lados rectos) en donde cada ángulo es un ángulo recto (90°)";
        }

        public string Perimetro()
        {
            return 2 * (Datos[0] + Datos[1])+"";
        }
    }
}
