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
        public bool IsAlive => HealthPoints > 0;
        public bool IsDead => !IsAlive;
        
        public uint AttackAtClose => (uint)Strength.Modifier;
        public uint AttackAtRange => (uint)Dexterity.Modifier;
        public uint Defense => CalculateDefense();
        public uint Instinct => 1;
        public uint Power => 0;

        public Attribute Strength { get; }
        public Attribute Dexterity { get; }
        public Attribute Constitution { get;}
        public Attribute Intelligence { get; }
        public Attribute Wisdom { get; }
        public Attribute Charisma { get; }

        public Inventory Inventory { get; }
        
        public Hero(string name)
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
        
        public Result UseItem(Item item)
        {
            // TODO - throw corresponding exception
            if (!item.IsConsumable || !Inventory.Contains(item))
            {
                throw new NotSupportedException();
            }

            var actionResult = item.Apply(this);
            Inventory.Remove(item);

            return actionResult;
        }

        public void Cure(uint healthPointsToCure)
        {
            HealthPoints += healthPointsToCure;
            if (HealthPoints > MaxHealPoints)
            {
                HealthPoints = MaxHealPoints;
            }
        }

        public Result Attack(Enemy enemy)
        {
            var attackScore = Dice.WithFaces(20).Throw(1) + Level;
            if (attackScore <= enemy.Defense)
            {
                return new Result("The monster has avoided the attack");
            }

            var pointsToLose = Inventory.Weapon.DoDamage();
            throw new NotImplementedException();
        }

        public void SufferDamage(uint healthPointToReduce) => HealthPoints -= healthPointToReduce;

        private uint CalculateDefense()
        {
            var basicDefense = (uint)(10 + Dexterity.Modifier);
            var armourDefense = Inventory.Armour?.GetProtection() ?? 0; 
            var shieldDefense = Inventory.Shield?.GetProtection() ?? 0;
            return basicDefense + armourDefense + shieldDefense;
        }

    }
}