using UnityEngine;
using System.Collections;
using UglyNumber;
public class UglyNumberBehaviour : MonoBehaviour {
	UglyNumber.Solution solution=new UglyNumber.Solution();
	public int num;
	void OnGUI(){
		if (GUILayout.Button ("UglyNumber:"+num)) {
			Debug.Log(solution.IsUgly(num));
		}
	}
}