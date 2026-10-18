using System;

namespace ConsoleApp1;

public class CharacterGenerator
{
    private readonly Random _random = new Random();

    // AI suggested using arrays for random names and abilities. I changed the names to sci-fi-style call signs after noticing familiar characters could get mismatched abilities.
    // AI showed each option on a separate line; I kept that layout because it is easier for me to read.
    private readonly string[] _names =
    {
        "Nova-7",
        "Ultra-9",
        "Scorpion-3",
        "Subzero-5",
        "Mega-2",
    };

    private readonly string[] _abilities =
    {
        "Invisibility",
        "Plasma Shield",
        "Flight",
        "Telepathy",
        "Time Manipulation"
    };


    public Character GenerateCharacter()
    {
        int nameIndex = _random.Next(_names.Length);
        int abilityIndex = _random.Next(_abilities.Length);

        return new Character
        {
            Name = _names[nameIndex],
            Health = _random.Next(50, 101),
            Speed = _random.Next(1, 11),
            Strength = _random.Next(1, 11),
            SpecialAbility = _abilities[abilityIndex]
        };
    }
}
