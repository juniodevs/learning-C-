using System.Globalization;

namespace Course {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
            _quantidade = 10;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            this._preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this() {
            this._quantidade = quantidade;
        }

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {

            if (nome != null && nome.Length > 1)
            this._nome = nome;
        }

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
        }

        //public Produto(string nome, double preco, int quantidade) {

        //    Nome = nome;
        //    this.preco = preco;
        //    this.quantidade = quantidade;

        //}


        //public Produto(string nome, double preco) {
        //    Nome = nome;
        //    this.preco = preco;
        //    quantidade = 5;
        //}


        public double ValorTotalEmEstoque() {

            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            this._quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            this._quantidade -= quantidade;
        }

        public override string ToString() {
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
