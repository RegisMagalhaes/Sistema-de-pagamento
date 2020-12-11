namespace Abstração.Classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public string CodigoDeBarras{
            get{return codigoDeBarras;}
        }

        public void Registrar(string valor){
            this.codigoDeBarras = valor;
        }


    }
}