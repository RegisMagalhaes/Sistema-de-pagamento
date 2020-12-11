using System;
using Abstração.Classes;

namespace Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto1 = new Boleto();

            boleto1.Registrar("123456");

            Console.WriteLine(boleto1.CodigoDeBarras);
        }
    }
}
