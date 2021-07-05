using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebAdventure
{
    public class ItemGenerator
    {
    }

    public class ItemTemplate
    {
        public Item Base { get; }


        public ItemTemplate(Item @base)
        {
            Base = @base;
        }
    }
}
