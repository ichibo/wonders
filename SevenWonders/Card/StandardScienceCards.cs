using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders.StandardCards.Science
{
    public class Scriptorium : BasicCard
    {
        public Scriptorium()
        {
            PlayInfoSettings settings = new PlayInfoSettings();
            settings.ResourceCost = new Resource[] { Resource.Scroll };
            settings.ScienceTokens = new ScienceToken[] { ScienceToken.Tablet };
            PlayInfo = new PlayInfo(settings);
        }

        public override string Name { get { return "Scriptorium"; } }
        public override CardCategory Category { get { return CardCategory.Science; } }
        public override Age Age { get { return Age.I; } }
    }

    public class Library : BasicCard
    {
        public Library()
        {
            PlayInfoSettings settings = new PlayInfoSettings();
            settings.ResourceCost = new Resource[] { Resource.Stone, Resource.Stone, Resource.Wool };
            settings.ScienceTokens = new ScienceToken[] { ScienceToken.Tablet };
            PlayInfo = new PlayInfo(settings);
        }

        public override string Name { get { return "Library"; } }
        public override CardCategory Category { get { return CardCategory.Science; } }
        public override Age Age { get { return Age.II; } }
    }
}
    
    
