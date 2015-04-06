using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    public interface IPointsManager
    {
        int CalculateTotalPoints(GamestateContext context);
    }

    public class StandardPointsManager : IPointsManager
    {
        public static IEnumerable<ScienceToken> ScienceTokenTypes = Enum.GetValues(typeof(ScienceToken))
                                                            .Cast<ScienceToken>();

        public int CalculateTotalPoints(GamestateContext context)
        {
            return 0;
        }

        // Passed in science tokens can be multi-token flags and not single discrete items.
        // They will be broken up internally as needed.
        public int CalculateSciencePoints(IEnumerable<ScienceToken> tokens) 
        {             
            var baseTokenList = new List<ScienceToken>(tokens);
            var expandedTokenLists = new List<List<ScienceToken>>();

            GenerateTokenCombinations(new List<ScienceToken>(), baseTokenList, expandedTokenLists);

            int highestPoints = 0;
            IEnumerable<ScienceToken> winningSet = null;

            foreach (List<ScienceToken> expandedTokenList in expandedTokenLists)
            {
                int currentTokenSetPoints = ScoreOneScienceTokenSet(expandedTokenList);
                if (currentTokenSetPoints > highestPoints) 
                {
                    highestPoints = currentTokenSetPoints;
                    winningSet = expandedTokenList;
                }
            }

            if(winningSet != null)
            {
                foreach (var token in winningSet)
                {
                    Console.WriteLine(token.ToString());
                }
            }
            return highestPoints;
        }

        private void GenerateTokenCombinations(List<ScienceToken> currentList, List<ScienceToken> remainingTokens, List<List<ScienceToken>> outputList)
        {
            if (remainingTokens.Count() == 0) outputList.Add(currentList);

            else
            {
                ScienceToken currentMultiToken = remainingTokens[0];
                var newRemainingTokens = new List<ScienceToken>(remainingTokens);
                newRemainingTokens.Remove(currentMultiToken);

                var possibleTokens = ScienceTokenTypes.Where(value => currentMultiToken.HasFlag(value));

                // If our possibleTokens list has no valid tokens, then an invalid token enum exists.
                // Don't create any new entries, the list is bugged so kill off this branch of recursion.
                foreach (ScienceToken concreteToken in possibleTokens)
                {
                    var newTokenList = new List<ScienceToken>(currentList);
                    newTokenList.Add(concreteToken);
                    GenerateTokenCombinations(newTokenList, newRemainingTokens, outputList);
                }
            }
        }

        /*
        private int GetMaxTokenScore(IEnumerable<ScienceToken> currentList, IEnumerable<ScienceToken> remainingTokens)
        {
            if (remainingTokens.Count() == 0) return ScoreOneScienceTokenSet(currentList);

            else
            {
                ScienceToken currentBaseToken = remainingTokens.First();
                var newRemainingTokens = new List<ScienceToken>(remainingTokens);
                newRemainingTokens.Remove(currentBaseToken);

                int bestScore = 0;

                var possibleTokens = ScienceTokenTypes
                    .Where(value => currentBaseToken.HasFlag(value));

                foreach (ScienceToken concreteToken in possibleTokens)
                {
                    var newList = new List<ScienceToken>(currentList);
                    newList.Add(concreteToken);
                    int lineScore = GetMaxTokenScore(newList, newRemainingTokens);
                    if (lineScore > bestScore) bestScore = lineScore;
                }

                return bestScore;
            }
        }
         * */

        public int ScoreOneScienceTokenSet(IEnumerable<ScienceToken> tokens)
        {
            int total = 0;
            int tablets = 0;
            int compasses = 0;
            int wheels = 0;

            foreach (ScienceToken t in tokens)
            {
                if (t == ScienceToken.Tablet) tablets++;
                else if (t == ScienceToken.Compass) compasses++;
                else if (t == ScienceToken.Cog) wheels++;
            }

            int sets = Math.Min(tablets, Math.Min(compasses, wheels));

            total += sets * 7;
            total += (int)Math.Pow(tablets, 2);
            total += (int)Math.Pow(compasses, 2);
            total += (int)Math.Pow(wheels, 2);

            return total;
        }

        public int CalculateBasicPoints(GamestateContext context)
        {
            // return context.MainPlayer.Tableau.Sum<BasicAgeCard>
            int total = 0;
            return total;
        }

        public int CalculateComplexPoints(GamestateContext context) 
        {
            // foreach(Card card in Player.Tableau)
            // total += card.GetComplexPoints(context);
            return 0;
        }

        public int CalculateWarPoints(IEnumerable<WarToken> tokens)
        {
            return tokens.Sum<WarToken>(x => x.Value);
        }

        public int CalculateWonderPoints(GamestateContext context)
        {
            // context.MainPlayer.Wonder.GetPoints();
            return 0;
        }
    }
}
