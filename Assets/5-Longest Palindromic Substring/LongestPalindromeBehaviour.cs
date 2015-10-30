using UnityEngine;
using System.Collections;
using LongestPalindrome;
public class LongestPalindromeBehaviour : MonoBehaviour {
	LongestPalindrome.Solution solution=new LongestPalindrome.Solution();
	public string str;
	void OnGUI(){
		if (GUILayout.Button ("LongestPalindrome:"+str)) {
			Debug.Log(solution.LongestPalindrome(str));
		}
	}
}

