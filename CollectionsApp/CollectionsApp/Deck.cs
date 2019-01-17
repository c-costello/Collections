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

        /// <summary>
        /// Adds an intem to a deck
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (currentIndex > internalItems.Length - 1)
            {
                Array.Resize(ref internalItems, internalItems.Length + 1);
            }
            internalItems[currentIndex] = item;
            currentIndex++;
        }
        /// <summary>
        /// removes a given time from a deck
        /// </summary>
        /// <param name="item">T</param>
        public void Remove(T item)
        {
            int j = 0;
            bool shouldCut = false;
            for (int i = 0; i < internalItems.Length - 1; i++)
            {
                if (item.Equals(internalItems[i]))
                {
                    j++;
                    shouldCut = true;
                }
                internalItems[i] = internalItems[j];
                j++;
                if (j == internalItems.Length)
                {
                    i = internalItems.Length - 1;

                }
            }
            if (shouldCut)
            {
            Array.Resize(ref internalItems, internalItems.Length - 1);
                currentIndex--;
            }
        } 


        
        /// <summary>
        /// Counts item in a deck;
        /// </summary>
        /// <returns>int</returns>
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


