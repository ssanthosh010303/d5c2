/*
 * Author: Sakthi Santhosh
 * Created on: 16/04/2024
 *
 * Day-5 Challenge-2: Bulls and Cows
 */
namespace Challenge2;

class Program
{
    public static string GetHint(string secret, string guess)
    {
        var countMap = new int[10];
        int cows = 0, bulls = 0;

        int index;

        for (index = 0; index < secret.Length; index++)
            countMap[secret[index] - '0']++;

        for (index = 0; index < guess.Length; index++)
            if (secret[index] == guess[index])
            {
                bulls++;
            }
            else
            {
                countMap[secret[index] - '0']++;
                countMap[guess[index] - '0']--;
                cows++;
            }

        return $"{bulls}A{cows}B";
    }

    public static void Main()
    {
        string? secret, guess;

        Console.Write("Enter secret: ");
        secret = Console.ReadLine();

        Console.Write("Enter guess: ");
        guess = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(guess)) return;

        Console.WriteLine("\nResult");
        Console.WriteLine("  " + GetHint(secret, guess));
    }
}
