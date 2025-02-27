

namespace CozyDesigner.Card
{
    public class Reinforced: ItemDecorator
    {
        public Reinforced(Item item) : base(item)
        {
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
        public override int esthetic
        {
            get => Item.esthetic;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability + 4;
            protected set { }
        }
    }
}
