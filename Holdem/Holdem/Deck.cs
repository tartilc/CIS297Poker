using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codeproject.com/Articles/8199/Poker-logic-in-C

namespace Holdem
{
    class Deck
    {
        // array of Card of object (the real deck)
        private Card[] d;
        // current card index
        private int cc = 0;
        // shuffle variable
        private Random rand = new Random();

        public Deck()
        {
            init();
        }

        private void init()
        {
            cc = 0;
            d = new Card[52];
            int counter = 0;
            // nice way to initialize the Deck, using
            // builtin functionality of Enum
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
                foreach (RANK r in Enum.GetValues(typeof(RANK)))
                    if (r != RANK.None && s != SUIT.None)
                        d[counter++] = new Card(r, s);
        }

        public Card pullCard()
        {
            return d[cc++];
        }

        public Card peekCard()
        {
            return d[cc];
        }

        private void swapCards(int i, int j)
        {
            Card tmp = d[i];
            d[i] = d[j];
            d[j] = tmp;
        }

        /*
	     * shuffle the deck and reset the current card
	     * index to the beginning
	     */
        public void shuffle(int count)
        {
            cc = 0;
            for (int i = 0; i < count; ++i)
            {
                for (int j = 0; j < 52; ++j)
                {
                    int idx = rand.Next(52);
                    swapCards(j, idx);
                }
            }
        }

        /*
	     * 10 is overkill, 8 should be enough
	     */
        public void shuffle()
        {
            this.shuffle(10);
        }

        public void print()
        {
            foreach (Card c in d)
                Console.WriteLine(c);
        }
    }
}
