using System;

namespace CollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deck<Card> deck = new Deck<Card>();
            //Card CardDA = new Card("A", Card.Suit.Diamonds);
            //Card CardD2 = new Card("2", Card.Suit.Diamonds);
            //Card CardD3 = new Card("3", Card.Suit.Diamonds);
            Deck<Card> createdDeck = CreateDeck();
            Deck<Card> dealerDeck = CreateDeck();
            Deck<Card> playerOneDeck = new Deck<Card>();
            Deck<Card> playerTwoDeck = new Deck<Card>();
            Deal(dealerDeck, playerOneDeck, playerTwoDeck);

        }
        public static Deck<Card> CreateDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            Card CardDA = new Card("A", Card.Suit.Diamonds);
            Card CardD2 = new Card("2", Card.Suit.Diamonds);
            Card CardD3 = new Card("3", Card.Suit.Diamonds);
            Card CardD4 = new Card("4", Card.Suit.Diamonds);
            Card CardD5 = new Card("5", Card.Suit.Diamonds);
            Card CardD6 = new Card("6", Card.Suit.Diamonds);
            Card CardD7 = new Card("7", Card.Suit.Diamonds);
            Card CardD8 = new Card("8", Card.Suit.Diamonds);
            Card CardD9 = new Card("9", Card.Suit.Diamonds);
            Card CardD10 = new Card("10", Card.Suit.Diamonds);
            Card CardDJ = new Card("J", Card.Suit.Diamonds);
            Card CardDQ = new Card("Q", Card.Suit.Diamonds);
            Card CardDK = new Card("K", Card.Suit.Diamonds);

            deck.Add(CardDA);
            deck.Add(CardD2);
            deck.Add(CardD3);
            deck.Add(CardD4);
            deck.Add(CardD5);
            deck.Add(CardD6);
            deck.Add(CardD7);
            deck.Add(CardD8);
            deck.Add(CardD9);
            deck.Add(CardD10);
            deck.Add(CardDJ);
            deck.Add(CardDQ);
            deck.Add(CardDK);
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
