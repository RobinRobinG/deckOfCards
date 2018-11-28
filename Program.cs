using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.shuffle().displayDeck();
            newDeck.dealTopCard();
            // Console.WriteLine("Hello World!");
        }
    }
}