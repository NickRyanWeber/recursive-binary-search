using System;

namespace recursive_binary_search
{
  class Program
  {
    static void BinarySearch(decimal upper, decimal lower, decimal guess)
    {
      Console.WriteLine($"is your number {guess}");
      var input = Console.ReadLine();

      if (input.ToLower() == "y" || input.ToLower() == "yes")
      {
        Console.WriteLine("Thanks for playing");
        return;
      }
      else if (input.ToLower() == "l" || input.ToLower() == "lower")
      {
        if (guess == lower || guess == upper)
        {
          Console.WriteLine($"Don't lie, I know your number is {guess}");
          return;
        }
        else
        {
          lower = guess;
          guess = Math.Ceiling((lower + upper) / 2);
          BinarySearch(upper, lower, guess);
        }
      }
      else if (input.ToLower() == "h" || input.ToLower() == "higher")
      {
        if (upper == guess || lower == guess)
        {
          Console.WriteLine($"Don't lie, I know your number is {guess}");
          return;
        }
        else
        {
          upper = guess;
          guess = Math.Floor((lower + upper) / 2);
          BinarySearch(upper, lower, guess);
        }
      }
      else
      {
        Console.WriteLine("Hmmm...I don't recognize that response, please try again");
        BinarySearch(upper, lower, guess);
      }
    }
    static void Main(string[] args)
    {
      var lower = 0m;
      var upper = 100m;
      var guess = Math.Floor((lower + upper) / 2);
      var playing = true;
      Console.WriteLine($"Pick a number between {lower} & {upper}");
      BinarySearch(lower, upper, guess);
      while (playing)
      {
        Console.WriteLine("Do you want to play again? Y/N");
        var input = Console.ReadLine();
        if (input.ToLower() == "y")
        {
          Console.WriteLine($"Pick a number between {lower} & {upper}");
          BinarySearch(lower, upper, guess);
        }
        else if (input.ToLower() == "n")
        {
          Console.WriteLine("Thanks for playing!");
          playing = false;
        }
        else
        {
          Console.WriteLine("Hmmm...I don't recognize that response, please try again");
        }
      }
    }
  }
}
