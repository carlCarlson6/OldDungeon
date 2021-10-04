using System;

namespace Core.Services
{
    public static class EnemyFactory
    {
        public static Enemy CreateGiantSpider(string name = null!)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Giant Spider";
            }
            
            var damage = new Func<int>(() => 1);
            var giantSpider = new Enemy(name, 1, 11, damage);
            return giantSpider;
        }

        public static Enemy CreateSkeleton(string name = null!)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Skeleton";
            }

            var damage = Dice.RollAsFunction("1d6");
            var skeleton = new Enemy(name, 2, 11, damage);
            return skeleton;
        }
        
        public static Enemy CreateGoblin(string name = null!)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Goblin";
            }
            
            var damage = Dice.RollAsFunction("1d6");
            var goblin = new Enemy(name, 1, 12, damage);
            return goblin;
        }
        
        public static Enemy CreateKobold(string name = null!)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Kobold";
            }
            
            var damage = Dice.RollAsFunction("1d6");
            var kobold = new Enemy(name, 0, 13, damage);
            return kobold;
        }
        
        public static Enemy CreateNecrophagus(string name = null!)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Necrophagus";
            }
            
            var damage = Dice.RollAsFunction("1d6");
            var necrophagus = new Enemy(name, 2, 13, damage);
            return necrophagus;
        }
        
        public static Enemy CreateOrk(string name = null!)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Ork";
            }
            
            var damage = Dice.RollAsFunction("1d8+1");
            var ork = new Enemy(name, 2, 13, damage);
            return ork;
        }
        
        public static Enemy CreateGiantRat(string name = null!)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Giant Rat";
            }
            
            var damage = Dice.RollAsFunction("1d4");
            var giantRat = new Enemy(name, 0, 10, damage);
            return giantRat;
        }
        
        public static Enemy CreateZombie(string name = null!)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Zombie";
            }
            
            var damage = Dice.RollAsFunction("1d6");
            var zombie = new Enemy(name, 2, 11, damage);
            return zombie;
        }
    }
}