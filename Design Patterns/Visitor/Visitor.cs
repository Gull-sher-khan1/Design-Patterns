using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface Visitor
    {
        public double Visit(EducationBook eb);
        public double Visit(FantasyBook fb);
    }

    public class CartVisitor:Visitor
    {
        public double Visit(EducationBook eb)
            => eb.Price - (eb.Price > 1 ? eb.Price * 0.3 : 0);

        public double Visit(FantasyBook fb)
            => fb.Price - (fb.Price > 1 ? fb.Price * 0.5 : 0);
    }

    public class ShoppingCart
    {
        public List<Product> products = new List<Product>();
        
        public ShoppingCart(params  Product[] products)
        {
            foreach(var product in products)
            {
                this.products.Add(product);
            }
        }

        public double CalculateTotal(Visitor v)
            => this.products.Aggregate(0.0, (x, y) => x + y.Accept(v));
    }
    public interface Product
    {
        public double Accept(Visitor v);
    }
    public class EducationBook: Product
    {
        public double Price { get; set; }

        public string Name { get; set; }

        public EducationBook(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double Accept(Visitor v)
        {
            return v.Visit(this);
        }
    }

    public class FantasyBook : Product
    {
        public double Price { get; set; }

        public string Name { get; set; }

        public FantasyBook(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double Accept(Visitor v)
        {
            return v.Visit(this);
        }
    }
}
