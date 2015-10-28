namespace FindMedianSortedArrays{
	public class Solution {
		public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
			int[] finalArray=new int[nums1.Length+nums2.Length];
			int left1 = 0, right1 = nums1.Length-1, left2 = 0, right2 = nums2.Length-1;
			if (right1 + right2 == -2)
				return 0;
			else if (right1 == -1) {
				return FindMedianSortedArrays(nums2,left2,right2);
			}
			else if (right2 == -1) {
				return FindMedianSortedArrays(nums1,left1,right1);
			}
			while (right1-left1+right2-left2>1) {
				double median1=FindMedianSortedArrays(nums1,left1,right1);
				double median2=FindMedianSortedArrays(nums2,left2,right2);
				bool greater=median1>median2;
				int count1=right1-left1+1;
				int count2=right2-left2+1;
				if(greater){
					if((count1)*2<count2){
						right2-=count1;
						return FindMedianSortedArrays(nums2,left2,right2);
					}
					else if((count2)*2<count1){
						left1+=count2;
						return FindMedianSortedArrays(nums1,left1,right1);
					}
					else{
						right1=(left1+right1)/2;
						left2=(left2+right2)/2;
					}
				}
				else{
					if((count1)*2<count2){
						left2+=count1;
						return FindMedianSortedArrays(nums2,left2,right2);
					}
					else if((count2)*2<count1){
						right1-=count2;
						return FindMedianSortedArrays(nums1,left1,right1);
					}
					else{
						right2=(left2+right2)/2;
						left1=(left1+right1)/2;
					}
				}
			}
			if (left1 == right1 && left2 == right2)
				return (nums1 [left1] + nums2 [left2]) / 2d;
			if (left1 == right1)
				return (nums2 [left2] + nums2 [right2]) / 2d;
			else if (left2 == right2)
				return (nums1 [left1] + nums1 [right1]) / 2d;
			else
				return 0;
		}
		private double FindMedianSortedArrays(int[] nums,int left,int right){
			//0<=left<=right<=nums.Length
			int n = right-left;
			if (n % 2 == 0) 
				return nums [(right + left) / 2];
			else
				return (nums [(right + left) / 2] + nums [(right + left) / 2 + 1]) / 2d;
		}
	}
}