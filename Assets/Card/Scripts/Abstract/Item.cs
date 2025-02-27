

namespace CozyDesigner.Card
{
    public abstract class Item
    {
        public ItemType itemType { get; protected set; }
        public ItemRarity itemRarity { get; protected set; }
        public abstract string name { get; protected set; }
        public abstract int comfort { get; protected set; }
        public abstract int aesthetic { get; protected set; }
        public abstract int durability { get; protected set; }

    }

    public enum ItemType
    {
        CHAIR,
        COUCH,
        TABLE,
        DESK,
        BED
    }

    public enum ItemRarity
    {
        BASIC,
        COOL,
        LEGENDARY
    }

    public enum ItemAdjective
    {
        NONE,
        MOLDY,
        RIPPED,
        LEATHER,
        REINFORCED,
        WOODEN,
        METAL,
    }
}
