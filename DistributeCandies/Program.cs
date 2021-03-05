// For LeetCode Challenge 3/4/21
/*Alice has n candies, where the ith candy is of type candyType[i].
  Alice noticed that she started to gain weight, so she visited a doctor.
  The doctor advised Alice to only eat n / 2 of the candies she has (n is always even).
  Alice likes her candies very much, and she wants to eat the maximum number of different
  types of candies while still following the doctor's advice.

  Given the integer array candyType of length n,
  return the maximum number of different types of candies she can eat if she only eats n / 2 of them.
*/

namespace DistributeCandies {
    internal class Program {

        private static void Main(string[] args) {
            // Some backend LeetCode Stuff here
        }

        public class Solution {

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
}