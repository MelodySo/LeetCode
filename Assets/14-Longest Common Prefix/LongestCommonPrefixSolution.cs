using System.Collections.Generic;
namespace LongestCommonPrefix{
	public class Solution {
		public string LongestCommonPrefix(string[] strs) {
			if (strs.Length == 0)
				return string.Empty;
			List<char> list = new List<char> ();
			//i:第i个字符
			for (int i = 0; strs[0].Length>i; i++) {
				char temp = strs [0] [i];
				for (int j=0; j < strs.Length; j++) {
					if (string.IsNullOrEmpty (strs [j])) {
						return new string (list.ToArray ());	
					}
					else if (strs [j].Length <= i) {
						return new string (list.ToArray ());
					}
					else if (strs [j] [i] == temp) {
						continue;
					}
					else {
						return new string (list.ToArray ());					
					}
				}
				list.Add (temp);
			}
					
			return new string (list.ToArray ());
		}
	}
}
	