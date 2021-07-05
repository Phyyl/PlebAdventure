using System.Linq;

namespace PlebAdventure
{
    public record ItemStats
    {
        public double Damage { get; init; }
        public double Defense { get; init; }

        public static ItemStats operator +(ItemStats a, ItemStats b) => new()
        {
            Damage = a.Damage + b.Damage,
            Defense = a.Defense + b.Defense
        };

        public static ItemStats operator *(ItemStats a, ItemStats b) => new()
        {
            Damage = a.Damage * b.Damage,
            Defense = a.Defense * b.Defense
        };

        public static ItemStats Combine(params ItemStats?[] itemStats) => (from s in itemStats where s is not null select s).Aggregate(new ItemStats(), (a, b) => a + b);
    }
}
