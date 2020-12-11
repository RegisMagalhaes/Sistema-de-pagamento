namespace Abstração.Classes
{
    public abstract class Cartão : Pagamento
    {
        public string bandeira;

        public string numero;

        public string titular;

        public string cvv;

        public string salvarCartao(){
            return "";
        }

        public abstract void Pagar();


    }
}