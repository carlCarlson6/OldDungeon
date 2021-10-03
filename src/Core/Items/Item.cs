using System;

namespace Core.Items
{
    public abstract class Item
    {
        public string Identifier => Guid.NewGuid().ToString();
        public string Name { get; }
        
        private ItemType _itemType;
        public bool IsConsumable => _itemType == ItemType.Consumable;
        public bool IsArmour => _itemType == ItemType.Armour;
        public bool IsWeapon => _itemType == ItemType.Weapon;
        
        protected Item(string name, ItemType type)
        {
            Name = name;
            _itemType = type;
        }
        
        public abstract void Apply(Hero hero);

        public abstract uint DoDamage();

        public bool IsSameItem(Item item) => Identifier.Equals(item.Identifier);

        public override string ToString() => Name;
    }
}