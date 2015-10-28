using UnityEngine;
using System.Collections;
using TwoSum;
public class TwoSumBehaviour : MonoBehaviour {
	TwoSum.Solution solution=new TwoSum.Solution();
	public int[] num;
	public int target;
	void OnGUI(){
		if (GUILayout.Button ("TwoSum:"+CommonTool.ArrayToJsonString(num)+",Target:"+target)) {
			int[] result=solution.TwoSum(num,target);
			Debug.Log(CommonTool.ArrayToJsonString(result));
		}
	}
}