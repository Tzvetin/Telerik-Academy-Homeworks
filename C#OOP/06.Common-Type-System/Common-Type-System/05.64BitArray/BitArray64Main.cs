using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._64BitArray
{
    class BitArray64Main
    {
        static void Main(string[] args)
        {
            BitArray64 array = new BitArray64();
            array[0] = 1;
            BitArray64 anotherArray = new BitArray64(1);
            Console.WriteLine(array.Equals(anotherArray));
        }
    }
}
