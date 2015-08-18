using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class ShoppingCart : IShoppingCart
    {
        private IList<IProduct> shoppingList;
        public ShoppingCart()
        {
            shoppingList = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.shoppingList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.shoppingList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (this.shoppingList.Contains(product))
            {
                return true;
            }
            return false;
        }

        public decimal TotalPrice()
        {

            return this.shoppingList.Sum(i => i.Price);
        }
    }
}
