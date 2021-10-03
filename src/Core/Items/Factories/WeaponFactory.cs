namespace Core.Items.Factories
{
    public static class WeaponFactory
    {
        public static Weapon CreateFist() => 
            new ("My own fists", Dice.ThrowAsFunction(1,4,-1));

        public static Weapon CreateBaton() => 
            new ("Baton", Dice.ThrowAsFunction(1, 4));

        public static Weapon CreateBattleAxe() => 
            new ("Battle axe", Dice.ThrowAsFunction(1,8));

        public static Weapon CreateClaymore() => 
            new ("Claymore", Dice.ThrowAsFunction(1,10));
        
        public static Weapon CreateDagger() => 
            new ("Dagger", Dice.ThrowAsFunction(1,4));
        
        public static Weapon CreateHeavyMaze() => 
            new ("Heavy maze", Dice.ThrowAsFunction(1,6));
        
        public static Weapon CreateSword() => 
            new ("Sword", Dice.ThrowAsFunction(1,8));
        
        public static Weapon CreateWarHammer() => 
            new ("War hammer", Dice.ThrowAsFunction(1,4, +1));
        
    }
}