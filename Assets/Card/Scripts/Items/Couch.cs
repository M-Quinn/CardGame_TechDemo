

namespace CozyDesigner.Card
{
    public class Couch: Item
    {
        public Couch()
        {
            itemType = ItemType.COUCH;
        }

        public override string name
        {
            get => "Couch";
            protected set { }
        }
        public override int comfort { get; protected set; }
        public override int aesthetic { get; protected set; }
        public override int durability { get; protected set; }
    }
}
