using UnityEngine;
using System.Collections;
using ReverseInteger;
public class ReverseIntegerBehaviour : MonoBehaviour {
	ReverseInteger.Solution solution=new ReverseInteger.Solution();
	public int num;
	void OnGUI(){
		if (GUILayout.Button ("ReverseInteger:"+num)) {
			Debug.Log(solution.Reverse(num));
		}
	}
}
