using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAccountTests.Utilities
{
    public static class RandomGenerator
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private static Random random = new Random();

        public static string GetRandomString(int minLength = 0, int maxLength = 50)
        {
            var length = random.Next(minLength, maxLength);

            var result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(Alphabet[random.Next(0, Alphabet.Length)]);
            }

            return result.ToString();
        }
    }
}
