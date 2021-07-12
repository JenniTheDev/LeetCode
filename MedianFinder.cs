using System;

public class MedianFinder{
	
        List<int> listOfNums;

        /** initialize your data structure here. */
        public MedianFinder() {
            listOfNums = new List<int>();
        }

        public void AddNum(int num) {
            listOfNums.Add(num);
        }

        public double FindMedian() {
            if (listOfNums.Count <= 0) {
                return 0;
            }
            // If list is even number, add two middle numbers and divide by 2
            if (listOfNums.Count % 2 == 0) {
                int middleIndex = listOfNums.Count / 2;
                return (listOfNums[middleIndex] + listOfNums[middleIndex - 1]) / 2;
                // If list is an odd number, return the middle number     
            } else {
                int middleIndex = (listOfNums.Count / 2) + 1;
                return listOfNums[listOfNums.Count / 2];
            }
        }
    
}
