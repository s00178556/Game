using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExample
{
    public class Player
    {
        // 3 PROPERTIES CREATED
        public int ID { get; }
        public string PlayerName { get; set; }
        public int Score { get; set; }

        //CONSTRUCTOR CREATED FOR THE PLAYER CLASS
        public Player(int id, string playerName, int score)
        {

            ID = id;
            PlayerName = playerName;
            Score = score;
        }

    }
}
