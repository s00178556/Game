using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExample
{
    public class Player
    {
        // 3 PROPERTIES CREATED and ID is set to READONLY (no set;)
        public int ID { get; }
        public string PlayerName { get; set; }
        
        //private set; can only be accesed by the method
        public int Score { get; private set; }

        //CONSTRUCTOR CREATED FOR THE PLAYER CLASS - call lower case to distinguish
        public Player(int id, string playerName, int score)
        {

            ID = id;
            PlayerName = playerName;
            Score = score;
        }

        //ADD THE METHOD TO INCREASE SCORE

        public void IncreaseScore(int valueToAdd)
        {
            if(Score < 100) //wasnt nescessary just example
            Score += valueToAdd;
        }

    }
}
