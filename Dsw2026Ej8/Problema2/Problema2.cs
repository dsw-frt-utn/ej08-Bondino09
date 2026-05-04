using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        /*
            Crear un método público CrearResumenVenta, dentro de una clase Problema2, que
            reciba:
            ● long productCode
            ● string productDescription
            ● int quantity
            ● decimal unitPrice
            El método debe crear internamente una clase anónima con los datos:
            ● Code
            ● Description
            ● Quantity
            ● Total
            Debe retornar una cadena con el formato:
            Code-Description-Total
            Condiciones:
            ● Total debe calcularse como quantity * unitPrice.
            ● Si quantity es menor o igual a 0, el total debe ser 0.
            ● El método debe usar una clase anónima dentro de su implementación.
        */

        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            var anonima = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = quantity * unitPrice };
            return $"{anonima.Code}-{anonima.Description}-{anonima.Total}";
        }
    }
}
