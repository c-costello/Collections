using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsApp
{
    public class Card
    {
        public char Value { get; set; }
        public Suit CardSuit { get; set; }

        public enum Suit { Hearts, Spades, Clubs, Diamonds}


        public Card (string value, Suit suit)
        {
            CardSuit = suit;
            Value = value;
        }
        
    }
}
