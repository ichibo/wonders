using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    public class Player
    {
        public Player() 
        {
            Tableau = new CardSet();
        }

        public CardSet Tableau { private set; get; }

        public void PlayCard(BasicCard card)
        {
            Tableau.AddCard(card);
        }
    }
}
