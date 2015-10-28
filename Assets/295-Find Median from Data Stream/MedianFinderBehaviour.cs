using UnityEngine;
using System.Collections;
using FindMedianFromDataStream;
public class MedianFinderBehaviour : MonoBehaviour {
	FindMedianFromDataStream.MedianFinder medianFinder=new FindMedianFromDataStream.MedianFinder();
	public double[] num;
	void OnGUI(){
		if (GUILayout.Button ("MedianFinder:"+CommonTool.ArrayToJsonString(num))) {
			foreach(double d in num)
				medianFinder.AddNum(d);
			Debug.Log("Median:"+medianFinder.FindMedian());
		}
	}
}