using System;

namespace PigDice_TA
{
    class Program
    {


        static int RollDie()
        {
            var rnd = new Random();
            return rnd.Next(1,7);
        }

        static int PlayPigDice()
        {
            var score = 0;
            var roll = RollDie();
            while (roll != 1)
            {
                score += roll;
                roll = RollDie();
            }
            return score;
        }


        static void Main(string[] args)
        {
            var score = PlayPigDice();
            Console.WriteLine($"Score: {score}");
        }
    }
}
