using System.Linq;

namespace PlebAdventure
{
    public record CharacterStats
    {
        public double Intelligence { get; set; }
        public double Charisma { get; set; }
        public double Wisdom { get; set; }
        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Constitution { get; set; }

        public static CharacterStats operator +(CharacterStats a, CharacterStats b) => new()
        {
            Charisma = a.Charisma + b.Charisma,
            Intelligence = a.Intelligence + b.Intelligence,
            Wisdom = a.Wisdom + b.Wisdom,
            Strength = a.Strength + b.Strength,
            Dexterity = a.Dexterity + b.Dexterity,
            Constitution = a.Constitution + b.Constitution
        };

        public static CharacterStats Combine(params CharacterStats?[] characterStats) => (from s in characterStats where s is not null select s).Aggregate(new CharacterStats(), (a, b) => a + b);
    }
}
