﻿

namespace CozyDesigner.Card
{
    public class Metal:ItemDecorator
    {
        public Metal(Item item) : base(item)
        {
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
        public override int esthetic
        {
            get => Item.esthetic + 1;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability + 5;
            protected set { }
        }
    }
}
