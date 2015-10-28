using UnityEngine;
using System.Collections;
using NimGame;
public class NimGameBehaviour : MonoBehaviour {
	NimGame.Solution solution=new NimGame.Solution();
	public int num;
	void OnGUI(){
		if (GUILayout.Button ("NimGame:"+num)) {
			Debug.Log(solution.CanWinNim(num));
			Debug.Log(num%4);
		}
	}
}
