using System;

namespace Abstração.Classes
{
    public class Debito : Cartão
    {
        private DateTime data;

        protected float valor;

        public string Cancelar(){
            return "";
        }
    }
}