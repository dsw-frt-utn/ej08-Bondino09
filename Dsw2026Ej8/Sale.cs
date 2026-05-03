using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal _importe;

        public Sale(decimal importe)
        {
            _importe = importe;
        }

        public decimal GetImporte()
        {
            return _importe;
        }

        public void SetImporte(decimal importe)
        {
            _importe = importe;
        }

        public virtual decimal CalculateTotal()
        {
            return _importe;
        }
    }
}
