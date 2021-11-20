using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
    public class Deck :ICloneable
    {

        //事件:最后一张牌被选了
        public event EventHandler LastCardDrawn; 

        private Cards cards = new Cards();

        public Deck()
        {
            for(int suitVal = 0; suitVal < 4; suitVal++)
            {
                for(int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        /// <summary>
        /// 非默认构造函数，允许将A牌设置成跟高级别的
        /// </summary>
        /// <param name="isAceHigh"></param>
        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        public Deck (bool useTrumps,Suit trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public object Clone()
        {
            //throw new NotImplementedException();
            Deck newDeck = new Deck(cards.Clone() as Cards);
            return newDeck;
        }

        private Deck(Cards newCard)
        {
            cards = newCard;
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                if ((cardNum == 51) && (LastCardDrawn != null))
                {
                    //当cardNum 为最后一张牌，且有监听程序注册到事件时，触发“最后一张牌被选了”这一事件
                    LastCardDrawn(this, EventArgs.Empty);
                }
                return cards[cardNum];
            }
            else
            {
                //throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value nust be between 0 and 51."));
                throw new CardOutOfRangeException(cards.Clone() as Cards);
            }
        }

        //洗牌方法
        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for(int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (!foundCard)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                    {
                        foundCard = true;
                    }
                }

                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }

            newDeck.CopyTo(cards);
        }


    }
}