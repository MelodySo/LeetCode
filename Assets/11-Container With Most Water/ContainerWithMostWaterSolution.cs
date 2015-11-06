using System;
namespace ContainerWithMostWater{
	public class Solution {
		public int MaxArea(int[] height) {
			int len = height.Length, low = 0, high = len -1 ;  
			int maxArea = 0;  
			while (low < high) {  
				maxArea = Math.Max(maxArea, (high - low) * Math.Min(height[low], height[high]));  
				if (height[low] < height[high]) {  
					low++;  
				} else {  
					high--;  
				}  
			}
			return maxArea;  
		}
	}
}
