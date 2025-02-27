using UnityEngine;

namespace CozyDesigner.Card
{
    public class Chair : Item
    {
        public Chair()
        {
            itemType = ItemType.CHAIR;
        }

        public override string name
        {
            get => "Chair";
            protected set { }
        }
        public override int comfort { get; protected set; }
        public override int esthetic { get; protected set; }
        public override int durability { get; protected set; }
    }
}
