using System.Collections.Generic;
using System.Collections;
using UnityEngine;
public class WordPatternSolution {
	// pattern="caabbcdd"
	//test ="him test test love love him her her"
	//set the pattern to the law:05,12,34,67,then validate the law to the other one.
	public bool WordPattern(string pattern,string word){
		List<char> charList = new List<char> (pattern.ToCharArray ());
		List<string> wordList = new List<string> (word.Split(' '));
		string patternLaw = GetLaw<char> (charList);
		string wordLaw = GetLaw<string> (wordList);
		Debug.Log ("patternLaw:\t" + patternLaw);
		//Debug.Log ("wordLaw:\t" + wordLaw);
		Debug.Log ("is equals:" + (patternLaw == wordLaw));
		return patternLaw==wordLaw;
	}
	string GetLaw<T>(List<T> list)
	{
		string sum="";
		List<int> indexList=new List<int>();
		for (int i=0; i<list.Count; i++) {
			if(indexList.Contains(i))
				continue;
			Debug.Log(i+","+list[i]);
			indexList.Add(i);
			sum+=i;
			for (int j=i+1;j<list.Count;j++){
				if(indexList.Contains(j))
					continue;
				Debug.Log("j="+j);
				if(list[i].ToString()==list[j].ToString()){
					Debug.Log(j+","+list[j]);
					indexList.Add(j);
					sum+=j;
				}
			}
			sum+=',';
		}
		return sum;
	}

}
