using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MODELO
{
    class Modelo_Circulo : IFiguras
    {
        double[] Datos;

        public Modelo_Circulo(double [] Datos)
        {
            this.Datos = Datos;
        }

        public string Area()
        {
            return Datos[1] * (Math.Pow(Datos[0], 2))+"";
        }

        public string Descripcion()
        {
            return "Una figura de 2 dimensiones que se realiza dibujando una curva que está siempre a la misma distancia de un centro. ";
        }

        public string Perimetro()
        {
            return 2 * Datos[1] * Datos[0]+"";
        }
    }
}
