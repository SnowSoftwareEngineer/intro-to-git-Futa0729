using System;
using GameEnums;

public class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello world");

        // Prompt the user to select a game difficulty using the GameDifficulty enum.
        Console.WriteLine("Select a difficulty (Easy, Medium, Hard):");

        string inputGameDifficulty = Console.ReadLine();
        if (!Enum.TryParse(inputGameDifficulty, true, out GameDifficulty difficulty))
            difficulty = GameDifficulty.Easy;
        Console.WriteLine();

        // Prompt the user to select a character class using the CharacterClass enum.
        Console.WriteLine("Select a character class (Warrior, Mage, Rogue):");

        string inputCharacterClass = Console.ReadLine();
        if (!Enum.TryParse(inputCharacterClass, true, out CharacterClass character))
            character = CharacterClass.Warrior;
        Console.WriteLine();

        // Display a summary of the user's selections.
        Console.WriteLine("You selected:");
        Console.WriteLine($"Difficulty: {difficulty}");
        Console.WriteLine($"Character Class: {character}");
    }
}