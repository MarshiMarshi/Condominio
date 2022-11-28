using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Projeto_DS_Condominio.Model
{
    public class Cpf : NumeroFormatavel
    {
        public Cpf(String digitos) => this.digitos = digitos;
        public override String Digitos
        {
            set
            {
                if (value.Length == 11 && value.All(char.IsDigit))
                    this.digitos = value;
                else if (Regex.IsMatch(value, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
                    this.digitos = string.Concat(value.Where(char.IsDigit));
            }
        }

        public override String ToDigitsString() => this.digitos;
        public override String ToFormattedString() => digitos.Insert(9, "-").Insert(6, ".").Insert(3, ".");

        public static bool TryParse(String digitos, out Cpf cpf)
        {
            if (digitos.Length == 11 && digitos.All(char.IsDigit))
            {
                cpf = new Cpf(digitos);
                return true;
            }
            else if (Regex.IsMatch(digitos, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
            {
                cpf = new Cpf(string.Concat(digitos.Where(char.IsDigit)));
                return true;
            }
            cpf = null;
            return false;
        }
    }
}
