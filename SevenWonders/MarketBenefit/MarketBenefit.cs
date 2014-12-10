using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{

    public class MarketBenefit
    {
        public PlayerDirection TradePlayers
        {
            get;
            private set;
        }

        public Resource TradeResources
        {
            get;
            private set;
        }

        public int TradeCost
        {
            get;
            private set;
        }

        private MarketBenefit() { }

        public MarketBenefit(PlayerDirection benefitDirection, Resource resource, int cost)
        {
            TradePlayers = benefitDirection;
            TradeResources = resource;
            TradeCost = cost;
        }

        public int GetResourceCost(PlayerDirection playerDirection, Resource resource)
        {
            if (AffectsPlayer(playerDirection) && AffectsResource(resource)) return TradeCost;
            else return 2;
        }

        public bool AffectsPlayer(PlayerDirection playerDirection)
        {
            if (TradePlayers == PlayerDirection.Any) return true;
            else if ((TradePlayers & playerDirection) != 0) return true;
            else return false;
        }

        public bool AffectsResource(Resource resource)
        {
            if (TradeResources == Resource.Any) return true;
            else if ((TradeResources & resource) != 0) return true;
            else return false;
        }

        // public static int GetCheapestResourceCost(IEnumerable<MarketBenefit>, Resource)
    }
}
