using System.Collections.Generic;
using UnityEngine;
namespace FindMedianFromDataStream{
	public class MedianFinder {
		List<double> list=new List<double>();
		// Adds a num into the data structure.
		public void AddNum(double num) {// binary search
			int i = 0;
			int j = list.Count-1;
			while (i<=j) {
				int mid = (j-i)/2 + i;
				if (list[mid] <= num) {
					i = mid + 1;
				} 
				else {
					j = mid - 1;
				}
			}
			list.Insert (i, num);
		}
		
		// return the median of current data stream
		public double FindMedian() {
			if (list.Count % 2 == 0) {
				return (list [list.Count / 2] + list [list.Count / 2 - 1]) / 2d;
			}
			else
				return list [list.Count / 2];
		}
	}
	
	// Your MedianFinder object will be instantiated and called as such:
	// MedianFinder mf = new MedianFinder();
	// mf.AddNum(1);
	// mf.FindMedian();
}