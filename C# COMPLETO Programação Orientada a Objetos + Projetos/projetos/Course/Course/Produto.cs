using System.Globalization;

namespace Course {
    class Produto {
        public string Nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque() {

            return preco * quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            this.quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            this.quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
                + ", $ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
