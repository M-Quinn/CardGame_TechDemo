

namespace CozyDesigner.Card
{
    public class Ripped : ItemDecorator
    {
        public Ripped(Item item) : base(item)
        {
            itemType = item.itemType;
        }
        public override string name
        {
            get => "Ripped " + Item.name;
            protected set { }
        }
        public override int comfort
        {
            get => Item.comfort - 1;
            protected set { }
        }
        public override int aesthetic
        {
            get => Item.aesthetic - 3;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability - 2;
            protected set { }
        }
    }
}
