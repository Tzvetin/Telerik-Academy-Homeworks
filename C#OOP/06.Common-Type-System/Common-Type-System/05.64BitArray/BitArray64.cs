/*
Define a class BitArray64 to hold 64 bit values inside an ulong value.
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._64BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        //Field
        private ulong array;

        //BitArray64 Constructors
        public BitArray64() :
            this(0ul)
        {
        }

        public BitArray64(ulong bitArray)
        {
            this.array = bitArray;
        }

        //Indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in the range [0..63]");
                }
                ulong mask = 1ul;
                ulong shift = this.array >> index;
                return (int)(shift & mask);
            }
            set
            {
                if (value != 0 && value != 1)
                {
                    throw new IndexOutOfRangeException("Bit can only be set to 0 or 1");
                }
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in the range [0..63]");
                }
                ulong mask = 1ul;
                ulong shift = mask << index;
                this.array = (~shift) & this.array;
                if (value == 1)
                {
                    this.array = shift | this.array;
                }
            }
        }
        //Implement IEnumerable<int>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        //Equals(...)
        public override bool Equals(object obj)
        {
            if (obj is BitArray64)
            {
                BitArray64 param = obj as BitArray64;
                if (this.array == param.array)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new ArgumentException("Argument is invalid type");
            }
        }

        //GetHashCode()
        public override int GetHashCode()
        {
            return array.GetHashCode();
        }

        //== and !=
        public static bool operator ==(BitArray64 array1, BitArray64 array2)
        {
            return array1.Equals(array2);
        }

        public static bool operator !=(BitArray64 array1, BitArray64 array2)
        {
            return !(array1.Equals(array2));
        }
    }
}
