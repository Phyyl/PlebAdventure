namespace PlebAdventure
{
    public record CharacterEquipment
    {
        public HelmetItem Helmet { get; set; }
        public GloveItem Gloves { get; set; }
        public ChestItem Chest { get; set; }
        public BootItem Boots { get; set; }
        public PantsItem Pants { get; set; }

        public CharacterStats TotalBonusCharacterStats => Helmet?.BonusCharacterStats + Gloves?.BonusCharacterStats + Chest?.BonusCharacterStats + Boots?.BonusCharacterStats + Pants?.BonusCharacterStats;
        public ItemStats TotalItemStats => Helmet.ItemStats + Gloves.ItemStats + Chest.ItemStats + Boots.ItemStats + Pants?.ItemStats;
    }
}
