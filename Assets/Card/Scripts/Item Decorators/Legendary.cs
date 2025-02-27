

namespace CozyDesigner.Card
{
    internal class Legendary: ItemDecorator
    {
        public Legendary(Item item) : base(item)
        {
            itemRarity = ItemRarity.LEGENDARY
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
        public override int esthetic
        {
            get => Item.esthetic + 10;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability + 4;
            protected set { }
        }
    }
}
