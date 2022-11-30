using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Projeto_DS_Condominio.Model
{
    public class Rg : NumeroFormatavel
    {
        public Rg(string digitos) => this.digitos = digitos;

        public override String Digitos
        {
            set
            {
                if (value.Length == 11 && value.All(char.IsDigit))
                    this.digitos = value;
                else if (Regex.IsMatch(value, @"^\d{2}\.\d{3}\.\d{3}-\d{1}$"))
                    this.digitos = string.Concat(value.Where(char.IsDigit));
            }
        }

        public override string ToString() => ToFormattedString();
        public override String ToDigitsString() => this.digitos;
        public override String ToFormattedString() => digitos.Insert(2, ".").Insert(6, ".").Insert(10, "-");

        public static bool TryParse(String digitos, out Rg rg)
        {
            if (digitos.Length == 11 && digitos.All(char.IsDigit))
            {
                rg = new Rg(digitos);
                return true;
            }
            else if (Regex.IsMatch(digitos, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
            {
                rg = new Rg(string.Concat(digitos.Where(char.IsDigit)));
                return true;
            }
            rg = null;
            return false;
        }
    }
}
