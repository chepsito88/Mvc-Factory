using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MODELO
{
    public class Construye_Figuras
    {
        public static IFiguras Instanciar(int opc, double[] Datos)
        {
            switch (opc)
            {
                case 1: return new Modelo_Cuadrado(Datos);
                case 2: return new Modelo_Circulo(Datos);
                case 3: return new Modelo_Rectangulo(Datos);
                case 4: return new Modelo_Triangulo(Datos);

                default: return null;
            }
        }
    }
}
