using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebAdventure
{
    public class Character
    {
        public CharacterInfo Info { get; init; }
        public CharacterStats Stats { get; init; } = new();
        public CharacterEquipment Equipment { get; init; } = new();

        public CharacterStats TotalCharacterStats => Stats + Equipment.TotalBonusCharacterStats;
        public ItemStats TotalItemStats => Equipment.TotalItemStats;

        public Character(CharacterInfo info)
        {
            Info = info ?? throw new ArgumentNullException(nameof(info));
        }
    }
}
