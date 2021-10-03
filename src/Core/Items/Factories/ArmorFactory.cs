namespace Core.Items.Factories
{
    public static class ArmorFactory
    {
        public static Protection CreateLeatherArmor() => 
            new Protection("Leather armor", ItemType.Armour, 2);
        
        public static Protection CreateRingsArmor() => 
            new Protection("Rings armor", ItemType.Armour, 3);
        
        public static Protection CreateChainMailArmor() => 
            new Protection("Chain mail armor", ItemType.Armour, 4);
        
        public static Protection CreatePlateArmor() => 
            new Protection("Plate armor", ItemType.Armour, 6);
        
    }
}