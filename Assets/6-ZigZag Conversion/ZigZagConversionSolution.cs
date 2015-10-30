namespace ZigZagConversion{
	public class Solution {
		/*
		public string Convert(string s, int numRows) {
			char[] finalString=new char[s.Length];
			for (int i=0,j=1; i<s.Length; i++) {
				int index=ConvertColToIndex(i,numRows,s.Length);
				finalString[index]=s[i];
			}
			return new string(finalString);
		}
		int ConvertColToIndex(int col,int height,int length){
			int index = col;
			int periodLength = 2 * (height - 1);
			int localBlock = col / periodLength;
			int localIndex = col - localBlock * periodLength;
			int localRow = localIndex > height - 1 ? periodLength - localIndex : localIndex;
			int lastLocalIndex = length % periodLength;
			return index;
		}*/
		public string Convert(string s, int numRows) {
			int length = s.Length;
			System.Text.StringBuilder[] sb = new System.Text.StringBuilder[numRows];
			for (int i = 0; i < sb.Length; i++) 
				sb[i] = new System.Text.StringBuilder();
			int k = 0;
			while (k < length) {
				for (int idx = 0; idx < numRows && k < length; idx++) // vertically down
					sb[idx].Append(s[k++]);
				for (int idx = numRows-2; idx >= 1 && k < length; idx--) // obliquely up
					sb[idx].Append(s[k++]);
			}
			for (int i = 1; i < sb.Length; i++) {
				sb [0].Append (sb [i].ToString ());
			}
			return sb[0].ToString();

		}

	}
}