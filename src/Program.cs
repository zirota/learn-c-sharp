// Import namespace
// Namespace can contain multiple classes
using System;

// Custom namespace
namespace learn_c_sharp {
  class Program {
    static void Main(string[] args) {
      // App Variables
      string appName = "Learning C#";
      string appVersion = "0.0.1";
      string appAuthor = "Hazzen Chua";

      // Change Text Color
      // Console, ConsoleColor are classes found in the System namespace
      Console.ForegroundColor = ConsoleColor.Green;

      Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

      // Synchronous
      // Resets Color
      Console.ResetColor();
      
      // Input
      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      bool playAgain;

      do {
        playAgain = false;
        // Constructs a new Program object
        // Starts the game
        Program game = new Program();
        game.NumberGuessing();
        Console.WriteLine("Do you want to play again? [Y]");
        string replay = Console.ReadLine().ToLower();
        if (replay.StartsWith("y")) {
          playAgain = true;
        }
      } while (playAgain);
    }

    private void NumberGuessing() {
      // Generates a random number between 1-10
      int correctNumber = new Random().Next(1, 10);

      bool correct = false;      
      do {
        Console.Write("Guess the correct number: ");
        string guess = Console.ReadLine();
        if (int.TryParse(guess, out int guessNumber) && guessNumber == correctNumber) {
          correct = true;
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("BINGO!");
        } else {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("You got it wrong, please try again");
        }
        Console.ResetColor();
      } while(!correct);
    }
  }
}
