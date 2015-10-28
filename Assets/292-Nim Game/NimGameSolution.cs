using UnityEngine;
using System.Collections;
namespace NimGame{
	//1: true
	public class Solution{
		public bool CanWinNim(int n){
			return n % 4 != 0;
		}
	}
}