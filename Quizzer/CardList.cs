using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    class CardList
    {
        List<Card> cards;
        int next;

        public CardList()
        {
            cards = new List<Card>();
            next = 0;
        }

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public Card GetNext()
        {
            Card c = cards[next];
            next++;
            return c;
        }

        // TODO: Return actual random card
        public Card GetNextRandom()
        {
            return GetNext();
        }

        public void Reset()
        {
            next = 0;
        }
    }
}
