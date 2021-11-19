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
    }
}