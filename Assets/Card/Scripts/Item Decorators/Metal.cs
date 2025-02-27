

namespace CozyDesigner.Card
{
    public class Metal:ItemDecorator
    {
        public Metal(Item item) : base(item)
        {
            itemType = item.itemType;
        }
        public override string name
        {
            get => "Metal " + Item.name;
            protected set { }
        }
        public override int comfort
        {
            get => Item.comfort - 1;
            protected set { }
        }
        public override int aesthetic
        {
            get => Item.aesthetic + 1;
            protected set { }




        }
        public override int durability
        {
            get => Item.durability + 5;
            protected set { }
        }
    }
}
