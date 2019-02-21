using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codeproject.com/Articles/8199/Poker-logic-in-C

namespace Holdem
{
    class PokerHand
    {
        private Deck deck;
        private Card[] hand;

        public PokerHand(Deck deck)
        {
            this.deck = deck;
            this.hand = new Card[9];
        }

        public void pullCards()
        {
            for (int i = 0; i < 9; ++i)
                hand[i] = deck.pullCard();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Card c in hand)
            {
                sb.Append(c);
                sb.Append(", ");
            }
            return sb.ToString();
        }

        public Card this[int index]
        {
            get
            {
                return hand[index];
            }
        }
        public void Sort()
        {
            Array.Sort(hand);
        }
    }
}
