﻿using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Entre os dados do produto:");
            // Console.Write("Nome: ");
            // string nome = Console.ReadLine();
            // Console.Write("Preço: ");
            // double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto p = new Produto("500", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());




            // // Produto p2 = new Produto()
            // // {
            // //     Quantidade = 10
            // // };

            // Produto p3 = new Produto
            //     {
            //         Nome = "tv",
            //         Preco = 500.00,
            //         Quantidade = 20
            //    

            // Console.WriteLine();
            // Console.WriteLine("Dados do produto: " + p);
            // Console.WriteLine();
            // Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            // int qte = int.Parse(Console.ReadLine());
            // p.AdicionarProdutos(qte);
            // Console.WriteLine();
            // Console.WriteLine("Dados atualizados: " + p);
            // Console.WriteLine();
            // Console.Write("Digite o número de produtos a ser removido do estoque: ");
            // qte = int.Parse(Console.ReadLine());
            // p.RemoverProdutos(qte);
            // Console.WriteLine();
            // Console.WriteLine("Dados atualizados: " + p);
        }
    }
}