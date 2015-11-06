using UnityEngine;
using System.Collections;
using PalindromeNumber;
public class PalindromeNumberBehaviour : MonoBehaviour {
	PalindromeNumber.Solution solution=new PalindromeNumber.Solution();
	public int num;
	void OnGUI(){
		if (GUILayout.Button ("PalindromeNumber:"+num)) {
			Debug.Log(solution.IsPalindrome(num));
		}
	}
}