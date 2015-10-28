namespace UglyNumber{
	public class Solution {
		public bool IsUgly(int num) {
			if (num == 1)
				return true;
			else {
				if(num%2==0){
					return IsUgly(num/2);
				}
				else if(num%3==0){
					return IsUgly(num/3);
				}
				else if(num%5==0){
					return IsUgly(num/5);
				}
				else
					return false;
			}
		}
	}
}