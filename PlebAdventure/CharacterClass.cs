using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlebAdventure
{
    public class CharacterClass
    {
        public static readonly CharacterClass Barbarian = new(new()
        {
            Strength = 2,
            Constitution = 1,
        });

        public static readonly CharacterClass Bard = new(new()
        {
            Charisma = 2,
            Intelligence = 1,
        });

        public static readonly CharacterClass Cleric = new(new()
        {
            Intelligence = 2,
            Wisdom = 1,
        });

        //public static readonly CharacterClass Druid = new(new()
        //{

        //});

        //public static readonly CharacterClass Fighter = new(new()
        //{

        //});

        //public static readonly CharacterClass Monk = new(new()
        //{

        //});

        //public static readonly CharacterClass Paladin = new(new()
        //{

        //});

        //public static readonly CharacterClass Ranger = new(new()
        //{

        //});

        //public static readonly CharacterClass Rogue = new(new()
        //{

        //});

        //public static readonly CharacterClass Sorcerer = new(new()
        //{

        //});

        //public static readonly CharacterClass Warlock = new(new()
        //{

        //});

        //public static readonly CharacterClass Wizard = new(new()
        //{

        //});

        public string Name { get; }
        public CharacterStats CharacterStats { get; }

        private CharacterClass(CharacterStats characterStats, [CallerMemberName] string? name = default)
        {
            CharacterStats = characterStats;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public static implicit operator string?(CharacterClass? @class) => @class?.Name;
        public static implicit operator CharacterClass?(string? name) => typeof(CharacterClass).GetField(name ?? "", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as CharacterClass ?? default;
    }
}
