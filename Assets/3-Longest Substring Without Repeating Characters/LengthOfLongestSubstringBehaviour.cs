using UnityEngine;
using System.Collections;
using LengthOfLongestSubstring;
public class LengthOfLongestSubstringBehaviour : MonoBehaviour {
	LengthOfLongestSubstring.Solution solution=new LengthOfLongestSubstring.Solution();
	public string str;
	void OnGUI(){
		if (GUILayout.Button ("LengthOfLongestSubstring:"+str)) {
			Debug.Log(solution.LengthOfLongestSubstring(str));
		}
	}
}
