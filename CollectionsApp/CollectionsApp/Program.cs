using System;

namespace CollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck<Card> deck = new Deck<Card>();
            Card cardOne = new Card('1', Card.Suit.Clubs);
            Card cardTwo = new Card('2', Card.Suit.Clubs);
            Card cardThree = new Card('3', Card.Suit.Clubs);
            deck.Add(cardOne);
            deck.Add(cardTwo);
            deck.Add(cardThree);
            foreach (Card card in deck)
            {
                Console.WriteLine(card.Value);
            }

        }
    }
}
