using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    class ResourcePaymentStrategy
    {
        public Player SourcePlayer { get; private set; }
        public BasicCard SourceCard { get; private set; }
        public int Cost { get; private set; }
        public Resource TargetResource { get; private set; }

        public ResourcePaymentStrategy(Player player, BasicCard source, int cost, Resource resource)
        {
            SourcePlayer = player;
            SourceCard = source;
            Cost = cost;
            TargetResource = resource;
        }
    }
}
