namespace TwoSum{
	public class Solution {
		public int[] TwoSum(int[] nums, int target) {
			int[] temp=new int[nums.Length];
			for (int i=0; i<nums.Length; i++) {
				temp[i]=target-nums[i];
				for(int j=0;j<i;j++){
					if(temp[j]==nums[i]){
						return new int[2]{j+1,i+1};
					}
				}
			}
			return new int[0];
		}
	}
}
