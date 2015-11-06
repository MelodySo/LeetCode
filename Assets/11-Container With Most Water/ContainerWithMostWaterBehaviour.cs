using UnityEngine;
using System.Collections;
using ContainerWithMostWater;
public class ContainerWithMostWaterBehaviour : MonoBehaviour {
	ContainerWithMostWater.Solution solution=new ContainerWithMostWater.Solution();
	public int[] nums;
	void OnGUI(){
		if (GUILayout.Button ("ContainerWithMostWater:"+CommonTool.ArrayToJsonString(nums))) {
			Debug.Log(solution.MaxArea(nums));
		}
	}
}
