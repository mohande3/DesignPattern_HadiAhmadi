using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositProduct
{
    internal abstract class Product
    {
        public string Name { get; set; } = "";
        public abstract double GetPrice();
    }

    internal class Box : Product
    {
        private List<Product> _products;

        public Box(params Product[] producs)
        {
            _products = producs.ToList();
        }

        public override double GetPrice()
        {
            return _products.Sum(p => p.GetPrice());
        }
    }

    internal class ProductItem : Product
    {
        private double _price = 0;

        public ProductItem(double price)
        {
            _price = price;
        }

        public override double GetPrice()
        {
            return _price;
        }
    }
}
