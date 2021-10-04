using System;

namespace Core.Enemies
{
    public class Enemy
    {
        public string Name { get; }
        public uint Level { get; }
        public uint HealthPoints { get; private set; }

        public bool IsAlive => HealthPoints > 0;
        public bool IsDead => !IsAlive;
        
        public uint Defense { get; }
        public Func<uint> Damage { get; } 

        public Enemy(string name, uint level, uint defense, Func<uint> damage)
        {
            Name = name;
            Level = level;
            HealthPoints = level != 0 ? Dice.Roll($"{level}d8") : Dice.Roll("1d4");
            Defense = defense;
            Damage = damage;
        }

        public Result Attack(Hero hero)
        {
            var attackScore = Dice.Roll($"1d20+${Level}");

            if (attackScore <= hero.Defense)
            {
                return new Result("The hero has avoided the monster attack");
            }

            var pointsToLose = Damage();
            hero.SufferDamage(pointsToLose);

            // TODO - insert corresponding message
            return new Result("<insert corresponding message>");
        }
    }
}