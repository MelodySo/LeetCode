using UnityEngine;
using System.Collections;

public class Board {
	public int[,] array;
	public Board(int[,] _array){
		array = _array;
	}
	int GetTopPoint(int x,int y){
		if(OnTop(y)){
			return 0;
		}
		return array [x, y + 1];
	}
	int GetBottomPoint(int x,int y){
		if(OnBottom(y)){
			return 0;
		}
		return array [x, y - 1];
	}
	int GetLeftPoint(int x,int y){
		if(OnLeft(x)){
			return 0;
		}
		return array [x - 1, y];
	}
	int GetRightPoint(int x,int y){
		if(OnRight(x)){
			return 0;
		}
		return array [x + 1, y];
	}
	int GetLeftTopPoint(int x,int y){
		if (OnLeft (x) || OnTop (y)) 
			return 0;
		return array [x - 1, y + 1];
	}
	int GetLeftBottomPoint(int x,int y){
		if (OnLeft (x) || OnBottom (y)) 
			return 0;
		return array [x - 1, y - 1];
	}
	int GetRightTopPoint(int x,int y){
		if (OnRight (x) || OnTop (y)) 
			return 0;
		return array [x + 1, y + 1];
	}	
	int GetRightBottomPoint(int x,int y){
		if (OnRight (x) || OnBottom (y)) 
			return 0;
		return array [x + 1, y - 1];
	}
	bool OnTop(int y){
		return y == array.GetLength(1)-1;
	}
	bool OnBottom(int y){
		return y == 0;
	}
	bool OnLeft(int x){
		return x == 0;
	}
	bool OnRight(int x){
		return x == array.GetLength(0)-1;
	}
	public int GetAdjacentPointCount(int x,int y){
		return GetLeftPoint (x, y) + GetRightPoint (x, y) + GetTopPoint (x, y)
			+ GetBottomPoint (x, y) + GetLeftTopPoint (x, y) + GetRightTopPoint (x, y)
			+ GetLeftBottomPoint (x, y) + GetRightBottomPoint (x, y);
	}
}
