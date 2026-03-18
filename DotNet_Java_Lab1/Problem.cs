using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("UnitTests")]
namespace DotNet_Java_Lab1
{
    internal class Problem
    {
        public int n { get; set; }
        public List<Item> items { get; set; }

        public Problem(int n, int seed)
        {
            this.n = n;
            this.items = new List<Item>();
            Random random = new Random(seed);

            for (int i = 0; i < n; i++)
            {
                items.Add(new Item(i, random.Next(1, 11), random.Next(1, 11)));
            }

        }

        public Result solve(int capacity)
        {
            Result result = new Result();

            var sortedItems = items.OrderByDescending(item => item.ratio).ToList();

            foreach (var item in sortedItems)
            {
                if (result.totalWeight + item.weight <= capacity)
                {
                    result.itemsIds.Add(item.id);
                    result.totalWeight += item.weight;
                    result.totalValue += item.value;
                }
            }

            return result;
        }

        public override string ToString()
        {
            String output = "";

            foreach (Item item in items)
            {
                output += $"no.: {item.id}, v: {item.value}, w: {item.weight}{Environment.NewLine}";
            }

            return output;
        }
    }
}
