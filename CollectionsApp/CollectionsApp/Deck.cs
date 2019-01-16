using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsApp
{
    public class Deck<T> : IEnumerable<T>
    {

        public T[] internalItems = new T[1];
        int currentIndex = 0;


        public void Add(T item)
        {
            if (currentIndex > internalItems.Length - 1)
            {
                Array.Resize(ref internalItems, internalItems.Length + 1);
            }
            internalItems[currentIndex] = item;
            currentIndex++;
        }

        public void Remove(T item)
        {
            int j = 0;
            for (int i = 0; i < internalItems.Length - 1; i++)
            {
                if (item.Equals(internalItems[i]))
                {
                    j++;
                }
                internalItems[i] = internalItems[j];
                j++;
                if (j == internalItems.Length)
                {
                    i = internalItems.Length - 1;

                }
            }
            Array.Resize(ref internalItems, internalItems.Length - 1);
            currentIndex--;

        }

        public int Count()
        {
            return currentIndex;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < internalItems.Length; i++)
            {
                yield return internalItems[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


