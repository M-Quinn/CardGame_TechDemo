﻿

namespace CozyDesigner.Card
{
    internal class Legendary: ItemDecorator
    {
        public Legendary(Item item) : base(item)
        {
            itemRarity = ItemRarity.LEGENDARY;
            itemType = item.itemType;
        }

        public override string name
        {
            get => "Legendary " + Item.name;
            protected set { }
        }
        public override int comfort
        {
            get => Item.comfort + 5;
            protected set { }
        }
        public override int aesthetic
        {
            get => Item.aesthetic + 10;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability + 4;
            protected set { }
        }
    }
}
