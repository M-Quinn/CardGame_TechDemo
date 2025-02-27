

namespace CozyDesigner.Card
{
    public class Leather:ItemDecorator
    {
        public Leather(Item item) : base(item)
        {
        }
        public override string name
        {
            get => "Leather " + Item.name;
            protected set { }
        }
        public override int comfort
        {
            get => Item.comfort + 3;
            protected set { }
        }
        public override int aesthetic
        {
            get => Item.aesthetic + 2;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability + 3;
            protected set { }
        }
    }
}
