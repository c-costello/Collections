using System;

namespace CollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Creating Deck...");
            Deck<Card> dealerDeck = CreateDeck();
            Deck<Card> playerOneDeck = new Deck<Card>();
            Deck<Card> playerTwoDeck = new Deck<Card>();
            Console.WriteLine("Dealing....");
            Deal(dealerDeck, playerOneDeck, playerTwoDeck);



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

        /// <summary>
        /// Deals cards to players, while removing them from the dealer's deck
        /// </summary>
        /// <param name="dealerDeck">Deck</param>
        /// <param name="playerOneDeck">Deck</param>
        /// <param name="playerTwoDeck">Deck</param>
        public static void Deal(Deck<Card> dealerDeck, Deck<Card> playerOneDeck, Deck<Card> playerTwoDeck)
        {

            string whosTurn = "p1";
            
            int dLength = dealerDeck.internalItems.Length;
            int cardsLeft = dLength;
            bool donotprint = true;
            if (dLength % 2 == 1)
            {
                dLength = dLength - 1;
                donotprint = false;
                
            }
            Console.WriteLine($"Cards Left: {cardsLeft}");
            for(int i = 0; i < dLength; i++) 
            {
                Console.WriteLine();
                cardsLeft--;
                Console.WriteLine($"Dealing {dealerDeck.internalItems[0].Value} {dealerDeck.internalItems[0].CardSuit} to {whosTurn}");
                           

                if (whosTurn == "p1")
                {
                    playerOneDeck.Add(dealerDeck.internalItems[0]);
                    whosTurn = "p2";
                    Console.WriteLine("PlayerOne Deck:");
                    Print(playerOneDeck);
                }
                else if (whosTurn == "p2")
                {
                    playerTwoDeck.Add(dealerDeck.internalItems[0]);
                    whosTurn = "p1";
                    Console.WriteLine("PlayerTwo Deck:");
                    Print(playerTwoDeck);
                }
                dealerDeck.Remove(dealerDeck.internalItems[0]);

   
                Console.WriteLine("Dealer Deck:");
                if (donotprint && cardsLeft == 0)
                {
                    Console.WriteLine("Dealer has no card left");
                }
                else
                {
                    Print(dealerDeck);
                }
                Console.WriteLine($"Cards Left: {cardsLeft}");
            }
        }
        /// <summary>
        /// Prints each card's value and suit in a deck
        /// </summary>
        /// <param name="deck"></param>
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
