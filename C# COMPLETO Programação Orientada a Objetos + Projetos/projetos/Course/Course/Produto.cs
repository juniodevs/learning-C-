using System.Globalization;

namespace Course {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                    this._nome = value;
            }
        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
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
