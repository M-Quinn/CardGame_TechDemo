using UnityEngine;

namespace CozyDesigner.Card
{
    public class Moldy : ItemDecorator
    {
        public Moldy(Item item) : base(item)
        {
            itemType = item.itemType;
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
        public override int aesthetic
        {
            get => Item.aesthetic - 2;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability - 1;
            protected set { }
        }
    }
}
