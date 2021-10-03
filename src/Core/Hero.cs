using System;
using Core.Enemies;
using Core.Items;

namespace Core
{
    public class Hero
    {
        public string Name { get; }
        
        public uint Level { get; }
        public uint ExperiencePoints { get; }
        
        public uint HealthPoints { get; private set; }
        private uint MaxHealPoints => (uint)(8 + Constitution.Modifier);
        
        public uint AttackAtClose => (uint)Strength.Modifier;
        public uint AttackAtRange => (uint)Dexterity.Modifier;
        
        public uint Defense => (uint)(10 + Dexterity.Modifier); // add modifier of armour and shield
        public uint Instinct => 1;
        public uint Power => 0;

        public Attribute Strength { get; }
        public Attribute Dexterity { get; }
        public Attribute Constitution { get;}
        public Attribute Intelligence { get; }
        public Attribute Wisdom { get; }
        public Attribute Charisma { get; }

        public Inventory Inventory { get; }
        
        private Hero(string name)
        {
            Name = name;
            
            Level = 1;
            ExperiencePoints = 0;
            
            Strength = Attribute.GenerateRandomAttribute();
            Dexterity = Attribute.GenerateRandomAttribute();
            Constitution = Attribute.GenerateRandomAttribute();
            Intelligence = Attribute.GenerateRandomAttribute();
            Wisdom = Attribute.GenerateRandomAttribute();
            Charisma = Attribute.GenerateRandomAttribute();

            HealthPoints = MaxHealPoints;

            Inventory = new Inventory();
        }

        public static Hero CreateRandomHero(string name) => new Hero(name);

        public void UseItem(Item item)
        {
            // TODO - throw corresponding exception
            if (!item.IsConsumable || !Inventory.Contains(item))
            {
                throw new NotSupportedException();
            }

            item.Apply(this);
            Inventory.Remove(item);
        }

        public void Cure(uint healthPointsToCure)
        {
            HealthPoints += healthPointsToCure;
            if (HealthPoints > MaxHealPoints)
            {
                HealthPoints = MaxHealPoints;
            }
        }

        public void Attack(Enemy enemy)
        {
            var attackScore = Dice.WithFaces(20).Throw(1) + Level;
            if (attackScore <= enemy.Defense)
            {
                return;
            }

            var pointsToLose = Inventory.Weapon.DoDamage();
            throw new NotImplementedException();
        }

        public void SufferDamage(uint healthPointToReduce) => HealthPoints -= healthPointToReduce;

    }
}