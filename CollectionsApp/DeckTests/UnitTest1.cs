using CollectionsApp;
using System;
using Xunit;

namespace DeckTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCardToMethod()
        {
            Deck<Card> deck = new Deck<Card>();
            deck.Add(new Card("Q", Card.Suit.Diamonds));


            Assert.Equal(Card.Suit.Diamonds, deck.internalItems[0].CardSuit);
        }
    }
}
