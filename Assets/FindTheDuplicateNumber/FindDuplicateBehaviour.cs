using UnityEngine;
using System.Collections;
using FindDuplicate;
public class FindDuplicateBehaviour : MonoBehaviour {
	public int[] array;
	FindDuplicate.Solution solution=new FindDuplicate.Solution();
	void OnGUI(){
		if (GUILayout.Button ("FindDuplicate:"+array.Length)) {
			Debug.Log(solution.FindDuplicate(array));
		}
	}
}
