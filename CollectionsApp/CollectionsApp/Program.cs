using System;

namespace CollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck<Card> deck = new Deck<Card>();
            deck.Add(new Card('1', Card.Suit.Clubs));
            deck.Add(new Card('2', Card.Suit.Clubs));

        }
    }
}
