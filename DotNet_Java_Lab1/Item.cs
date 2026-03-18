using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("UnitTests")]
namespace DotNet_Java_Lab1
{
    internal class Item
    {
        public int id { get; set; }
        public int value { get; set; }
        public int weight { get; set; }

        public Item(int id, int v, int w)
        {
            this.id = id;
            this.value = v;
            this.weight = w;
        }

        public double ratio => (double)value / weight;
    }
}
