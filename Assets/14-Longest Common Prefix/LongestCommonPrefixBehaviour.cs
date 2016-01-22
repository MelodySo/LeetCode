using UnityEngine;
using System.Collections;
using LongestCommonPrefix;
public class LongestCommonPrefixBehaviour : MonoBehaviour {
	LongestCommonPrefix.Solution solution=new LongestCommonPrefix.Solution();
	public string[] strs;
	void OnGUI(){
		if (GUILayout.Button ("LongestCommonPrefix:"+CommonTool.ArrayToJsonString(strs))) {
			Debug.Log(solution.LongestCommonPrefix(strs));
		}
	}
}
