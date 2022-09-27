namespace Course {
    class Produto {
        public string Nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque() {

            return preco * quantidade;
        }

    }
}
