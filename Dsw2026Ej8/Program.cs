namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("--- Prueba Problema 1 ---");
            var helper = new ProductHelper();
            // Formato esperado: [12345] Laptop Gamer - $150.000,00
            string etiqueta = helper.ObtenerEtiquetaProducto(12345, "Laptop Gamer", 150000.00m);
            Console.WriteLine(etiqueta);
            */

            /*
            // Prueba P2: Resumen con Clase Anónima[cite: 3]
            Console.WriteLine("\n--- Prueba Problema 2 ---");
            var prob2 = new Problema2();
            // Caso normal: 2 unidades a 50.5[cite: 3]
            Console.WriteLine("Venta normal: " + prob2.CrearResumenVenta(101, "Mouse", 2, 50.5m));
            // Caso cantidad <= 0: Total debe ser 0[cite: 3]
            Console.WriteLine("Venta cantidad 0: " + prob2.CrearResumenVenta(102, "Pad", 0, 100m));
            */

            // Prueba P3: Comparación de copias[cite: 3]
            Console.WriteLine("\n--- Prueba Problema 3 ---");
            var prob3 = new Problema3();
            var prod = new Product(1, "Original", "Producto de Prueba", 100.0);
            // Formato esperado: valorOriginal-valorCopia-descripcionProducto[cite: 3]
            // El valor original debe permanecer igual, la descripción debe cambiar[cite: 1, 3]
            Console.WriteLine(prob3.CompararCopias(50, prod));

            /*
            Problema5 motor = new Problema5();

            Sale venta1 = new RetailSale(100);
            Console.WriteLine(motor.ObtenerImporteFinal(venta1)); // Resultado: 100

            Sale venta2 = new WholesaleSale(100);
            Console.WriteLine(motor.ObtenerImporteFinal(venta2)); // Resultado: 90
            */


        }
    }
}
