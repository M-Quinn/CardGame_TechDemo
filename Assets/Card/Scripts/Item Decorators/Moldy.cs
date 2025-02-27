using UnityEngine;

namespace CozyDesigner.Card
{
    public class Moldy : ItemDecorator
    {
        public Moldy(Item item) : base(item)
        {
        }

        public override string name
        {
            get => "Moldy " + Item.name;
            protected set { }
        }
        public override int comfort
        {
            get => Item.comfort - 1;
            protected set { }
        }
        public override int esthetic
        {
            get => Item.esthetic - 2;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability - 1;
            protected set { }
        }
    }
}
