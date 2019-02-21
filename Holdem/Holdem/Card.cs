using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum SUIT { None, Diamonds, Hearts, Clubs, Spades }
enum RANK
{
    None, Ace, Two, Three, Four, Five, Six, Seven, Eight,
    Nine, Ten, Jack, Queen, King
}
enum POKERSCORE
{
    None, JacksOrBetter, TwoPair, ThreeOfAKind,
    Straight, Flush, FullHouse, FourOfAKind, StraightFlush,
    RoyalFlush
}


namespace Holdem
{
    class Card : IComparable
    {
        private RANK _rank;
        private SUIT _suit;

        // IComparable interface method
        public int CompareTo(object o)
        {
            if (o is Card)
            {
                Card c = (Card)o;
                if (_rank < c.rank)
                    return -1;
                else if (_rank > c.rank)
                    return 1;
                return 0;
            }
            throw new ArgumentException("Object is not a Card");
        }

        public Card(RANK rank, SUIT suit)
        {
            this._rank = rank;
            this._suit = suit;
        }

        public Card() : this(RANK.None, SUIT.None)
        {

        }

        public override string ToString()
        {
            return this._rank.ToString() + "_" + this._suit.ToString();
        }

        public RANK rank
        {
            get { return _rank; }
        }

        public SUIT suit
        {
            get { return _suit; }
        }

        public bool isJacksOrBetter()
        {
            if (_rank == RANK.Ace)
                return true;
            if (_rank >= RANK.Jack)
                return true;
            return false;
        }
    }
}
