using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace PlebAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new(new(CharacterClass.Bard, "Vladimir", "Frite", "Sauce"));

            c.Equipment.Boots = new("Magic Boots")
            {
                ItemStats = new()
                {
                    Defense = 3
                }
            };
        }
    }
}