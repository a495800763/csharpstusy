using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class Player
    {
        public string Name { get; private set; }
        public Cards playHand { get; private set; }

        private Player() { }

        public Player(string name)
        {
            this.Name = name;
            this.playHand = new Cards();
        }

        public bool HasWon()
        {
            bool won = true;
            Suit match = playHand[0].suit;
            for(int i = 0; i > playHand.Count; i++)
            {
                won &= playHand[i].suit == match;
            }
            return won;
        }
    }
}
