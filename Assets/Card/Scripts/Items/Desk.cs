

namespace CozyDesigner.Card
{
    public class Desk:Item
    {
        public Desk()
        {
            itemType = ItemType.DESK;
        }

        public override string name
        {
            get => "Desk";
            protected set { }
        }
        public override int comfort { get; protected set; }
        public override int esthetic { get; protected set; }
        public override int durability { get; protected set; }
    }
}
