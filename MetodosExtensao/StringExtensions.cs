using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtensao
{
    public static class StringExtensions
    {
        public static string InverterCaixas(this string value, bool initialState)
        {
            bool isUpperCase = initialState;
            string result = string.Empty;
            for (int i = 0; i < value.Length; i++)
            {
                result += isUpperCase ? value[i].ToString().ToUpper() : value[i].ToString().ToLower();
                isUpperCase = !isUpperCase;
            }
            return result;
        }
    }
}
