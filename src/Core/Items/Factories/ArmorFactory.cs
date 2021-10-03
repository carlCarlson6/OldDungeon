namespace Core.Items.Factories
{
    public static class ArmorFactory
    {
        public static Protection CreateLeatherArmor() => new ("Leather armor", ItemType.Armour, 2);
        
        public static Protection CreateRingsArmor() => new ("Rings armor", ItemType.Armour, 3);
        
        public static Protection CreateChainMailArmor() => new ("Chain mail armor", ItemType.Armour, 4);
        
        public static Protection CreatePlateArmor() => new ("Plate armor", ItemType.Armour, 6);
        
    }
}