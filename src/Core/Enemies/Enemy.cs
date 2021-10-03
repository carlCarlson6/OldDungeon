using System;

namespace Core.Enemies
{
    public class Enemy
    {
        public string Name { get; }
        public uint Level { get; }
        public uint HealthPoints { get; private set; }
        public uint Defense { get; }
        public Func<uint> Damage { get; } 

        public Enemy(string name, uint level, uint defense, Func<uint> damage)
        {
            Name = name;
            Level = level;
            HealthPoints = level != 0 ? Dice.WithFaces(8).Throw(Level) : Dice.WithFaces(4).Throw(1);
            Defense = defense;
            Damage = damage;
        }

        public void Attack(Hero hero)
        {
            var attackScore = Dice.WithFaces(20).Throw(1) + Level;

            if (attackScore <= hero.Defense)
            {
                return;
            }

            var pointsToLose = Damage();
            hero.SufferDamage(pointsToLose);
        }
    }
}