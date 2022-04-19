using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Class
{
    public class Product
    {
        string name;
        string fabricator;
        double price;
        public string Name { set { name = value; } get { return name; } }
        public string Fabricator { set { fabricator = value; } get { return fabricator; } }
        public double Price 
        { 
            set 
            {
                if (price < 0)
                    throw new Exception("Цена товара должна быть больше ноля");
                else
                    price = value;
            } 
            get 
            { 
                return price; 
            } 
        }
        public Product()
        {
            name = "unknown";
            fabricator = "unknown";
            price = 0;
        }
        public Product(string Name,string Fabricator, double Price)
        {
            name = Name;
            fabricator = Fabricator;
            price = Price;
        }
        public override string ToString()
        {
            return $"Название: {name}   " +
                   $"Изготовитель: {fabricator}   " +
                   $"Цена: {price}";
        }

    }
}
