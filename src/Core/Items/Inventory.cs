#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using Core.Items.Factories;

namespace Core.Items
{
    public class Inventory
    {
        public List<Item> Items { get; private set; }
        public Item Weapon => Items.FirstOrDefault(item => item.IsWeapon) ?? WeaponFactory.CreateFist();
        public Item? Armour => Items.FirstOrDefault(item => item.IsArmour);
        public Item? Shield => Items.FirstOrDefault(item => item.IsShield);

        public Inventory() => Items = new List<Item>();

        // TODO - throw corresponding exception
        public Inventory(List<Item> items) => Items = items ?? throw new NotSupportedException();

        public bool Contains(Item item) => Items.Any(i => i.IsSameItem(item));

        public void Remove(Item item)
        {
            if (!Contains(item))
            {
                return;
            }
            Items = Items.Where(i => !i.Identifier.Equals(item.Identifier)).ToList();
        }

        public override string ToString()
        {
            if (!Items.Any())
            {
                return "Empty inventory";
            }
            
            var itemsAsString = Items.Select(item => item.ToString());
            var inventoryAsString = string.Join("\n", itemsAsString);
            return inventoryAsString;
        }
    }
}