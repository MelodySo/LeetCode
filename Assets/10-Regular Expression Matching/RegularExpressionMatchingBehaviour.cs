using UnityEngine;
using System.Collections;
using RegularExpressionMatching;
public class RegularExpressionMatchingBehaviour : MonoBehaviour {
	RegularExpressionMatching.Solution solution=new RegularExpressionMatching.Solution();
	public string str1;
	public string str2;
	void OnGUI(){
		if (GUILayout.Button (string.Format("RegularExpressionMatching:string:\"{0}\",pattern:\"{1}\"",str1,str2))) {
			Debug.Log(solution.IsMatch(str1,str2));
		}
	}
}
