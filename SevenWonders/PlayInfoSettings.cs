using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    public class PlayInfoSettings
    {
        private IEnumerable<Resource> _resourceCost = Enumerable.Empty<Resource>();
        private IEnumerable<ScienceToken> _scienceTokens = Enumerable.Empty<ScienceToken>();
        private IEnumerable<Resource> _resources = Enumerable.Empty<Resource>();
        private IEnumerable<MarketBenefit> _marketBenefits = Enumerable.Empty<MarketBenefit>();
        private int _simplePoints = 0;
        private int _warValue = 0;
        private int _goldCost = 0;

        public PlayInfoSettings() { }

        public Action<GamestateContext> OnFirstPlayed;
        public Func<GamestateContext,int> CalculateComplexPoints;

        public IEnumerable<Resource> Resources
        {
            get { return _resources; }
            set { _resources = value; }
        }

        public IEnumerable<ScienceToken> ScienceTokens
        {
            get { return _scienceTokens; }
            set { _scienceTokens = value; }
        }

        public IEnumerable<MarketBenefit> MarketBenefits
        {
            get { return _marketBenefits; }
            set { _marketBenefits = value; }
        }

        public IEnumerable<Resource> ResourceCost
        {
            get { return _resourceCost; }
            set { _resourceCost = value; }
        }

        public int SimplePoints
        {
            get { return _simplePoints; }
            set { _simplePoints = value; }
        }

        public int WarValue
        {
            get { return _warValue; }
            set { _warValue = value; }
        }

        public int GoldCost
        {
            get { return _goldCost; }
            set { _goldCost = value; }
        }
    }
}
