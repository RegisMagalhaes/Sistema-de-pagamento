﻿using System;
using Abstração.Classes;

namespace Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite o valor da compra: ");
           float valorDaCompra = float.Parse(Console.ReadLine());

           Console.WriteLine("Selecione um método de pagamento: ");
           Console.WriteLine("1 - Boleto");
           Console.WriteLine("2 - Cartão");
           int opcao = int.Parse(Console.ReadLine());

           switch (opcao)
           {
               case 1:
                    //boleto
                    Boleto boleto = new Boleto ();
                    boleto.Registrar();
                    Console.WriteLine($"Codigo de Barras - {boleto.CodigoDeBarras} ");
                    boleto.Valor = valorDaCompra;
                    boleto.Data = DateTime.Now;
                    boleto.GerarBoleto();
                   break;

                case 2:

                    // cartão
                    break;
               default:
                   break;
           }
           

        }
    }
}
