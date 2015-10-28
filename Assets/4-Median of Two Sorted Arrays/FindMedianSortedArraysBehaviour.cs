using UnityEngine;
using System.Collections;
using FindMedianSortedArrays;
public class FindMedianSortedArraysBehaviour : MonoBehaviour {
	void Awake(){
		Debug.Log ("Awake");
	}
	void Start(){
		Debug.Log ("Start");
	}
	FindMedianSortedArrays.Solution solution=new FindMedianSortedArrays.Solution();
	public int[] nums1;
	public int[] nums2;
	void OnGUI(){
		if (GUILayout.Button (string.Format(
			"FindMedianSortedArrays:,nums1:{0},nums2:{1}"
			,CommonTool.ArrayToJsonString(nums1),
			CommonTool.ArrayToJsonString(nums2)))) {
			Debug.Log(solution.FindMedianSortedArrays(nums1,nums2));
		}
	}
}
