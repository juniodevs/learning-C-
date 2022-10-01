using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace ExercicioFIXACAO {
    class ConversorDeMoeda {
        public static double Converter() {

        Console.Write("Qual é a cotação do dólar? ");
        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos Dólares você vai comprar? ");
        double dolaresCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            return (cotacao * dolaresCompra) + (((cotacao * dolaresCompra) * 0.06));
        }

    }

}
