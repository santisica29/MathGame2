using MathGame2.Models;

namespace MathGame2
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);
            Random random = new Random();

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
            Helpers.AddToHistory(score, GameType.Addition);
            Console.WriteLine($"Game over. Final score: {score}");
            Console.ReadLine();
        }
        internal void SubstractionGame(string message)
        {
            Console.WriteLine(message);
            Random random = new Random();

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
            Helpers.AddToHistory(score, GameType.Substraction);
            Console.WriteLine($"Game over. Final score: {score}");
            Console.ReadLine();
        }
        internal void MultiplicationGame(string message)
        {
            Random random = new Random();
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
            Helpers.AddToHistory(score, GameType.Multiplication);

            Console.WriteLine($"Game over. Final score: {score}");
            Console.ReadLine();
        }
        internal void DivisionGame(string message)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                var divisionNumbers = Helpers.GetDivisionNumbers();

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
            Helpers.AddToHistory(score, GameType.Division);

            Console.WriteLine($"Game over. Final score: {score}");
            Console.ReadLine();
        }
    }
}
