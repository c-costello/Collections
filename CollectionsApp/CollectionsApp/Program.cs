using System;

namespace CollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Card CardDA = new Card("A", Card.Suit.Diamonds);
            Card CardD2 = new Card("2", Card.Suit.Diamonds);
            Card CardD3 = new Card("3", Card.Suit.Diamonds);

            //Console.WriteLine("Creating Deck...");
            //Deck<Card> dealerDeck = CreateDeck();
            //Deck<Card> playerOneDeck = new Deck<Card>();
            //Deck<Card> playerTwoDeck = new Deck<Card>();
            //Console.WriteLine("Dealing....");
            //Deal(dealerDeck, playerOneDeck, playerTwoDeck);
            Deck<Card> deck = new Deck<Card>();
            Card cardOne = new Card("Q", Card.Suit.Diamonds);
            Card cardToBeRemoved = new Card("J", Card.Suit.Hearts);
            Card cardThree = new Card("5", Card.Suit.Clubs);
            deck.Add(cardOne);
            deck.Add(cardThree);
            Print(deck);
            deck.Remove(cardToBeRemoved);
            Print(deck);


        }
        public static Deck<Card> CreateDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            string[] vals = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            foreach (string value in vals)
            {
                deck.Add(new Card(value, Card.Suit.Clubs));
                Console.WriteLine($"Added Card: {value} {Card.Suit.Clubs} to deck.");
                deck.Add(new Card(value, Card.Suit.Diamonds));
                Console.WriteLine($"Added Card: {value} {Card.Suit.Diamonds} to deck.");
                deck.Add(new Card(value, Card.Suit.Hearts));
                Console.WriteLine($"Added Card: {value} {Card.Suit.Hearts} to deck.");
                deck.Add(new Card(value, Card.Suit.Spades));
                Console.WriteLine($"Added Card: {value} {Card.Suit.Spades} to deck.");
            }
            return deck;
        }

        public static void Deal(Deck<Card> dealerDeck, Deck<Card> playerOneDeck, Deck<Card> playerTwoDeck)
        {

            string whosTurn = "p1";
            
            int dLength = dealerDeck.internalItems.Length;
            int cardsLeft = dLength;
            if (dLength % 2 == 1)
            {
                dLength = dLength - 1;
            }
            Console.WriteLine($"Cards Left: {cardsLeft}");
            for(int i = 0; i < dLength; i++) 
            {
                cardsLeft--;
                Console.WriteLine($"Dealing {dealerDeck.internalItems[0].Value} {dealerDeck.internalItems[0].CardSuit} to {whosTurn}");
                Console.WriteLine($"Cards Left: {cardsLeft}");
                Console.WriteLine();
                

                if (whosTurn == "p1")
                {
                    playerOneDeck.Add(dealerDeck.internalItems[0]);
                    whosTurn = "p2";
                }
                else if (whosTurn == "p2")
                {
                    playerTwoDeck.Add(dealerDeck.internalItems[0]);
                    whosTurn = "p1";
                }
                dealerDeck.Remove(dealerDeck.internalItems[0]);
            }
            Console.WriteLine("Hands: ");    
            Console.WriteLine("PlayerOne");
            Print(playerOneDeck);
            Console.WriteLine("PlayerTwo");
            Print(playerTwoDeck);
            Console.WriteLine("Dealer");
            Print(dealerDeck);
        }
        static void Print(Deck<Card> deck)
        {
            foreach (Card card in deck)
            {
                Console.Write($"{card.Value} {card.CardSuit} ");
            }
            Console.WriteLine();
        }
    }
}
