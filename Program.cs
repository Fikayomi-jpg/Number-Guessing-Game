using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("Guess a Number Between 1 and 100!");

        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;
            
            if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You've guessed the number in {attempts} attempts.");
            }
    }
}
}