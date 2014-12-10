using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    public abstract class BasicCard
    {
        private PlayInfo _playInfo = PlayInfo.Basic;

        public abstract string Name { get; }
        public abstract Age Age { get; }
        public abstract CardCategory Category { get; }

        public PlayInfo PlayInfo
        {
            get { return _playInfo; }
            protected set { _playInfo = value; }
        }

        public virtual void OnFirstPlayed(GamestateContext context)
        {
            PlayInfo.OnFirstPlayed(context);
        }

        public virtual int GetComplexPoints(GamestateContext context)
        {
           return PlayInfo.GetComplexPoints(context);
        }
    }
}
