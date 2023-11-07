using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample2
{

    //Receiver
    public class Product
    {
        public string  Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(int amount) 
        {
            Price += amount;
            Console.WriteLine($"O preço do {Name} foi aumentado em R${amount}.");
        }

        public void DecreasePrice(int amount) 
        {
            if (amount < Price)
            {
                Price -= amount;
                Console.WriteLine($"O preço de {Name} foi abaixado em R${amount}");
            }
        }

        public override string ToString()
        {
            return $"O preço de {Name} é R${Price}";
        }

    }
}
