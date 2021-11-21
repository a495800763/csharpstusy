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
           //Only  play if palyers exist
           if(players==null)
            {
                return -1;
            }
            //Deal initial hands
            DealHands();

            //Initialize game vars,including an initial card to place on the table: palycard
            bool gameWon = false;
            int currentPlayer;
            Card playCard = playDeck.GetCard(currentCard++);
            discardedCards.Add(playCard);

            //Main game loop. continues until GameWon = true
            do
            {
                //Loop through players in each game round.
                for (currentPlayer = 0; currentPlayer < players.Length; currentPlayer++)
                {
                    //write out current player,player hand,and the card on the table 
                    Console.WriteLine($"{players[currentPlayer].Name}'s turn.");
                    Console.WriteLine("Current hand:");
                    foreach(Card card in players[currentPlayer].playHand)
                    {
                        Console.WriteLine(card);
                    }
                    Console.WriteLine($"Card in play :{playCard}");
                    //prompt player to pick up card on table or draw a new one.
                    bool inputOk = false;
                    do
                    {
                        Console.WriteLine("Press T to take card in play or D to draw.");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "t")
                        {
                            //Add card from table to player hand
                            Console.WriteLine($"Drawn :{playCard}");
                            //Remove from discarded cards if possible (if deck is reshuffled it won't be there any more)
                            if (discardedCards.Contains(playCard))
                            {
                                discardedCards.Remove(playCard);
                            }
                            players[currentPlayer].playHand.Add(playCard);
                            inputOk = true;
                        }
                        if (input.ToLower() == "d")
                        {
                            //Add new card from deck to player hand.
                            Card newCard;
                            //Only add card if it isn't already in a player hand or in the discard pile
                            bool cardIsAvailable;
                            do
                            {
                                newCard = playDeck.GetCard(currentPlayer++);
                                //Check if card is in discard pile
                                cardIsAvailable = !discardedCards.Contains(newCard);
                                if (cardIsAvailable)
                                {
                                    //Loop through all player hands to see if newCard is already in hand.
                                    foreach(Player testPlay in players)
                                    {
                                        if (testPlay.playHand.Contains(newCard))
                                        {
                                            cardIsAvailable = false;
                                            break;
                                        }
                                    }
                                }
                            } while (!cardIsAvailable);
                            //Add the card found to player hand.
                            Console.WriteLine($"Drawn:{newCard}.");
                            players[currentPlayer].playHand.Add(newCard);
                            inputOk = true;
                        }
                    } while (!inputOk);
                    //Display new hand with cards numbered.
                    Console.WriteLine("New hands :");
                    for(int i = 0; i < players[currentPlayer].playHand.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {players[currentPlayer].playHand[i]}");
                    }
                    //Prompt player for a card to discard
                    inputOk = false;
                    int choice = -1;
                    do
                    {
                        Console.WriteLine("Choose card to discard:");
                        string input = Console.ReadLine();
                        try
                        {
                            //Attempt to convert input into a valid card number.
                            choice = Convert.ToInt32(input);
                            if (choice > 0 && choice <= 8)
                            {
                                inputOk = true;
                            }
                        }
                        catch
                        {
                            //Ignore failed conversions. just continue prompting.
                        }
                    } while (!inputOk);
                    /*Place reference to removed card in playCard (place the card on the table).
                     * then remove card from player hand andadd to discard card pile
                     */
                    playCard = players[currentPlayer].playHand[choice - 1];
                    players[currentPlayer].playHand.RemoveAt(choice - 1);
                    discardedCards.Add(playCard);
                    Console.WriteLine($"Discarding : {playCard}");
                    //Space out text for players
                    Console.WriteLine();
                    //Check to see if player has won the game, and exit the player loop if so .
                    gameWon = players[currentPlayer].HasWon();
                    if (gameWon)
                    {
                        break;
                    }
                }

            } while (!gameWon);
            //End game, noting the winning player.
            return currentPlayer;
        }

    }
}
