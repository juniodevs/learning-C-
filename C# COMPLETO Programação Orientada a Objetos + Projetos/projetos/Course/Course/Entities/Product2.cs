using System;

namespace Course.Entities
{
    class Product2
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product2(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product2))
                return false;

            Product2 other = obj as Product2;

            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }
    }
}
