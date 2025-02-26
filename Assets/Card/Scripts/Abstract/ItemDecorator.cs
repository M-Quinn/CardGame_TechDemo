

namespace CozyDesigner.Card
{
    public abstract class ItemDecorator : Item
    {
        protected Item Item;

        public ItemDecorator(Item item)
        {
            Item = item;
        }
    }
}
