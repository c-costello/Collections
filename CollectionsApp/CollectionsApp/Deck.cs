using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsApp
{
    public class Deck<T> : IEnumerable<T>
    {

        T[] internalItems = new T[5];
        int currentIndex = 0;
        public void Add(T item)
        {
            if (currentIndex < internalItems.Length)
            {
                Array.Resize(ref internalItems, internalItems.Length * 2);
            }
            internalItems[currentIndex] = item;
            currentIndex++;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return internalItems[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator()
        }
    }
}


