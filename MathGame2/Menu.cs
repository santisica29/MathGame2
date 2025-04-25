namespace MathGame2
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {DateTime.Now}. This is your math's game. Let's get started.\n");
            Console.WriteLine("Press any key to see the menu");
            Console.ReadLine();

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today?:
                V - View Previous Games
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                Q - Quit
                ");
                Console.WriteLine("---------------------------");

                var userGameSelected = Console.ReadLine().Trim().ToLower();

                switch (userGameSelected)
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition selected");
                        break;
                    case "s":
                        gameEngine.SubstractionGame("Subtraction game selected");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game selected");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game selected");
                        break;
                    case "q":
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine($"Incorrect input: {userGameSelected}");
                        Console.ReadLine();
                        break;
                }
            } while (isGameOn);
        }
    }
}
