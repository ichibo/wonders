
namespace SevenWonders.StandardCards.Market
{
    public class WestTradingPost : BasicCard
    {
        public WestTradingPost()
        {
            PlayInfoSettings settings = new PlayInfoSettings();
            settings.MarketBenefits = new MarketBenefit[] { new MarketBenefit(PlayerDirection.Left, Resource.Brick | Resource.Stone | Resource.Wood | Resource.Ore, 1) };
            PlayInfo = new PlayInfo(settings);
        }

        public override string Name { get { return "West Trading Post"; } }
        public override CardCategory Category { get { return CardCategory.Market; } }
        public override Age Age { get { return Age.I; } }
    }

    public class EastTradingPost : BasicCard
    {
        public EastTradingPost()
        {
            PlayInfoSettings settings = new PlayInfoSettings();
            settings.MarketBenefits = new MarketBenefit[] { new MarketBenefit(PlayerDirection.Right, Resource.Brick | Resource.Stone | Resource.Wood | Resource.Ore, 1) };
            PlayInfo = new PlayInfo(settings);
        }

        public override string Name { get { return "East Trading Post"; } }
        public override CardCategory Category { get { return CardCategory.Market; } }
        public override Age Age { get { return Age.I; } }
    }

    public class MarketPlace : BasicCard
    {
        public MarketPlace()
        {
            PlayInfoSettings settings = new PlayInfoSettings();
            settings.MarketBenefits = new MarketBenefit[] { new MarketBenefit(PlayerDirection.Right | PlayerDirection.Left, Resource.Bottle | Resource.Scroll | Resource.Wool, 1) };
            PlayInfo = new PlayInfo(settings);
        }

        public override string Name { get { return "Marketplace"; } }
        public override CardCategory Category { get { return CardCategory.Market; } }
        public override Age Age { get { return Age.I; } }
    }
}
