using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ShortCodeTest1
{
    public class Listify : IList<int>
    {
        private readonly int begin;
        private readonly int end;
        private IEnumerable<int> enumerable;

        public Listify(int begin, int end)
        {
            if (begin > end)
                throw new ArgumentException("Start value has to be less than or equal to end value");

            this.begin = begin;
            this.end = end;

            enumerable = Enumerable.Range(begin, end);
        }

        public int this[int index] 
        { 
            get => begin + index; 
            set => throw new NotImplementedException(); 
        }

        public int Count => end - begin;

        public bool IsReadOnly => true;

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
