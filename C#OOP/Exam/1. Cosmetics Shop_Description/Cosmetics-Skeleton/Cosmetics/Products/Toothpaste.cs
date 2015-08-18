using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste, IProduct
    {
        private const int minIngredientLength = 4;
        private const int maxIngredientLength = 12;

        private IList<string> listOfIngredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            foreach (var ingredient in ingredients)
            {
                if (ingredient.Length < minIngredientLength || ingredient.Length > maxIngredientLength)
                {
                    throw new ArgumentException(string.Format("Each ingredient must be between {0} and {1} symbols long!", minIngredientLength, maxIngredientLength));
                }
            }
            this.listOfIngredients = new List<string>(ingredients);

        }

        public string Ingredients
        {
            get { return string.Join(", ", this.listOfIngredients); }
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format("  * Ingredients: {0}", string.Join(", ", this.listOfIngredients)));
            return sb.ToString().Trim();
        }
        
        

    }
}
