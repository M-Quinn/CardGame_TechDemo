

namespace CozyDesigner.Card
{
    public class Cool: ItemDecorator
    {
        public Cool(Item item) : base(item)
        {
            itemRarity = ItemRarity.COOL;
        }

        public override string name
        {
            get => "Cool " + Item.name;
            protected set { }
        }
        public override int comfort
        {
            get => Item.comfort + 2;
            protected set { }
        }
        public override int esthetic
        {
            get => Item.esthetic + 4;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability + 2;
            protected set { }
        }
    }
}
