using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardLib
{
    public class Card :ICloneable
    {
        public Rank rank;
        public Suit suit;

        private Card()
        {
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString()
        {
            return "The" + rank + "of" + suit + ".";
        }

        public object Clone()
        {
            //throw new NotImplementedException();
            return MemberwiseClone();
        }

        /// <summary>
        /// Flag for trump usage.If true,trumps are valued higher
        /// than cards of other suits
        /// </summary>
        public static bool useTrumps = false;

        /// <summary>
        /// Trump suit to use if useTrumps is true
        /// </summary>
        public static Suit trump = Suit.Club;

        /// <summary>
        /// Flag that datermines whether aces are higher than kings or lower
        /// than deuces
        /// </summary>
        public static bool isAceHigh = true;


        public static bool operator == (Card card1,Card card2)
        {
            return (card1?.suit == card2?.suit) && (card1?.rank == card2?.rank);
        }

        public static bool operator != (Card card1,Card card2)
        {
            return !(card1 == card2);
        }
    }
}