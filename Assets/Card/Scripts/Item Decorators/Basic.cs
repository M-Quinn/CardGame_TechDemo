using UnityEngine;

namespace CozyDesigner.Card
{
    public class Basic : ItemDecorator
    {
        public Basic(Item item) : base(item)
        {
            itemRarity = ItemRarity.BASIC;
        }

        public override string name
        {
            get => "Basic " + Item.name;
            protected set { }
        }

        public override int comfort
        {
            get => Item.comfort + 1;
            protected set { }
        }

        public override int aesthetic
        {
            get => Item.aesthetic + 1;
            protected set { }
        }

        public override int durability
        {
            get => Item.durability + 1;
            protected set { }
        }
    }
}
