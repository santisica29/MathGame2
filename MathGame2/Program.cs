using static System.Formats.Asn1.AsnWriter;
using System.Globalization;

var date = DateTime.Now;
var random = new Random();

var games = new List<string>();

string name = GetName();

Menu(name);

void Menu(string name)
{
    Console.WriteLine("-----------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is your math's game. Let's get started.\n");
    Console.ReadLine();

    bool isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine($@"What game would you like to play today?:
                V - View Previous Games
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
            case "v":
                GetGames();
                break;
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

void GetGames()
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

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    int firstNumber;
    int secondNumber;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = int.Parse(Console.ReadLine());

        if (result == (firstNumber + secondNumber))
        {
            Console.WriteLine("Your answer was correct");
            score++;
        }
        else
        {
            Console.WriteLine("You are wrong");
        }
        Console.ReadLine();
    }
    AddToHistory(score, "Addition");
    Console.WriteLine($"Game over. Final score: {score}");
    Console.ReadLine();
}

void AddToHistory(int score, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: Score = {score}");
}

void SubstractionGame(string message)
{
    Console.WriteLine(message);

    int firstNumber;
    int secondNumber;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = int.Parse(Console.ReadLine());

        if (result == (firstNumber - secondNumber))
        {
            Console.WriteLine("Your answer was correct");
            score++;
        }
        else
        {
            Console.WriteLine("You are wrong");
        }
        Console.ReadLine();
    }
    AddToHistory(score, "Substraction");
    Console.WriteLine($"Game over. Final score: {score}");
    Console.ReadLine();
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    int firstNumber;
    int secondNumber;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = int.Parse(Console.ReadLine());

        if (result == (firstNumber * secondNumber))
        {
            Console.WriteLine("Your answer was correct");
            score++;
        }
        else
        {
            Console.WriteLine("You are wrong");
        }
        Console.ReadLine();
    }
    AddToHistory(score, "Multiplication");

    Console.WriteLine($"Game over. Final score: {score}");
    Console.ReadLine();
}
void DivisionGame(string message)
{
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        var divisionNumbers = GetDivisionNumbers();

        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];


        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = int.Parse(Console.ReadLine());

        if (result == (firstNumber / secondNumber))
        {
            Console.WriteLine("Your answer was correct");
            score++;
        }
        else
        {
            Console.WriteLine("You are wrong");
        }
        Console.ReadLine();
    }
    AddToHistory(score, "Division");

    Console.WriteLine($"Game over. Final score: {score}");
    Console.ReadLine();
}
int[] GetDivisionNumbers()
{
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
