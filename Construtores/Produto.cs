using System.Diagnostics.Contracts;
using System.Globalization;
namespace Course
{
    class Produto
    {
        //Aqui acontece a declaração dos ATRIBUTOS DA CLASSE 
        private string _nome;
        private double _preco;
        private int _quantidade;


        //Isso é um construtor
        public Produto (string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Nome() os parenteses indicam ser um METODO dentro do OBJETO TIPO PRODUTO

        public string Nome(){
            get { return _nome;}
            set { 
                if( value != null && value.Length >1){
                    _nome = value;
                };
            };
        }
        // public  string GetNome(){
        //     return _nome;
        // }
        
        // public  string SetNome(string nome){
        //     if( nome != null && nome.Length >1){
        //         _nome = nome;
        //     }
        //     return _nome;
        // }

        public double Preco(){
            get{ return _preco; }
        }

        public int GetQuantidade(){
            return _quantidade;
        }



        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}