using UnityEngine;
using System.Collections;
using System.Text;
public class CommonTool{
	public static string ArrayToJsonString<T>(T[] array){
		StringBuilder sb = new StringBuilder ();
		sb.Append ('[');
		for (int i=0; i<array.Length; i++) {
			sb.Append(array[i]);
			sb.Append(',');
		}
		sb.Remove (sb.Length - 1, 1);
		sb.Append (']');
		return sb.ToString ();
	}
}
