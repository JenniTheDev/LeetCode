using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/distribute-candies/

namespace Distribute_Candies {
    internal class Solution {

        public int DistributeCandies(int[] candyType) {
            int numToEat = candyType.Length;
            numToEat = numToEat / 2;

            HashSet<int> testTypes = new HashSet<int>();

            for (int i = 0; i < candyType.Length; i++) {
                testTypes.Add(candyType[i]);
            }

            if (numToEat <= testTypes.Count) {
                return numToEat;
            } else if (numToEat > testTypes.Count) {
                return testTypes.Count;
            } else return 0;
        }
    }
}