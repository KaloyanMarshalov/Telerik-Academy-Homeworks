namespace GenericList
{
    using System;
    using System.Text;

    public class GenericList<T>
        where T: IComparable
    {
        const int defaultCapacity = 16;

        private T[] elements;
        private int elementsCount;

        public GenericList() : this(defaultCapacity)
        {
        }
        public GenericList(int capacity)
        {
            elements = new T[capacity];
            elementsCount = 0;
        }

        public int Count { get { return this.elementsCount; } }
        public void AddElement(T element)
        {
            if (elementsCount > elements.Length) //if the current index is bigger than the length of the array increase the size
            {
                IncreaseArraySize();
            }

            elements[elementsCount] = element;
            elementsCount++;
        }
        public T RemoveElement(int index)
        {
            CheckIndex(index);

            T removedElement = elements[index];
            for (int i = index + 1; i < this.elements.Length; i++)
            {
                this.elements[i - 1] = this.elements[i]; 
            }

            this.elements[elementsCount - 1] = default(T);
            elementsCount--;
            return removedElement;
        }
        public void InsertElement(T element, int index)
        {
            CheckIndex(index);

            if (this.elementsCount + 1 == this.elements.Length )
            {
                IncreaseArraySize();
            }
            for (int i = this.elementsCount + 1; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
            elementsCount++;
        }
        public void Clear()
        {
            this.elements = new T[elements.Length];
            this.elementsCount = 0;
        }
        public T Min()
        {
            T result = this.elements[0];
            for (int i = 1; i < this.elementsCount; i++)
            {
                if (result.CompareTo(elements[i]) > 0)
                {
                    result = elements[i];
                }
            }
            return result;
        }
        public T Max()
        {
            T result = this.elements[0];
            for (int i = 1; i < this.elementsCount; i++)
            {
                if (result.CompareTo(elements[i]) < 0)
                {
                    result = elements[i];
                }
            }
            return result;
        }
        private void IncreaseArraySize()
        {
            var newArray = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newArray[i] = this.elements[i];
            }
            this.elements = newArray;
        }
        private void CheckIndex(int index)
        {
            if (index < 0 || index >= this.elementsCount + 1)
            {
                throw new ArgumentOutOfRangeException("Invalid index " + index);
            }
        }
        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                T result = this.elements[index];
                return result;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.elementsCount; i++)
            {
                result.Append(elements[i]);
                if (i < this.elementsCount - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }
    }
}
