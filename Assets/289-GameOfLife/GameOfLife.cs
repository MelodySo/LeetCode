using UnityEngine;
using System.Collections;

public class GameOfLife : MonoBehaviour {
	void OnGUI(){
		if (GUILayout.Button ("Begin")) {
			Begin();
		}
	}
	public TextAsset text;
	Solution s;
	public Material blackMaterial;
	public Material whiteMaterial;
	public int row = 10;
	public int col = 10;
	public int[,] mArray;
	public float period=0.5f;
	public float spacing=0.1f;
	public GameObject[,] cellGameObjects;
	Board board;
	public void Begin(){
		Debug.Log (text.text);
		string[] strs = text.text.Split ('\n');
		row = strs.Length;
		col = strs [0].Length;
		mArray = new int[row, col];
		for (int i=0; i<row; i++)
		for (int j=0; j <col ; j++)
		{
			mArray[j,row-1-i]=(int)strs[i][j]-48;
//			Debug.Log(i+","+j+","+strs[i][j]+",");
//			Debug.Log(row-1-i+","+j+","+strs[i][j]+",");
		}
		cellGameObjects=new GameObject[row,col];
		for (int i=0; i<row; i++)
		for (int j=0; j<col; j++) {
			GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
			quad.transform.position=new Vector3(i+spacing*i,j+spacing*j);
			cellGameObjects[i,j]=quad;
		}
		Camera.main.transform.position = new Vector3 ((row-1 + spacing * (row - 1)) / 2, (col-1 + spacing * (col - 1)) / 2,-10);
		Camera.main.orthographicSize = 1f+Mathf.Max ((row-1 + spacing * (row - 1)) / 2, (col-1 + spacing * (col - 1)) / 2);
		//GameOfLife2 (mArray);
		//ShowResult();
		StartCoroutine (Calculate ());
	}
	public void ShowResult(){
		for (int i=0; i<row; i++)
		for (int j=0; j<col; j++) {
		cellGameObjects[i,j].GetComponent<Renderer>().material=(mArray[i,j]==1)?blackMaterial:whiteMaterial;
		}
		
	}
	IEnumerator Calculate(){
		while (true) {
			yield return new WaitForSeconds(0.5f);
			CalculateGameOfLife (mArray);
			ShowResult();
		}
	}
	public void CalculateGameOfLife(int[,] array) {
		board = new Board (array);
		row = array.GetLength (0);
		col = array.GetLength (1);
		int[,] temp=new int[array.GetLength(0),array.GetLength(1)];
		
		for (int i=0; i<row; i++)
		for (int j=0; j<col; j++) {
			temp[i,j]=array[i,j];
		}
		for (int i=0; i<row; i++)
		for (int j=0; j<col; j++) {
			int count=board.GetAdjacentPointCount(i,j);
			if(array[i,j]==1){
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
		array = temp;
		mArray = temp;
	}
}
