using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("UnitTests")]
namespace DotNet_Java_Lab1
{
    internal class Result
    {
        public List<int> itemsIds = new List<int>();
        public int totalValue { get; set; }
        public int totalWeight { get; set; }

        public override string ToString()
        {
            return $"items Id: {string.Join(" ", itemsIds)}{Environment.NewLine}Total Value: {totalValue}{Environment.NewLine}Total Weight: {totalWeight}{Environment.NewLine}";
        }
    }
}
