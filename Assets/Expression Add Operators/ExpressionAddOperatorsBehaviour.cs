using UnityEngine;
using System.Collections;

public class ExpressionAddOperatorsBehaviour : MonoBehaviour {
	public string num="232";
	public int target=8;
	void OnGUI(){
		if (GUILayout.Button ("ExpressionAddOperators")) {
			int[] originArray=new int[]{1,2,3,4,5,6,7,8};
			Debug.Log(CommonTool.ArrayToJsonString(originArray));
			int[] indexs=new int[]{1,4,5,7};
			Debug.Log(CommonTool.ArrayToJsonString(indexs));
			int[] temp=ExpressionAddOperatorsSolution.SegmentArrayByIndexs(originArray,indexs);
			Debug.Log(CommonTool.ArrayToJsonString(temp));
		}
	}
}
