using System;
using System.Collections.Generic;

namespace Quizzer
{
    class CardList
    {
        public List<Card> Cards { get; private set; }
        int current;
        bool lastPrev;
        Random rand = new Random();

        public CardList()
        {
            Cards = new List<Card>();
            current = 0;
            lastPrev = false;
        }

        public void Add(Card card)
        {
            Cards.Add(card);
        }

        public Card GetNext()
        {
            Card c = Cards[current];
            if (current < Cards.Count - 1) current++;
            lastPrev = false;
            return c;
        }

        public Card GetPrev()
        {
            // If the last "get" was a previous, go back one more index
            // to place current at the current card which was the previous.
            if (lastPrev) current--;
            current--;
            Card c = GetNext();
            lastPrev = true;
            return c;
        }

        // TODO: Return actual random card
        public Card GetNextRandom()
        {
            int i = rand.Next() % Cards.Count;
            return Cards[i];
        }

        public bool IsStart(Card card)
        {
            return (Cards.IndexOf(card) == 0);
        }

        public bool IsLast(Card card)
        {
            return (Cards.IndexOf(card) == Cards.Count-1);
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
