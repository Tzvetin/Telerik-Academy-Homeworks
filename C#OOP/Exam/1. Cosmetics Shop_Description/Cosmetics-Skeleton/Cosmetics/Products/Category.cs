using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Category : ICategory
    {
        private const int minNameLength = 2;
        private const int maxNameLength = 15;

        private string name;
        private IList<IProduct> listOfProducts;

        public Category(string name)
        {
            this.Name = name;
            this.listOfProducts = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < minNameLength || value.Length > maxNameLength)
                {
                    throw new ArgumentException(string.Format("Category name must be between {0} and {1} symbols long!", minNameLength, maxNameLength));
                }
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            if (cosmetics == null)
            {
                throw new ArgumentException("Cosmetics is null");
            }
            this.listOfProducts.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (this.listOfProducts.IndexOf(cosmetics) == -1)
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
            this.listOfProducts.Remove(cosmetics);
        }

        public string Print()
        {
            var sortedListOfProducts = this.listOfProducts.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);
            string maybeProduct = string.Empty;
            if(this.listOfProducts.Count == 1)
            {
                maybeProduct = "product";
            }
            else
            {
                maybeProduct = "products";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} category - {1} {2} in total", this.Name, listOfProducts.Count, maybeProduct));
            foreach (var prod in sortedListOfProducts)
            {
                sb.AppendLine(prod.Print().Trim());
            }
            return sb.ToString().Trim();
        }
    }
}
