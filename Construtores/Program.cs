using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //'p' é uma variavvel do tipo PRODUTO 
            //Em seguida acontece a Invocacao/instanciação(new) da CLASSE do tipo PRODUTO
            Produto p = new Produto("500", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

        }
    }
}