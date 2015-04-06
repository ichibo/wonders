using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders.StandardCards.Guild
{
    public class WorkersGuild : BasicCard
    {
        public WorkersGuild()
        {
            PlayInfoSettings settings = new PlayInfoSettings();
            settings.CalculateComplexPoints = BasicResourcesCount;
            PlayInfo = new PlayInfo(settings);
        }

        public override string Name { get { return "Workers Guild"; } }
        public override CardCategory Category { get { return CardCategory.Guild; } }
        public override Age Age { get { return Age.III; } }

        private int BasicResourcesCount(GamestateContext context)
        {
            int total = 0;
            total += context.LeftPlayer.Tableau.GetCountOfCardCategory(CardCategory.BasicResource);
            total += context.RightPlayer.Tableau.GetCountOfCardCategory(CardCategory.BasicResource);
            return 0;
        }
    }
}
