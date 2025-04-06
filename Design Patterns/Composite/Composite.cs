using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Box: Product
    {
        public List<Product> Products;

        public Box(List<Product> insideProducts)
        {
            Products = insideProducts;
        }
        public double GetPrice()
        {
            double sum = 0;
            foreach (Product p in Products) 
            {
                sum += p.GetPrice();
            }
            return sum;
        }
    }

    public interface Product
    {
        public double GetPrice();
    }

    public class Book: Product
    {
        public double price;

        public Book(double price)
        {
            this.price = price;
        }
        public double GetPrice() 
        {
            return price;
        }
    }
}
