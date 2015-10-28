using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
//12345678
public class ExpressionAddOperatorsSolution
{
	//"123",6 -> ["1+2+3","1*2*3]
	//"105",5 -> ["1*0+5","10-5"]
	//"3456237490",9191 -> []
	//"232",8 -> ["2*3+2","2+3*2"]
	public IList<string> AddOperators(string num,int target){
		char[] charArray = num.ToCharArray ();
		List<int> numList = new List<int> (charArray.Length);
		for (int i=0; i<charArray.Length; i++) {
			numList[i]=charArray[i]-48;
		}
		return null;
	}
	public static List<int> SegmentList (List<int> originList,int m){//m: space number.
		int n = originList.Count;
		if (m > n)
			return null;
		List<int> finalList = new List<int> (originList.Count);
		int totalPailie = C (n, m);
		for (int i=0; i<totalPailie; i++) {
			//finalList[i]
		}
		//int m = 0;

		return null;
	}
	//12 345 6 78   -1 [1 4 5 7]
	//originArray[n],we must add the value n-1 at the last value of indexs[] before calculating
	public static int[] SegmentArrayByIndexs(int[] originArray,int[] indexs){
		int temp = 0;
		int[] finalArray=new int[indexs.Length];
		for (int i=0; i<indexs.Length; i++) {
			//originArray index: indexs[i]
			int index=i==0?-1:indexs[i-1];
			int[] tempArray=new int[indexs[i]-(index)];
			for(int j=0;j<tempArray.Length;j++){
				tempArray[j]=originArray[(index)+j+1];
			}
			finalArray[i]=ArrayToInt(tempArray);
		}
		return finalArray;
	}
	public static int ArrayToInt(int[] array){
		int n = array.Length;
		int number = 0;
		for (int i=n-1; i>=0; i--) {
			//TODO: if array[i]>9 or array[i]<0,throw an exception.
			number += array [i] * Convert.ToInt32(Math.Pow (10, (n - 1 - i)));
		}
		return number;
	}
	public static int C(int n,int m){
		return JieCheng(n)/(JieCheng(n-m)*JieCheng(m));
	}
	public static int C(int n,int m,out int[,] selectArray){
		int total = C (n, m);
		selectArray=new int[total,m];

		for (int i=0; i<total; i++) {
			for(int j=0;j<m;j++){

			}
		}
		return total;
	}
	public static int JieCheng(int n){
		int mul=1;
		for(int i=n;i>1;i--){
			mul*=i;
		}
		return mul;
	}

}
