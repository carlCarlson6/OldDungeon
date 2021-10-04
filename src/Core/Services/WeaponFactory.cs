namespace Core.Services
{
    public static class WeaponFactory
    {
        public static Weapon CreateFist() => 
            new ("My own fists", Dice.RollAsFunction("1d4-1"));

        public static Weapon CreateBaton() => 
            new ("Baton", Dice.RollAsFunction("1d4"));

        public static Weapon CreateBattleAxe() => 
            new ("Battle axe", Dice.RollAsFunction("1d8"));

        public static Weapon CreateClaymore() => 
            new ("Claymore", Dice.RollAsFunction("1d10"));
        
        public static Weapon CreateDagger() => 
            new ("Dagger", Dice.RollAsFunction("1d4"));
        
        public static Weapon CreateHeavyMaze() => 
            new ("Heavy maze", Dice.RollAsFunction("1d6"));
        
        public static Weapon CreateSword() => 
            new ("Sword", Dice.RollAsFunction("1d8"));
        
        public static Weapon CreateWarHammer() => 
            new ("War hammer", Dice.RollAsFunction("1d4+1"));
        
    }
}