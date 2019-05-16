using System;
using System.Collections.Generic;
using System.Text;

namespace lab13
{
    public class RoshamboApp
    {

        public static void EvaluateWinner(Player player1, Player player2)
        {
            if (player1.Roshambo.Equals(player2.Roshambo))
            {
                Console.WriteLine("tie");
            }
            else if ((player1.Roshambo.Equals(RoshamboEnum.Rock) && player2.Roshambo.Equals(RoshamboEnum.Scissors))
                || (player1.Roshambo.Equals(RoshamboEnum.Paper) && player2.Roshambo.Equals(RoshamboEnum.Rock)))

            {
                Console.WriteLine("p1 wins");

            }
            else if ((player1.Roshambo.Equals(RoshamboEnum.Rock) && player2.Roshambo.Equals(RoshamboEnum.Paper))
                || (player1.Roshambo.Equals(RoshamboEnum.Scissors) && player2.Roshambo.Equals(RoshamboEnum.Rock)))
            {
                Console.WriteLine("p2 wins");

            }
        }

    }
}
