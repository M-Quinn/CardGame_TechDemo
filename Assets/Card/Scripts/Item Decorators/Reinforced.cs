

namespace CozyDesigner.Card
{
    public class Reinforced: ItemDecorator
    {
        public Reinforced(Item item) : base(item)
        {
            itemType = item.itemType;
        }
        public override string name
        {
            get => "Reinforced " + Item.name;
            protected set { }
        }
        public override int comfort
        {
            get => Item.comfort;
            protected set { }
        }
        public override int aesthetic
        {
            get => Item.aesthetic;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability + 4;
            protected set { }
        }
    }
}
