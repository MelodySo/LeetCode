namespace FindMedianSortedArrays{
	public class Solution {
		public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
			int size1 = nums1.Length, size2 = nums2.Length;
			int size = size1 + size2;
			if(size == 0)
			{
				return 0;
			}
			bool isEven = (size % 2 == 0) ? true : false;
			int middle = size / 2;
			int[] allNums=new int[size];
			int start1 = 0, start2 = 0;
			for(int i = 0; i <= middle; i++)   //we don't care about nums after middleIndex
			{
				if(start1 == size1 && start2 != size2)
				{
					allNums[i] = nums2[start2];
					start2++;
					continue;
				}
				if(start1 != size1 && start2 == size2)
				{
					allNums[i] = nums1[start1];
					start1++;
					continue;
				}
				
				if(nums1[start1] <= nums2[start2])
				{
					allNums[i] = nums1[start1];
					start1++;
				}
				else
				{
					allNums[i] = nums2[start2];
					start2++;
				}
			}
			return isEven ? (allNums[middle-1] + allNums[middle])/2.0 : allNums[middle];
		}
	}
}