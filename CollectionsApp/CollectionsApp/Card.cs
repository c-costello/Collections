using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsApp
{
    public class Card
    {
        public string Value { get; set; }
        public Suit CardSuit { get; set; }

        public enum Suit { Hearts, Spades, Clubs, Diamonds}

        /// <summary>
        /// Card Constructor
        /// </summary>
        /// <param name="value">string</param>
        /// <param name="suit">Suit</param>
        public Card (string value, Suit suit)
        {
            CardSuit = suit;
            Value = value;
        }
        
    }
}
