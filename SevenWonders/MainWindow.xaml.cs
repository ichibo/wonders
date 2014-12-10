using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SevenWonders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestRoutine2();
        }

        private void TestRoutine()
        {
            List<ScienceToken> tokens = new List<ScienceToken>();
            tokens.Add(ScienceToken.Cog | ScienceToken.Compass | ScienceToken.Tablet);
            tokens.Add(ScienceToken.Cog);
            tokens.Add(ScienceToken.Cog);
            tokens.Add(ScienceToken.Compass);

            StandardPointsManager pointsManager = new StandardPointsManager();
            pointsManager.CalculateSciencePoints(tokens);
        }

        private void TestRoutine2()
        {
            BasicCard card = new SomeCard();
            Console.WriteLine(card.Name);
            Console.WriteLine(card.Age);
            Console.WriteLine(card.Category);
            card.OnFirstPlayed(new GamestateContext(new Player(), new Player(), new Player()));

        }

        public class SomeCard : BasicCard
        {
            public SomeCard()
            {
                PlayInfoSettings settings = new PlayInfoSettings();
                settings.MarketBenefits = new MarketBenefit[] { new MarketBenefit(PlayerDirection.Right, Resource.Brick | Resource.Stone | Resource.Wood | Resource.Ore, 1) };
                settings.Resources = new Resource[] { Resource.Scroll, Resource.Brick };
                settings.OnFirstPlayed = FirstPlay;
                settings.GoldCost = 10;
                PlayInfo = new PlayInfo(settings);

            }

            private void FirstPlay(GamestateContext context) { Console.WriteLine("You played me :)"); }

            public override string Name { get { return "My Card"; } }
            public override CardCategory Category { get { return CardCategory.Market; } }
            public override Age Age { get { return Age.II; } }
        }
    }
}
