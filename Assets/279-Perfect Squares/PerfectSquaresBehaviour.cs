using UnityEngine;
using System.Collections;

public class PerfectSquaresBehaviour : MonoBehaviour {
	PerfectSquares.Solution solution=new PerfectSquares.Solution();
	public int num;
	void OnGUI(){
		if (GUILayout.Button ("PerfectSquares:"+num)) {
			Debug.Log(solution.NumSquares(num));
		}
	}
}
