using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        /*
         Problema N° 4
            Crear un método público CalcularPromedio, dentro de una clase Problema4, que
            reciba:
            ● int? nota1
            ● int? nota2
            ● int? nota3
            Debe retornar un double.
            Condiciones:
            ● Debe calcular el promedio solo con las notas que tengan valor.
            ● Si las tres notas son null, debe retornar 0.
            ● Si una nota tiene valor menor que 0 o mayor que 10, debe ignorarse.
            ● No debe lanzar excepción si alguna nota es null.

         */
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            if (nota1 == null || nota1 > 10 || nota1 < 0) nota1 = 0; return (double)((nota2+nota3) / 2);
            if (nota2 == null || nota2 > 10 || nota2 < 0) nota2 = 0; return (double)((nota1 + nota3) / 2);
            if (nota3 == null || nota3 > 10 || nota3 < 0) nota3 = 0; return (double)((nota1 + nota2) / 2);
            return (double)((nota1 + nota2 + nota3) / 3); 
        }
    }
}
