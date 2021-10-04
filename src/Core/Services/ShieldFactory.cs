namespace Core.Services
{
    public static class ShieldFactory
    {
        public static Protection CreateWoodenShield() => new ("Wooden shield", ItemType.Shield, 1);
        
        public static Protection CreateIronShield() => new ("Iron shield", ItemType.Shield, 2);
    }
}