namespace MissingNumber{
	//0,1,2,3,4,5
	public class Solution {
		public int MissingNumber(int[] nums) {
			int length = nums.Length;
			int sum = (length) * (length + 1) / 2;
			for (int i=0; i<length; i++) {
				sum-=nums[i];
			}
			return sum;
		}
	}
}