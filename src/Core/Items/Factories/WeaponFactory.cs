using System;

namespace Core.Items.Factories
{
    public static class WeaponFactory
    {
        public static Weapon CreateFist()
        {
            var damage = new Func<uint>(() => Dice.Throw(1,4,-1));
            return new Weapon("My own fists", damage);
        }
        
        public static Weapon CreateBaton()
        {
            var damage = new Func<uint>(() => Dice.Throw(1,4));
            return new Weapon("Baton", damage);
        }
        
        public static Weapon CreateBattleAxe()
        {
            var damage = new Func<uint>(() => Dice.Throw(1,8));
            return new Weapon("Battle axe", damage);
        }
        
        public static Weapon CreateClaymore()
        {
            var damage = new Func<uint>(() => Dice.Throw(1,10));
            return new Weapon("Claymore", damage);
        }
        
        public static Weapon CreateDagger()
        {
            var damage = new Func<uint>(() => Dice.Throw(1,4));
            return new Weapon("Dagger", damage);
        }
        
        public static Weapon CreateHeavyMaze()
        {
            var damage = new Func<uint>(() => Dice.Throw(1,6));
            return new Weapon("Heavy maze", damage);
        }
        
        public static Weapon CreateSword()
        {
            var damage = new Func<uint>(() => Dice.Throw(1,8));
            return new Weapon("Sword", damage);
        }
        
        public static Weapon CreateWarHammer()
        {
            var damage = new Func<uint>(() => Dice.Throw(1,4, +1));
            return new Weapon("War hammer", damage);
        }
        
    }
}