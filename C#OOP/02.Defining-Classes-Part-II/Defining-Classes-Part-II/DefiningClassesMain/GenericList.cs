using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesMain
{
    // generic class that keeps a list of elements of some parametric type T
    public class GenericList<T>
        where T : IComparable // generic constraints for the type T
    {
        //Fields
        private T[] listOfElements; // array with fixed capacity to keep the elements
        private int count;
        private int capacity;

        //Constructors
        public GenericList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("Elements in the list must be zero or more.");
            }
            listOfElements = new T[capacity];
            this.capacity = capacity;
            this.count = 0;
        }
        public GenericList() : this(0)
        {
        }

        //Properties
        public int Count
        {
            get { return this.count; }
        }
        public int Capacity
        {
            get { return this.capacity; }
        }

        //Methods
        // adding element
        public void AddElement(T element)
        {
            if (this.capacity == this.count)
            {
                AutoGrow();
            }
            this.listOfElements[count] = element;
            this.count++;
        }
        // Indexer
        // accessing element by index
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                return this.listOfElements[index];
            }
            set
            {
                if (index < 0 || index >= this.count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                this.listOfElements[index] = value;
            }
        }
        // removing element by index
        public void RemoveElementByIndex(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            for (int i = index; i < this.count - 1; i++)
            {
                this.listOfElements[i] = this.listOfElements[i + 1];
            }
            this.count--;
        }
        // inserting element at given position
        public void InsertElementAtGivenPosition(T element, int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            if (this.capacity == this.count)
            {
                AutoGrow();
            }
            for (int i = this.count; i > index; i--)
            {
                this.listOfElements[i] = this.listOfElements[i - 1];
            }
            this.listOfElements[index] = element;
            this.count++;
        }
        // clearing the list
        public void ClearList()
        {
            this.listOfElements = new T[0];
            this.count = 0;
            this.capacity = 0;
        }
        // finding element by its value 
        public int FindElementByValue(T value)
        {
            int foundIndex = -1;
            int currentIndex = 0;
            foreach (var element in this.listOfElements)
            {
                if (value.CompareTo(element) == 0)
                {
                    foundIndex = currentIndex;
                    break;
                }
                currentIndex++;
            }
            return foundIndex;
        }
        // ToString()
        public override string ToString()
        {
            if (this.listOfElements == null)
            {
                throw new NullReferenceException("Object is not initialized");
            }
            if (this.listOfElements.Length == 0)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("{ ");
            for (int i = 0; i < this.count; i++)
            {
                sb.Append(this.listOfElements[i]);
                sb.Append(" ");
            }
            sb.Append("}");
            return sb.ToString();
        }
        //Implement auto-grow functionality:
        // when the internal array is full, create a new array of double size and move all elements to it
        private void AutoGrow()
        {
            if (this.capacity == 0)
            {
                this.capacity = 1;
                this.listOfElements = new T[this.capacity];
            }
            else
            {
                long newCapacity = 2 * this.capacity;
                if (newCapacity > (long)int.MaxValue)
                {
                    throw new OutOfMemoryException("Max capacity reached");
                }
                this.capacity = (int)newCapacity;
                T[] copy = new T[this.count];

                for (int i = 0; i < this.count; i++)
                {
                    copy[i] = this.listOfElements[i];
                }
                this.listOfElements = new T[this.capacity];

                for (int i = 0; i < this.count; i++)
                {
                    this.listOfElements[i] = copy[i];
                }
            }
        }
        // generic method Min<T>() for finding the minimal element in the  GenericList<T>
        public T Min()
        {
            if (this.listOfElements == null)
            {
                throw new NullReferenceException("Object is not initialized");
            }
            if (this.listOfElements.Length == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            T min = this.listOfElements[0];

            for (int i = 1; i < this.count; i++)
            {
                if (this.listOfElements[i].CompareTo(min) < 0)
                {
                    min = this.listOfElements[i];
                }
            }
            return min;
        }
        // generic method Max<T>() for finding the maximal element in the  GenericList<T>
        public T Max()
        {
            if (this.listOfElements == null)
            {
                throw new NullReferenceException("Object is not initialized");
            }
            if (this.listOfElements.Length == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            T max = this.listOfElements[0];

            for (int i = 1; i < this.count; i++)
            {
                if (this.listOfElements[i].CompareTo(max) > 0)
                {
                    max = this.listOfElements[i];
                }
            }
            return max;
        }
    }
}
