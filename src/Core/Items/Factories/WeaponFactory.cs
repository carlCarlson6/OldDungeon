namespace Core.Items.Factories
{
    public static class WeaponFactory
    {
        public static Weapon CreateFist() => 
            new ("My own fists", Dice.RollAsFunction(4,-1));

        public static Weapon CreateBaton() => 
            new ("Baton", Dice.RollAsFunction(4));

        public static Weapon CreateBattleAxe() => 
            new ("Battle axe", Dice.RollAsFunction(8));

        public static Weapon CreateClaymore() => 
            new ("Claymore", Dice.RollAsFunction(10));
        
        public static Weapon CreateDagger() => 
            new ("Dagger", Dice.RollAsFunction(4));
        
        public static Weapon CreateHeavyMaze() => 
            new ("Heavy maze", Dice.RollAsFunction(6));
        
        public static Weapon CreateSword() => 
            new ("Sword", Dice.RollAsFunction(8));
        
        public static Weapon CreateWarHammer() => 
            new ("War hammer", Dice.RollAsFunction(4, +1));
        
    }
}