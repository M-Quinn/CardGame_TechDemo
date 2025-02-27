

namespace CozyDesigner.Card
{
    public class Wooden:ItemDecorator
    {
        public Wooden(Item item) : base(item)
        {
            itemType = item.itemType;
        }
        public override string name
        {
            get => "Wooden " + Item.name;
            protected set { }
        }
        public override int comfort
        {
            get => Item.comfort + 1;
            protected set { }
        }
        public override int aesthetic
        {
            get => Item.aesthetic + 2;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability;
            protected set { }
        }
    }
}
