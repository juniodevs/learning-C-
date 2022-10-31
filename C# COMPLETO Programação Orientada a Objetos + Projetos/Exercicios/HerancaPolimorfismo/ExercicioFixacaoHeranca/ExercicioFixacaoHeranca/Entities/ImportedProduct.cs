﻿using System.Globalization;

namespace ExercicioFixacaoHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return (Name + " $ " 
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + " " + "(Customs fee: $ " 
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")");
        }

        private double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
