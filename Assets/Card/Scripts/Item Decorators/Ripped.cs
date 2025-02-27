using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyDesigner.Card
{
    internal class Ripped : ItemDecorator
    {
        public Ripped(Item item) : base(item)
        {
        }
        public override string name
        {
            get => "Ripped " + Item.name;
            protected set { }
        }
        public override int comfort
        {
            get => Item.comfort - 1;
            protected set { }
        }
        public override int esthetic
        {
            get => Item.esthetic - 3;
            protected set { }
        }
        public override int durability
        {
            get => Item.durability - 2;
            protected set { }
        }
    }
}
