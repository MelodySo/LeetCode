using UnityEngine;
using System.Collections;
public class Solution {
	public int[,] b;
	public void Do(){
		GameOfLife (b);
		Debug.Log (b);
	}
	void PrintArray(int[,] array){

	}
	public void GameOfLife(int[,] board) {
		Board board2 = new Board (board);
		int row = board.GetLength (0);
		int col = board.GetLength (1);
		int[,] temp=new int[board.GetLength(0),board.GetLength(1)];
		
		for (int i=0; i<row; i++)
		for (int j=0; j<col; j++) {
			temp[i,j]=board[i,j];
		}
		for (int i=0; i<row; i++)
		for (int j=0; j<col; j++) {
			int count=board2.GetAdjacentPointCount(i,j);
			if(board[i,j]==1){
				if(count<2){//0 or 1
					temp[i,j]=0;
				}
				else if(count<4){//2 or 3
					temp[i,j]=1;
				}
				else if(count>3){//3,4,5,6,7,8
					temp[i,j]=0;
				}
			}
			else if(count ==3){
				temp[i,j]=1;
			}
		}
		board = temp;
		b = temp;
	}
}
