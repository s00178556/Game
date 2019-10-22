using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExample
{
    class Program
    {
        //5 PLAYERS ARE ADDED TO PROGRAM.CS
        static void Main(string[] args)
        {

            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            //CREATED A LIST TYPE TO OHLD ALL THE PLAYERS

            List<Player> allPlayers = new List<Player>();
            allPlayers.Add(player1);
            allPlayers.Add(player2);
            allPlayers.Add(player3);
            allPlayers.Add(player4);
            allPlayers.Add(player5);

            player1.IncreaseScore(1);
            player2.IncreaseScore(10);

            Display(allPlayers);

      

        }

        //New method to display all the players

        private static void Display(List<Player> players)
        {
            Console.WriteLine("{0, -10}{1, -10}{2, -10}{3, -10}{4, -10}", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5");

            //loop through all players in list and siaply score for each

            foreach (Player player in players)
            {
                Console.Write("{0, -10}", player.Score);
            }
        }

    }
}
