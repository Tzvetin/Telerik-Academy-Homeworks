using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo, IProduct
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price*milliliters, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters
        {
            get { return this.milliliters; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Milliliters cannot be negative");
                }
                this.milliliters = value;
            }
        }

        public Common.UsageType Usage
        {
            get { return this.usage; }
            private set
            {
                this.usage = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            sb.AppendLine(string.Format("  * Usage: {0}", this.Usage));
            return sb.ToString().Trim();
        }

        
    }
}
