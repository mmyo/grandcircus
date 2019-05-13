using System;

namespace classnotes0509
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Make a move: 0-Rock, 1-Paper, 2-Scissors");
            var response = Console.ReadLine();

            //var move = int.Parse(response);

            var move = Enum.Parse<Move>(response);

            Turn(move);

            switch (move)
            {
                case Move.Rock:
                    break;
                case Move.Paper:
                    break;
                case Move.Scissor:
                    break;
                default:
                    break;
            }


            Console.ReadLine();
        }

        public static void Turn(Move move)
        {
            if (move == Move.Paper)
            {
                Console.WriteLine("paper!");

            }
        }
    }
}
