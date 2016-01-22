using UnityEngine;
using System.Collections;
using RomanToInteger;
public class RomanToIntegerBehaviour : MonoBehaviour {
	RomanToInteger.Solution solution=new RomanToInteger.Solution();
	public string roman;
	void OnGUI(){
#if UNITY_EDITOR
		int n=0;
#endif
		if (GUILayout.Button ("RomanToInteger:"+roman)) {
			Debug.Log(solution.RomanToInt(roman));
		}
	}
}
