using UnityEngine;
using System.Collections;
using IntegerToRoman;
public class IntegerToRomanBehaviour : MonoBehaviour {
	IntegerToRoman.Solution solution=new IntegerToRoman.Solution();
	public int num;
	void OnGUI(){
		if (GUILayout.Button ("IntegerToRoman:"+num)) {
			Debug.Log(solution.IntToRoman(num));
		}
	}
}
