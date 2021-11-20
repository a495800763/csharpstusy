using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class Game
    {
        private int currentCard;
        private Deck playDeck;
        private Player[] players;
        private Cards discardedCards;

        public Game()
        {
            currentCard = 0;
            playDeck = new Deck(true);
            //为deck中的“最后一张牌已经被选”事件注册一个响应
            playDeck.LastCardDrawn += Reshuffle;
            //初次洗牌
            playDeck.Shuffle();
            discardedCards = new Cards();
        }

        /// <summary>
        /// 匹配Deck类中事件所定义的委托的方法，即通过本方法响应事件
        /// </summary>
        private void Reshuffle(object source , EventArgs args)
        {
            Console.WriteLine("Discarded cards reshuffled into deck.");
            //重新洗牌
            ((Deck)source).Shuffle();
            discardedCards.Clear();
            currentCard = 0;
        }

        public void SetPlayers(Player[] newPlayers)
        {
            if (newPlayers.Length > 7)
            {
                throw new ArgumentException("A maximum of 7 players may play this game.");
            }
            if (newPlayers.Length < 2)
            {
                throw new ArgumentException("A minimum of 2 players may play this game.");
            }
            players = newPlayers;
        }

        /// <summary>
        /// 依次给每个玩家发牌
        /// </summary>
        private void DealHands()
        {
            for(int p = 0; p < players.Length; p++)
            {
                for (int c=0; c < 7;c++)
                {
                    players[p].playHand.Add(playDeck.GetCard(currentCard++));
                }
            }
        }


        public int PlayGame()
        {
            //todo
            return 0;
        }

    }
}
