using System;
using System.Collections.Generic;

namespace DeckOfCards
{
  public class Player
  {
      public string name;
      public List<Card> hand;
      public Player(string name) // player constructor
      {
          this.name = name;
          this.hand = new List<Card>();
      }
      public Card drawCard(Deck deck)
      {
          Card drawnCard = deck.dealTopCard();
          hand.Add(drawnCard);
          Console.WriteLine($"Drawn card {drawnCard.stringVal} of {drawnCard.suit}");
          return drawnCard;
      }
      public Card discardCard(int cardIdx)
      {
          if (cardIdx > hand.Count)
          {
              Console.WriteLine  ("Sorry! No card at that specified index. Cannot discard.");
              return null;
          }
          else
          {
              Card discardedCard = hand[cardIdx];
              Console.WriteLine($"Discarded Card {discardedCard.stringVal} of {discardedCard.suit}");
              hand.RemoveAt(cardIdx);
              return discardedCard;
          }
      }
      public void showHand()
      {
          Console.WriteLine("Hand:");
          foreach (Card card in hand)
          {
              Console.WriteLine($"{card.stringVal} of {card.suit}");
          }
      }
    }

}