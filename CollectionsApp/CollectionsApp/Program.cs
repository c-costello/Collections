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
            Card cardFour = new Card('4', Card.Suit.Clubs);
            Card cardFive = new Card('5', Card.Suit.Clubs);
            Card cardSix = new Card('6', Card.Suit.Clubs);
            Card cardSeven = new Card('7', Card.Suit.Clubs);
            deck.Add(cardOne);
            deck.Add(cardTwo);
            deck.Add(cardThree);
            foreach (Card card in deck)
            {
                Console.WriteLine(card.Value);
            }
            deck.Remove(cardTwo);

            foreach (Card card in deck)
            {
                Console.WriteLine(card.Value);
            }

            deck.Add(cardFour);
            deck.Add(cardFive);
            deck.Add(cardSix);
            deck.Add(cardSeven);

            foreach (Card card in deck)
            {
                Console.WriteLine(card.Value);
            }

            deck.Remove(cardFive);

            foreach (Card card in deck)
            {
                Console.WriteLine(card.Value);
            }
        }
    }
}
