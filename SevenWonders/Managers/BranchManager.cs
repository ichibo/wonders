using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    class BranchManager
    {
        private Dictionary<string, List<string>> _branchesIntoDictionary = new Dictionary<string,List<string>>();
        private Dictionary<string, List<string>> _branchesFromDictionary = new Dictionary<string,List<string>>();

        public IEnumerable<string> CardBranchesFrom(string sourceCard)
        {
            var currentMapping = _branchesFromDictionary[sourceCard];
            if (currentMapping == null) return Enumerable.Empty<string>();
            else return currentMapping;
        }

        public IEnumerable<string> CardBranchesTo(string sourceCard)
        {
            var currentMapping = _branchesIntoDictionary[sourceCard];
            if (currentMapping == null) return Enumerable.Empty<string>();
            else return currentMapping;
        }

        public bool DoesCardBranchInto(string from, string to)
        {
            var currentMapping = _branchesIntoDictionary[from];
            if (currentMapping == null) return false;
            else return currentMapping.Contains(to);
        }

        public void InitializeStandardEntries()
        {
            AddBuildsIntoEntry("Scriptorium", "Library");
            return;
        }

        public void AddBuildsIntoEntry(string from, string to)
        {
            AddEntryForDictionaryFromTo(from, to, _branchesIntoDictionary);
            AddEntryForDictionaryFromTo(to, from, _branchesFromDictionary);
        }

        private void AddEntryForDictionaryFromTo(string source, string target, Dictionary<string, List<string>> dictionary)
        {
            var currentMapping = dictionary[source];

            if (currentMapping == null)
            {
                var newList = new List<string>();
                newList.Add(target);
                dictionary[target] = newList;
            }

            else if (currentMapping.Contains(target)) return;
            else currentMapping.Add(target);
        }
    }
}
