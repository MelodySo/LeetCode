namespace LongestPalindrome{
	public class Solution {
		public string LongestPalindrome(string s) {
			string T="";// Transform S to T
			for (int i=0; i<s.Length; i++)
				T += "#" + s [i];
			T += "#";
			int[] P=new int[T.Length]; // Array to record longest palindrome
			int center = 0, boundary = 0, maxLen = 0, resCenter = 0;
			for(int i=1;i<T.Length-1;i++) {
				int iMirror=2*center-i; // calc mirror i = center-(i-center)
			P[i]=(boundary>i)?System.Math.Min(boundary-i,P[iMirror]):0; // shortcut
				while(i-1-P[i]>=0&&i+1+P[i]<=T.Length-1&&T[i+1+P[i]] == T[i-1-P[i]]) // Attempt to expand palindrome centered at i
					P[i]++;
				if(i+P[i]>boundary) { // update center and boundary
					center = i;
					boundary = i+P[i];
				}
				if(P[i]>maxLen) { // update result
					maxLen = P[i];
					resCenter = i;
				}    
			}
			return s.Substring((resCenter - maxLen)/2, maxLen);
		}
	}
}
