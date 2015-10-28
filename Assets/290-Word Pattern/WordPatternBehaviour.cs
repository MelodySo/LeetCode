using UnityEngine;
using System.Collections;

public class WordPatternBehaviour : MonoBehaviour {
	public string pattern="deadbeef";//"deadbeef"

		public string word="all people seem all to need need link";
	void OnGUI(){
		if (GUILayout.Button ("WordPattern")) {
			WordPatternSolution solution=new WordPatternSolution();
			solution.WordPattern(pattern,word);
		}
	}
}
