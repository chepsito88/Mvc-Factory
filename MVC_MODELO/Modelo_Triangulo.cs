using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MODELO
{
    class Modelo_Triangulo : IFiguras
    {
        double[] Datos;
        public Modelo_Triangulo(double[] Datos)
        {
            this.Datos = Datos;
        }

        public string Area()
        {
            double semiperimetro = (Datos[2] + Datos[0] + Datos[1]) / 2;
            return Math.Sqrt(semiperimetro * (semiperimetro - Datos[2]) * (semiperimetro - Datos[0]) * (semiperimetro - Datos[1]))+"";
        }

        public string Descripcion()
        {
            string mensaje = "";
            if ((Datos[0] != Datos[1]) && (Datos[0] != Datos[2]) && (Datos[1] != Datos[2]))
            {
                mensaje = "Triángulo escaleno es un triángulo en el cual los tres lados tienen longitudes diferentes.";
            }
            else if ((Datos[0] == Datos[1]) && (Datos[0] == Datos[2]))
            {
                mensaje = "Triángulo equilátero, es un polígono regular, es decir, tiene sus tres lados iguales.";
            }
            else if (Datos[1] == Datos[2])
            {
                mensaje = "Triángulo isósceles es un tipo de triángulo que tiene dos lados de igual longitud. ";
            }
            return mensaje;
        }

        public string Perimetro()
        {
            double _Perimetro = 0;
            if ((Datos[0] != Datos[1]) && (Datos[0] != Datos[2]) && (Datos[1] != Datos[2]))
            {
                _Perimetro = Datos[0] + Datos[1] + Datos[2];
            }
            else if ((Datos[0] == Datos[1]) && (Datos[0] == Datos[2]))
            {
                _Perimetro = 3 * Datos[0];
            }
            else if (Datos[1] == Datos[2])
            {
                _Perimetro = 2 * Datos[0] + Datos[1];
            }
            return _Perimetro+"";
        }
    }
}
