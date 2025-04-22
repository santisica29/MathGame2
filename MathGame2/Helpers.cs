namespace MathGame2
{
    internal class Helpers
    {
        static List<string> games = new();
        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-------------------------");
            if (games.Count == 0)
            {
                Console.WriteLine("There are no previous games");
            }
            else
            {
                foreach (var game in games)
                {
                    Console.WriteLine(game);
                }
            }
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }
        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();
            return name;
        }
        internal static void AddToHistory(int score, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score = {score}");
        }
        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();

            var result = new int[2];
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
    }
}
