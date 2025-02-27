

namespace CozyDesigner.Card
{
    public class Wooden:ItemDecorator
    {
        public Wooden(Item item) : base(item)
        {
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
        public override int esthetic
        {
            get => Item.esthetic + 2;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability;
            protected set { }
        }
    }
}
