internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to simple Rock-Paper-Scissors game!");
        int wins = 0;
        int losses = 0;
        int rounds = 5;
        int times = 0;
        do
        {
            string status = string.Concat($"You are {wins} and Computer is {losses} \nNow {rounds} rounds left...");
            if (wins == 0 && losses == 0 && times == 0)
            {
                Console.WriteLine("Game just started! Win 3 rounds or LOSE the game!");
            }
            else
            {
                Console.WriteLine(status);
            }
            Console.WriteLine();
            Console.WriteLine("Select one:");
            Console.WriteLine("Press 1 for selecting \"ROCK\"");
            Console.WriteLine("Press 2 for selecting \"PAPER\"");
            Console.WriteLine("Press 3 for selecting \"SCISSORS\"");
            var random = new Random();
            bool correctChoice = false;
            while (!correctChoice)
            {
                var key = Console.ReadKey(true);
                if (key.KeyChar == '1' || key.KeyChar == '2' || key.KeyChar == '3')
                {
                    int selectedNumber = int.Parse(key.KeyChar.ToString());
                    int test = random.Next(1, 4);
                    int result = Math.Abs(selectedNumber - test);
                    Console.WriteLine();
                    if (result == 0)
                    {
                        Console.WriteLine("It's a DRAW! Try again..");
                        correctChoice = true;
                    }
                    if (result == 1)
                    {
                        Console.WriteLine("Well done! You got this round...");
                        wins++;
                        correctChoice = true;
                        rounds--;
                    }
                    if (result == 2)
                    {
                        Console.WriteLine("You lost this round...try again!");
                        losses++;
                        correctChoice = true;
                        rounds--;
                    }

                }
            }
            times++;
            if (wins == 3)
            {
                Console.WriteLine();
                Console.WriteLine("3 TIMES!!! YOU WON!");
                Console.WriteLine($"Side note: You win in {times} rounds. Thats nice...");
                break;
            }
            if (losses == 3)
            {
                Console.WriteLine();
                Console.WriteLine("GG! YOU LOST!");
                Console.WriteLine($"Side note: You wasted in {times} rounds. Thats sucks mate...");
                break;
            }
        } while (rounds > 0);
    }
}