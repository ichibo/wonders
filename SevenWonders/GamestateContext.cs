using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    public class GamestateContext
    {
        public Player MainPlayer { get; private set; }
        public Player LeftPlayer { get; private set; }
        public Player RightPlayer { get; private set; }
        public IEnumerable<Player> OtherPlayers { get; private set; }

        public GamestateContext(Player main, Player left, Player right)
        {
            Initialize(main, left, right, Enumerable.Empty<Player>());
        }

        public GamestateContext(Player main, Player left, Player right, IEnumerable<Player> others)
        {
            Initialize(main, left, right, others);
        }

        private void Initialize(Player main, Player left, Player right, IEnumerable<Player> others)
        {
            MainPlayer = main;
            LeftPlayer = left;
            RightPlayer = right;
            OtherPlayers = others;
        }
    }
}
