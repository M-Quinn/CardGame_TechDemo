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
            get { return "Basic " + Item.name; }
            protected set { }
        }

        public override int comfort
        {
            get { return Item.comfort + 1; }
            protected set { }
        }

        public override int esthetic
        {
            get { return Item.esthetic + 1;}
            protected set { }
        }

        public override int durability
        {
            get { return Item.durability + 1;}
            protected set { }
        }
    }
}
