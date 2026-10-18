using System;
using System.Collections.Generic;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hur många karaktärer vill du generera? ");

        if (!int.TryParse(Console.ReadLine(), out int numberOfCharacters) ||
            numberOfCharacters <= 0)
        {
            Console.WriteLine("Ogiltig inmatning. Ange ett positivt heltal.");
            return;
        }

        CharacterGenerator generator = new CharacterGenerator();
        List<Character> characters = new List<Character>();

        // AI suggested using a list and a loop; I use them to generate the requested number of characters.
        for (int i = 0; i < numberOfCharacters; i++)
        {
            characters.Add(generator.GenerateCharacter());
        }

        Console.WriteLine("\nGenererade karaktärer:");

        foreach (Character character in characters)
        {
            Console.WriteLine(
                $"Namn: {character.Name}, Hälsa: {character.Health}, " +
                $"Snabbhet: {character.Speed}, Styrka: {character.Strength}, " +
                $"Specialförmåga: {character.SpecialAbility}");
        }
    }
}
