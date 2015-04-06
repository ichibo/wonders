using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    public interface IWarManager
    {
        public void ResolveWar(GamestateContext context);
    }

    public class StandardWarManager : IWarManager
    {
        public void ResolveWar(GamestateContext context)
        {
            // Loop on each player, get left/right.  FIGHT FIGHT FIGHT!!
            // Skip players spending a war token.
            // Pass out war tokens to victory and minus tokens to losers.
            return;
        }
    }
}
