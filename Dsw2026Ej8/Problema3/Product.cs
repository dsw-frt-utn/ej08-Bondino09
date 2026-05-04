using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        private int _code;
        private string _description;
        private string _name;
        private double _price;

        public Product(int codigo, string descripcion, string nombre, double precio)
        {
            _code = codigo;
            _description = descripcion;
            _name = nombre;
            _price = precio;
        }

        public string getDescription()
        {
            return _description;
        }
        public void setDescription(string description)
        {
            _description = description;
        }
    }
}
