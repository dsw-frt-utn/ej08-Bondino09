using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal importe) : base(importe) { }

        public override decimal CalculateTotal()
        {
            return _importe * 0.9M;
        }
        
    }
}
