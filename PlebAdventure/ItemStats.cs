namespace PlebAdventure
{
    public record ItemStats
    {
        public double Damage { get; init; }
        public double Defense { get; init; }

        public static ItemStats operator +(ItemStats a, ItemStats b) => (a, b) switch
        {
            (null, null) => null,
            (null, { }) => new(b),
            ({ }, null) => new(a),
            _ => new()
            {
                Damage = a.Damage + b.Damage,
                Defense = a.Defense + b.Defense
            }
        };

        public static ItemStats operator *(ItemStats a, ItemStats b) => (a, b) switch
        {
            (null, null) => null,
            (null, { }) => new(b),
            ({ }, null) => new(a),
            _ => new()
            {
                Damage = a.Damage * b.Damage,
                Defense = a.Defense * b.Defense
            }
        };
    }
}
