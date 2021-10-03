namespace Core.Items.Factories
{
    public static class ShieldFactory
    {
        public static Protection CreateWoodenShield() =>
            new ("Wooden shield", ItemType.Shield, 3);
    }
}