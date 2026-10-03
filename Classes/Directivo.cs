using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados.Classes
{
    // clase hija
    public class Directivo : Empleado
    {
        // uso de internal, encapsulamiento
        internal Directivo(string nombre, int dni, double sueldo_base, int factor) : base(nombre, dni, sueldo_base, factor)
        {
            tipo = "Directivo";
        }
        // funcion derivada con otro factor de bono
        public override double sumarSueldoAdicional()
        {
            return Sueldo_base + (Factor * 1.7f);
        }
    }
}
