

namespace CozyDesigner.Card
{
    public class Bed:Item
    {
        public Bed()
        {
            itemType = ItemType.BED;
        }

        public override string name
        {
            get => "Bed";
            protected set { }
        }
        public override int comfort { get; protected set; }
        public override int esthetic { get; protected set; }
        public override int durability { get; protected set; }
    }
}
