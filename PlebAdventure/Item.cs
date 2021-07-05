using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebAdventure
{
    public record Item
    {
        public CharacterStats BonusCharacterStats { get; init; } = new();
        public ItemStats ItemStats { get; init; } = new();

        public string Name { get; init; }
        
        public Item(string name)
        {
            Name = name;
        }
    }
}
