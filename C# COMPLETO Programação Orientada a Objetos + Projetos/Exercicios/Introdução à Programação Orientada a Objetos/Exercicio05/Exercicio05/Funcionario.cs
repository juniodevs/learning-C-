namespace Exercicio05 {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return (SalarioBruto - Imposto);
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += (SalarioBruto * porcentagem);
        }
    }
}
