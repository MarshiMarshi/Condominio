using System;

namespace Projeto_DS_Condominio.Model
{
    public abstract class NumeroFormatavel
    {
        protected String digitos;
        public abstract string Digitos { set; }
        public abstract string ToDigitsString();
        public abstract string ToFormattedString();
    }
}