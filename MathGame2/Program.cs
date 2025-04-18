Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.Now;

Menu(name, date);

void QuitGame()
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
void AdditionGame(string message)
{
    Console.WriteLine(message);
}
void SubstractionGame(string message)
{
    Console.WriteLine(message);
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}
void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void Menu(string? name, DateTime date)
{
    Console.WriteLine("-----------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is your math's game. Let's get started.\n");
    Console.WriteLine($@"What game would you like to play today?:
A - Addition
S - Substraction
M - Multiplication
D - Division
Q - Quit
");
    Console.WriteLine("---------------------------");

    var userGameSelected = Console.ReadLine().Trim().ToLower();

    switch (userGameSelected)
    {
        case "a":
            AdditionGame("Addition selected");
            break;
        case "s":
            SubstractionGame("Substraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            QuitGame();
            break;
        default:
            Console.WriteLine($"Incorrect input: {userGameSelected}");
            break;
    }
}