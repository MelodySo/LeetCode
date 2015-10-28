namespace LengthOfLongestSubstring{
	public class Solution {
		public int LengthOfLongestSubstring(string s) {
			int[] asciiArray=new int[256];
			for (int i=0; i<asciiArray.Length; i++) {
				asciiArray[i]=-1;
			}
			int length = s.Length;
			if (length == 0)
				return 0;
			int temp = 1;
			int ans = 1;
			asciiArray [s [0]] = 0;
			for (int i=1; i<length; i++) {
				int lastApp = asciiArray [s [i]];
				if (lastApp == -1)
					temp++;
				else
					temp = System.Math.Min (temp + 1, i - lastApp);
				asciiArray [s [i]] = i;
				ans = System.Math.Max (ans, temp);
			}
			return ans;
		}
	}
}
