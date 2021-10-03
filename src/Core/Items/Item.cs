using System;

namespace Core.Items
{
    public abstract class Item
    {
        public string Identifier { get; }
        private string Name { get; }
        
        private readonly ItemType _itemType;
        public bool IsConsumable => _itemType == ItemType.Consumable;
        public bool IsArmour => _itemType == ItemType.Armour;
        public bool IsWeapon => _itemType == ItemType.Weapon;
        public bool IsShield => _itemType == ItemType.Shield;
        
        protected Item(string name, ItemType type)
        {
            Identifier = Guid.NewGuid().ToString();
            Name = name;
            _itemType = type;
        }
        
        public abstract Result Apply(Hero hero);

        public abstract uint DoDamage();

        public abstract uint GetProtection();
        
        public bool IsSameItem(Item item) => Identifier.Equals(item.Identifier);

        public override string ToString() => Name;
    }
}