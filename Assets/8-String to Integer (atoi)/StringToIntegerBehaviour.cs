using UnityEngine;
using System.Collections;
using StringToInteger;
public class StringToIntegerBehaviour : MonoBehaviour {
	StringToInteger.Solution solution=new StringToInteger.Solution();
	public string str;
	void OnGUI(){
		if (GUILayout.Button ("StringToInteger:"+str)) {
			Debug.Log(solution.MyAtoi(str));
		}
	}
}
