// Implement an extension method Substring(int index, int length) for the class StringBuilder 
// that returns new StringBuilder and has the same functionality as Substring in the class String.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder(length);
            if (sb == null)
            {
                throw new NullReferenceException("Null StringBuilder");
            }
            if (index < 0 || index >= sb.Length)
            {
                throw new ArgumentOutOfRangeException("Index is outside the range of the StringBuilder");
            }
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("Length of the substring is negative");
            }
            if (index + length >= sb.Length)
            {
                throw new ArgumentOutOfRangeException("Length is outside of the StringBuilder");
            }
            for (int i = index; i < index + length; i++)
            {
                result.Append(sb[i]);
            }

            return result;
        }
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The United States will have to negotiate with Syrian President Bashar al-Assad for a political transition in Syria");
            Console.WriteLine(sb.Substring(4, 13));
        }
    }
}
