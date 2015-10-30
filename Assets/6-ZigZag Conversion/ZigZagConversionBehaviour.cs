using UnityEngine;
using System.Collections;
using ZigZagConversion;
public class ZigZagConversionBehaviour :MonoBehaviour{
	ZigZagConversion.Solution solution=new ZigZagConversion.Solution();
	public int num;
	public string str;
	void OnGUI(){
		if (GUILayout.Button (string.Format("ZigZagConversion:string:\"{0}\",rows:{1}",str,num))) {
			Debug.Log(solution.Convert(str,num));
		}
	}
}