

namespace CozyDesigner.Card
{
    public class Table:Item
    {
        public Table()
        {
            itemType = ItemType.TABLE;
        }

        public override string name
        {
            get => "Table";
            protected set { }
        }
        public override int comfort { get; protected set; }
        public override int esthetic { get; protected set; }
        public override int durability { get; protected set; }
    }
}
