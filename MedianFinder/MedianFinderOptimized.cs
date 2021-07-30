using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode {
    internal class MedianFinder {
        private List<int> listOfNums;

        /** initialize your data structure here. */

        public MedianFinder() {
            listOfNums = new List<int>();
        }

        public void AddNum(int num) {
            // listOfNums.Add(num);
            Console.WriteLine($"Added {num}");
            var i = listOfNums.BinarySearch(num);
            if (i < 0)
                listOfNums.Insert(~i, num);
            else
                listOfNums.Insert(i, num);
        }

        public double FindMedian() {
            if (listOfNums.Count <= 0) {
                return 0;
            }
            listOfNums.Sort();
            // If list is even number, add two middle numbers and divide by 2
            if (listOfNums.Count % 2 == 0) {
                int middleIndex = listOfNums.Count / 2;
                Console.WriteLine($"Middle index is {middleIndex}");
                Console.WriteLine($"adding {listOfNums[middleIndex]} & {listOfNums[middleIndex - 1]}");

                double median = (listOfNums[middleIndex] + listOfNums[middleIndex - 1]) / 2d;
                Console.WriteLine($"Even list retun is {median:C2}");
                return median;
            } else {
                int middleIndex = (listOfNums.Count / 2);
                Console.WriteLine($"Returning for Odd is {listOfNums[listOfNums.Count / 2]}");
                return listOfNums[listOfNums.Count / 2];
            }
        }
    }
}