using System;

namespace Abstração.Classes
{
    public class Boleto : Pagamento
    {

        private float codigoDeBarras;

        public float CodigoDeBarras{
            get{return codigoDeBarras;}
        }

        public void Registrar(){
            Random randomico = new Random();
            this.codigoDeBarras = randomico.Next();
        }

        public void GerarBoleto(){
            Console.WriteLine($"O valor do boleto - R${this.Valor}");
            Console.WriteLine($"Data - {this.Data}");
            Console.WriteLine($"Data de vencimento {this.Data.AddDays(10)}");
            Console.WriteLine($"Código de Barras - {this.codigoDeBarras} ");
        }


    }
}