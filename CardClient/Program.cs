using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            TestException();
            Console.ReadKey();
        }

        public static void Function1()
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString());
                if (i != 51)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();

        }

        public  static void Function2()
        {
            Deck deck1 = new Deck();
            Deck deck2 = (Deck)deck1.Clone();

            Console.WriteLine($"The first card in the original deck is : {deck1.GetCard(0)}");
            Console.WriteLine($"The first card in the cloned deck is : {deck2.GetCard(0)}");
            deck1.Shuffle();
            Console.WriteLine("The original deck shuffled.");
            Console.WriteLine($"The first card in the original deck is : {deck1.GetCard(0)}");
            Console.WriteLine($"The first card in the cloned deck is : {deck2.GetCard(0)}");
        }

        public static void CompareCards()
        {
            Card.isAceHigh = true;
            Console.WriteLine("Aces are high.");
            Card.useTrumps = true;
            Card.trump = Suit.Club;
            Console.WriteLine("Clubs are trumps.");

            Card card1, card2, card3, card4, card5;
            card1 = new Card(Suit.Club, Rank.Five);
            card2 = new Card(Suit.Club, Rank.Five);
            card3 = new Card(Suit.Club, Rank.Ace);
            card4 = new Card(Suit.Heart, Rank.Ten);
            card5 = new Card(Suit.Diamond, Rank.Ace);
            Console.WriteLine($"{card1.ToString()} == {card2.ToString()} ? {card1 == card2}");
            Console.WriteLine($"{card1.ToString()} != {card3.ToString()} ? {card1 != card3}");
            Console.WriteLine($"{card1.ToString()}.Equals({card4.ToString()}) ? {card1.Equals(card4)}");
            Console.WriteLine($"Card.Equals({card3.ToString()},{card4.ToString()}) ? {Card.Equals(card3,card4)}");

            Console.WriteLine($"{card1.ToString()} > {card2.ToString()} ? {card1 > card2}");
            Console.WriteLine($"{card1.ToString()} <= {card3.ToString()} ? {card1 <= card3}");
            Console.WriteLine($"{card1.ToString()} > {card4.ToString()} ? {card1 > card4}");
            Console.WriteLine($"{card4.ToString()} > {card1.ToString()} ? {card4 > card1}");
            Console.WriteLine($"{card5.ToString()} > {card4.ToString()} ? {card5 > card4}");
            Console.WriteLine($"{card4.ToString()} > {card5.ToString()} ? {card4 > card5}");

            Console.ReadKey();
        }

        public static void TestException()
        {
            Deck deck1 = new Deck();
            try
            {
                Card myCard = deck1.GetCard(60);
            }
            catch(CardOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.DeckContents[0]);
            }
        }

        public void PlayCardMainFunction()
        {
            //Display introduction.
            Console.WriteLine("Liumengqi: a new and exciting card game.");
            Console.WriteLine("To win you must have 7 cards of same suit in your hands.");
            Console.WriteLine();
            //Prompt for number of players
            bool inputOK = false;
            int choice = 1;
            do
            {
                Console.WriteLine("How many players (2-7)?");
                string input = Console.ReadLine();
                try
                {
                    //Attempt to convert input into a valid number of players.
                    choice = Convert.ToInt32(input);
                    if ((choice >= 2) && (choice <= 7))
                    {
                        inputOK = true;
                    }
                }
                catch
                {
                    //Ignore failed conversions,just continue prompting.
                }
            } while (!inputOK);

            //Initialize array of player objects
            Player[] players = new Player[choice];
            //Get player names.
            for(int p = 0; p < choice; p++)
            {
                Console.WriteLine($"Player {p + 1},enter your name: ");
                string playerName = Console.ReadLine();
                players[p] = new Player(playerName);
            }

            //start game
            Game newGame = new Game();
            newGame.SetPlayers(players);
            int whoWon = newGame.PlayGame();
            //Display winning player
            Console.WriteLine($"{players[whoWon].Name} has won the game.");

        }
    }
}
