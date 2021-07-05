namespace PlebAdventure
{
    public record CharacterEquipment
    {
        public Item? Helmet { get; set; }
        public Item? Gloves { get; set; }
        public Item? Chest { get; set; }
        public Item? Boots { get; set; }
        public Item? Pants { get; set; }

        public CharacterStats TotalBonusCharacterStats => CharacterStats.Combine(Helmet?.BonusCharacterStats, Gloves?.BonusCharacterStats, Chest?.BonusCharacterStats, Boots?.BonusCharacterStats, Pants?.BonusCharacterStats);
        public ItemStats TotalItemStats => ItemStats.Combine(Helmet?.ItemStats, Gloves?.ItemStats, Chest?.ItemStats, Boots?.ItemStats, Pants?.ItemStats);
    }
}
