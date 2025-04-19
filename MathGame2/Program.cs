using static System.Formats.Asn1.AsnWriter;

var date = DateTime.Now;
var random = new Random();

string name = GetName();

Menu(name);

void Menu(string name)
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

    Console.WriteLine($"Game over. Final score: {score}");
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

    Console.WriteLine($"Game over. Final score: {score}");

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

    Console.WriteLine($"Game over. Final score: {score}");
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

    Console.WriteLine($"Game over. Final score: {score}");
}
void QuitGame()
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
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
