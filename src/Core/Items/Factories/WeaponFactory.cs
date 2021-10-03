namespace Core.Items.Factories
{
    public static class WeaponFactory
    {
        public static Weapon CreateFist() => 
            new ("My own fists", () => Dice.Throw(1,4,-1));

        public static Weapon CreateBaton() => 
            new ("Baton", () => Dice.Throw(1,4));

        public static Weapon CreateBattleAxe() => 
            new ("Battle axe", () => Dice.Throw(1,8));

        public static Weapon CreateClaymore() => 
            new ("Claymore", () => Dice.Throw(1,10));
        
        public static Weapon CreateDagger() => 
            new ("Dagger", () => Dice.Throw(1,4));
        
        public static Weapon CreateHeavyMaze() => 
            new ("Heavy maze", () => Dice.Throw(1,6));
        
        public static Weapon CreateSword() => 
            new ("Sword", () => Dice.Throw(1,8));
        
        public static Weapon CreateWarHammer() => 
            new ("War hammer", () => Dice.Throw(1,4, +1));
        
    }
}