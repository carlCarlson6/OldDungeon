using System;

namespace Core.Enemies
{
    public class EnemyFactory
    {
        public static Enemy CreateGiantSpider(string name = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Giant Spider";
            }
            
            var damage = new Func<uint>(() => 1);
            var giantSpider = new Enemy(name, 1, 11, damage);
            return giantSpider;
        }

        public static Enemy CreateSkeleton(string name = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Skeleton";
            }
            
            var damage = new Func<uint>(() => Dice.WithFaces(6).Throw(1));
            var skeleton = new Enemy(name, 2, 11, damage);
            return skeleton;
        }
        
        public static Enemy CreateGoblin(string name = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Goblin";
            }
            
            var damage = new Func<uint>(() => Dice.WithFaces(6).Throw(1));
            var goblin = new Enemy(name, 1, 12, damage);
            return goblin;
        }
        
        public static Enemy CreateKobold(string name = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Necrophagus";
            }
            
            var damage = new Func<uint>(() => Dice.WithFaces(6).Throw(1));
            var goblin = new Enemy(name, 0, 13, damage);
            return goblin;
        }
        
        public static Enemy CreateNecrophagus(string name = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Necrophagus";
            }
            
            var damage = new Func<uint>(() => Dice.Throw(1, 6));
            var goblin = new Enemy(name, 2, 13, damage);
            return goblin;
        }
        
        public static Enemy CreateOrk(string name = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Necrophagus";
            }
            
            var damage = new Func<uint>(() => Dice.Throw(1, 8, 1));
            var ork = new Enemy(name, 2, 13, damage);
            return ork;
        }
    }
}