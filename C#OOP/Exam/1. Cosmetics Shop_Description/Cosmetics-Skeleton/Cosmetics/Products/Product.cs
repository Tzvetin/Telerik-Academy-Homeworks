using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private const int minNameLength = 3;
        private const int maxNameLength = 10;
        private const int minBrandLength = 2;
        private const int maxBrandLength = 10;

        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (value.Length < minNameLength || value.Length > maxNameLength)
                {
                    throw new ArgumentException(string.Format("Product name must be between {0} and {1} symbols long!", minNameLength, maxNameLength));
                }
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            protected set
            {
                if (value.Length < minBrandLength || value.Length > maxBrandLength)
                {
                    throw new ArgumentException(string.Format("Product brand must be between {0} and {1} symbols long!", minBrandLength, maxBrandLength));
                }
                this.brand = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Price cannot be negative");
                }
                this.price = value;
            }

        }

        public GenderType Gender
        {
            get { return this.gender; }
            protected set
            {
                this.gender = value;
            }
        }

        public string Print()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            sb.AppendLine(string.Format("  * Price: ${0}", this.Price));
            sb.AppendLine(string.Format("  * For gender: {0}", this.Gender));
            return sb.ToString().Trim();
        }

      
    }
}
