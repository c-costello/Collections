using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsApp
{
    public class Card
    {
        public char Value { get; set; }
        public Suit WhichSuit { get; set; }

        public enum Suit { Hearts, Spades, Clubs, Diamonds}

        public Card (char value, Suit suit)
        {
            WhichSuit = suit;
            Value = value;
        }
        
    }
}
