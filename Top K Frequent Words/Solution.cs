using System;
using System.Collections.Generic;

// https://leetcode.com/problems/top-k-frequent-words/
namespace Top_K_Frequent_Words {
    internal class Solution {

        public IList<string> TopKFrequent(string[] words, int k) {
            List<string> mostFrequentWords = new List<string>();
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words) {
                int count;
                if (wordCount.TryGetValue(word, out count)) {
                    wordCount[word] = count + 1;
                } else {
                    wordCount.Add(word, 1);
                }
            }

            // check for k highest values, add key to mostFrequentWords
            int numSeen = 0;
            Dictionary<int, List<string>> groupByValue = new Dictionary<int, List<string>>();

            foreach (var pair in wordCount) {
                numSeen = Math.Max(numSeen, pair.Value);
                if (!groupByValue.ContainsKey(pair.Value)) {
                    groupByValue[pair.Value] = new List<string>() { pair.Key };
                } else {
                    groupByValue[pair.Value].Add(pair.Key);
                }
            }

            while (k > 0) {
                while (!groupByValue.ContainsKey(numSeen)) numSeen--;
                groupByValue[numSeen].Sort();
                foreach (var item in groupByValue[numSeen]) {
                    mostFrequentWords.Add(item);
                    if (--k == 0) {
                        break;
                    }
                    groupByValue.Remove(numSeen);
                }
            }

            return mostFrequentWords;
        }
    }
}