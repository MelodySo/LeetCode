using UnityEngine;
using System.Collections;
using MissingNumber;
public class MissingNumberBehaviour : MonoBehaviour {
	public int[] array;
	MissingNumber.Solution solution=new MissingNumber.Solution();
	void OnGUI(){
		if (GUILayout.Button ("MissingNumber:"+array.Length)) {
			Debug.Log(solution.MissingNumber(array));
		}
	}
}
