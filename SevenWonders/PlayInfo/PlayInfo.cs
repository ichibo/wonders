using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    public class PlayInfo
    {
        private Action<GamestateContext> _onFirstPlayed;
        private Func<GamestateContext, int> _calculateComplexPoints;

        public static readonly PlayInfo Basic = new PlayInfo(new PlayInfoSettings());

        private PlayInfo() { }

        public PlayInfo(PlayInfoSettings settings)
        {
            Resources = settings.Resources;
            ScienceTokens = settings.ScienceTokens;
            MarketBenefits = settings.MarketBenefits;
            ResourceCost = settings.ResourceCost;
            WarValue = settings.WarValue;
            GoldCost = settings.GoldCost;
            _onFirstPlayed = settings.OnFirstPlayed;
            _calculateComplexPoints = settings.CalculateComplexPoints;
        }
        
        public IEnumerable<Resource> Resources { get; private set; }
        public IEnumerable<ScienceToken> ScienceTokens { get; private set; }
        public IEnumerable<MarketBenefit> MarketBenefits { get; private set; }
        public IEnumerable<Resource> ResourceCost { get; private set; }
        public int BasicPoints { get; private set; }
        public int WarValue { get; private set; }
        public int GoldCost { get; private set; }
        
        public void OnFirstPlayed(GamestateContext context)
        {
            if (_onFirstPlayed != null) _onFirstPlayed(context);
        }

        public int GetComplexPoints(GamestateContext context)
        {
            if (_calculateComplexPoints != null) return _calculateComplexPoints(context);
            else return 0;
        }
    }
}
