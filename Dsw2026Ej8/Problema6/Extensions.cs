using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if(code == null) return "SIN_CODIGO";
            else return code.Trim(); code.ToUpper(); code.Replace(" ", "-");
        }
    }
}
