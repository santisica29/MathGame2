using MathGame2.Models;

namespace MathGame2
{
    internal class GameEngine
    {
        internal void PlayGame(GameType gametype, Difficulty difficulty)
        {
            Random random = new Random();

            int firstNumber = 0;
            int secondNumber = 0;
            int calculation = 0;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"{difficulty.ToString().ToUpper()} MODE\n");

                switch (difficulty)
                {
                    case Difficulty.Easy:
                        firstNumber = random.Next(1, 9);
                        secondNumber = random.Next(1, 9);
                        break;
                    case Difficulty.Medium:
                        firstNumber = random.Next(1, 50);
                        secondNumber = random.Next(1, 50);
                        break;
                    case Difficulty.Hard:
                        firstNumber = random.Next(1, 100);
                        secondNumber = random.Next(1, 100);
                        break;
                    default:
                        break;
                }

                switch (gametype)
                {
                    case GameType.Addition:
                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        calculation = firstNumber + secondNumber;
                        break;
                    case GameType.Subtraction:
                        Console.WriteLine($"{firstNumber} - {secondNumber}");
                        calculation = firstNumber - secondNumber;
                        break;
                    case GameType.Multiplication:
                        Console.WriteLine($"{firstNumber} * {secondNumber}");
                        calculation = firstNumber * secondNumber;
                        break;
                    case GameType.Division:
                        var divisionNumbers = Helpers.GetDivisionNumbers();
                        firstNumber = divisionNumbers[0];
                        secondNumber = divisionNumbers[1];

                        Console.WriteLine($"{firstNumber} / {secondNumber}");
                        calculation = firstNumber / secondNumber;
                        break;
                    default:
                        break;
                }

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == calculation)
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
            Helpers.AddToHistory(score, gametype, difficulty);
            Console.WriteLine($"Game over. Final score: {score}");
            Console.ReadLine();
        }
        //internal void AdditionGame(string message)
        //{
        //    Console.WriteLine(message);
        //    Random random = new Random();

        //    int firstNumber;
        //    int secondNumber;
        //    int score = 0;

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.Clear();
        //        firstNumber = random.Next(1, 9);
        //        secondNumber = random.Next(1, 9);

        //        Console.WriteLine($"{firstNumber} + {secondNumber}");
        //        var result = Console.ReadLine();

        //        result = Helpers.ValidateResult(result);

        //        if (int.Parse(result) == (firstNumber + secondNumber))
        //        {
        //            Console.WriteLine("Your answer was correct");
        //            score++;
        //        }
        //        else
        //        {
        //            Console.WriteLine("You are wrong");
        //        }
        //        Console.ReadLine();
        //    }
        //    Helpers.AddToHistory(score, GameType.Addition);
        //    Console.WriteLine($"Game over. Final score: {score}");
        //    Console.ReadLine();
        //}
        //internal void SubstractionGame(string message)
        //{
        //    Console.WriteLine(message);
        //    Random random = new Random();

        //    int firstNumber;
        //    int secondNumber;
        //    int score = 0;

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.Clear();
        //        firstNumber = random.Next(1, 9);
        //        secondNumber = random.Next(1, 9);

        //        Console.WriteLine($"{firstNumber} - {secondNumber}");
        //        var result = Console.ReadLine();

        //        result = Helpers.ValidateResult(result);

        //        if (int.Parse(result) == (firstNumber - secondNumber))
        //        {
        //            Console.WriteLine("Your answer was correct");
        //            score++;
        //        }
        //        else
        //        {
        //            Console.WriteLine("You are wrong");
        //        }
        //        Console.ReadLine();
        //    }
        //    Helpers.AddToHistory(score, GameType.Subtraction);
        //    Console.WriteLine($"Game over. Final score: {score}");
        //    Console.ReadLine();
        //}
        //internal void MultiplicationGame(string message)
        //{
        //    Random random = new Random();
        //    Console.WriteLine(message);

        //    int firstNumber;
        //    int secondNumber;
        //    int score = 0;

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.Clear();
        //        firstNumber = random.Next(1, 9);
        //        secondNumber = random.Next(1, 9);

        //        Console.WriteLine($"{firstNumber} * {secondNumber}");
        //        var result = Console.ReadLine();

        //        result = Helpers.ValidateResult(result);

        //        if (int.Parse(result) == (firstNumber * secondNumber))
        //        {
        //            Console.WriteLine("Your answer was correct");
        //            score++;
        //        }
        //        else
        //        {
        //            Console.WriteLine("You are wrong");
        //        }
        //        Console.ReadLine();
        //    }
        //    Helpers.AddToHistory(score, GameType.Multiplication);

        //    Console.WriteLine($"Game over. Final score: {score}");
        //    Console.ReadLine();
        //}
        //internal void DivisionGame(string message)
        //{
        //    int score = 0;

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.Clear();
        //        var divisionNumbers = Helpers.GetDivisionNumbers();

        //        var firstNumber = divisionNumbers[0];
        //        var secondNumber = divisionNumbers[1];


        //        Console.WriteLine($"{firstNumber} / {secondNumber}");
        //        var result = Console.ReadLine();

        //        result = Helpers.ValidateResult(result);

        //        if (int.Parse(result) == (firstNumber / secondNumber))
        //        {
        //            Console.WriteLine("Your answer was correct");
        //            score++;
        //        }
        //        else
        //        {
        //            Console.WriteLine("You are wrong");
        //        }
        //        Console.ReadLine();
        //    }
        //    Helpers.AddToHistory(score, GameType.Division);

        //    Console.WriteLine($"Game over. Final score: {score}");
        //    Console.ReadLine();
        //}
    }
}
