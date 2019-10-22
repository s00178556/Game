using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExample
{
    public class Player : IComparable
    {
        // 3 PROPERTIES CREATED and ID is set to READONLY (no set;)
        public int ID { get; }
        public string PlayerName { get; set; }
        
        //private set; can only be accesed by the method
        public int Score { get; private set; }

        public static int HighScore { get; private set; }

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

            //check for high score
            if (Score > HighScore)
                HighScore = Score;
        }

        public override string ToString()
        {
            return $"{ID}\t{PlayerName}\t{Score}"; // \t is spacing
        }

        public int CompareTo(object obj)
        {
            //get a reference to the next object in the list/array/collection
            Player objectThatIAmComparingTo = obj as Player; // now we have something to compare the object with

            //indicate what field i want to compare
            int returnValue = this.Score.CompareTo(objectThatIAmComparingTo.Score);

            //return
            return returnValue;
        }
    }
}
