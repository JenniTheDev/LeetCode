using System;

namespace MedianFinder {
    internal class Program {

        private static void Main(string[] args) {
            MedianFinder medianFinder = new MedianFinder();
            medianFinder.AddNum(1);
            medianFinder.FindMedian();
            medianFinder.AddNum(2);
            medianFinder.FindMedian();
            medianFinder.AddNum(3);
            medianFinder.FindMedian();
            // medianFinder.AddNum(6);
            // medianFinder.FindMedian();
        }
    }
}