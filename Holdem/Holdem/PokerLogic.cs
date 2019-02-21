﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codeproject.com/Articles/8199/Poker-logic-in-C

namespace Holdem
{
    class PokerLogic
    {
        // flush is when all of the suits are the same
        private static bool isFlush(PokerHand h)
        {
            if (h[0].suit == h[1].suit &&
                h[1].suit == h[2].suit &&
                h[2].suit == h[3].suit &&
                h[3].suit == h[4].suit)
                return true;
            return false;
        }

        // make sure the rank differs by one
        // we can do this since the Hand is 
        // sorted by this point
        private static bool isStraight(PokerHand h)
        {
            if (h[0].rank == h[1].rank - 1 &&
                h[1].rank == h[2].rank - 1 &&
                h[2].rank == h[3].rank - 1 &&
                h[3].rank == h[4].rank - 1)
                return true;
            // special case cause ace ranks lower
            // than 10 or higher
            if (h[1].rank == RANK.Ten &&
                h[2].rank == RANK.Jack &&
                h[3].rank == RANK.Queen &&
                h[4].rank == RANK.King &&
                h[0].rank == RANK.Ace)
                return true;
            return false;
        }

        // must be flush and straight and
        // be certain cards. No wonder I have
        private static bool isRoyalFlush(PokerHand h)
        {
            if (isStraight(h) && isFlush(h) &&
                  h[0].rank == RANK.Ace &&
                  h[1].rank == RANK.Ten &&
                  h[2].rank == RANK.Jack &&
                  h[3].rank == RANK.Queen &&
                  h[4].rank == RANK.King)
                return true;
            return false;
        }

        private static bool isStraightFlush(PokerHand h)
        {
            if (isStraight(h) && isFlush(h))
                return true;
            return false;
        }

        /*
	     * Two choices here, the first four cards
	     * must match in rank, or the second four
	     * must match in rank. Only because the hand
	     * is sorted
	     */
        private static bool isFourOfAKind(PokerHand h)
        {
            if (h[0].rank == h[1].rank &&
                h[1].rank == h[2].rank &&
                h[2].rank == h[3].rank)
                return true;
            if (h[1].rank == h[2].rank &&
                h[2].rank == h[3].rank &&
                h[3].rank == h[4].rank)
                return true;
            return false;
        }

        /*
	     * two choices here, the pair is in the
	     * front of the hand or in the back of the
	     * hand, because it is sorted
	     */
        private static bool isFullHouse(PokerHand h)
        {
            if (h[0].rank == h[1].rank &&
                h[2].rank == h[3].rank &&
                h[3].rank == h[4].rank)
                return true;
            if (h[0].rank == h[1].rank &&
                h[1].rank == h[2].rank &&
                h[3].rank == h[4].rank)
                return true;
            return false;
        }

        /*
	     * three choices here, first three cards match
	     * middle three cards match or last three cards
	     * match
	     */
        private static bool isThreeOfAKind(PokerHand h)
        {
            if (h[0].rank == h[1].rank &&
                h[1].rank == h[2].rank)
                return true;
            if (h[1].rank == h[2].rank &&
                h[2].rank == h[3].rank)
                return true;
            if (h[2].rank == h[3].rank &&
                h[3].rank == h[4].rank)
                return true;
            return false;
        }

        /*
	     * three choices, two pair in the front,
	     * separated by a single card or
	     * two pair in the back
	     */
        private static bool isTwoPair(PokerHand h)
        {
            if (h[0].rank == h[1].rank &&
                h[2].rank == h[3].rank)
                return true;
            if (h[0].rank == h[1].rank &&
                h[3].rank == h[4].rank)
                return true;
            if (h[1].rank == h[2].rank &&
                h[3].rank == h[4].rank)
                return true;
            return false;
        }

        /*
	     * 4 choices here
	     */
        private static bool isJacksOrBetter(PokerHand h)
        {
            if (h[0].rank == h[1].rank &&
                h[0].isJacksOrBetter())
                return true;
            if (h[1].rank == h[2].rank &&
                h[1].isJacksOrBetter())
                return true;
            if (h[2].rank == h[3].rank &&
                h[2].isJacksOrBetter())
                return true;
            if (h[3].rank == h[4].rank &&
                h[3].isJacksOrBetter())
                return true;
            return false;
        }

        // must be in order of hands and must be
        // mutually exclusive choices
        public static POKERSCORE score(PokerHand h)
        {
            if (isRoyalFlush(h))
                return POKERSCORE.RoyalFlush;
            else if (isStraightFlush(h))
                return POKERSCORE.StraightFlush;
            else if (isFourOfAKind(h))
                return POKERSCORE.FourOfAKind;
            else if (isFullHouse(h))
                return POKERSCORE.FullHouse;
            else if (isFlush(h))
                return POKERSCORE.Flush;
            else if (isStraight(h))
                return POKERSCORE.Straight;
            else if (isThreeOfAKind(h))
                return POKERSCORE.ThreeOfAKind;
            else if (isTwoPair(h))
                return POKERSCORE.TwoPair;
            else if (isJacksOrBetter(h))
                return POKERSCORE.JacksOrBetter;
            else
                return POKERSCORE.None;
        }
    }
}
