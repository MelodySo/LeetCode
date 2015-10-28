using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Matrix
{
	/// <summary>
	/// 存储矩阵数据的二维数组
	/// </summary>
	internal protected int[,] Mat;
	/// <summary>
	/// 矩阵实际的行数
	/// </summary>
	private int row;
	/// <summary>
	/// 矩阵实际的列数
	/// </summary>
	private int col;
	/// <summary>
	/// 获取矩阵行数的属性，用于获得矩阵的行数
	/// </summary>
	public int Row
	{
		get 
		{
			return row;
		}
	}
	/// <summary> 
	/// 获取矩阵列数的属性，用于获得矩阵的列数
	/// </summary>
	public int Col
	{
		get
		{
			return col;
		} 
	}
	/// <summary>
	/// 构造函数1：用于产生n阶方阵
	/// </summary>
	/// <param name="n">方阵的阶数</param>
	public Matrix(int n)
	{
		Mat=new int[n,n];
		row=col=n;
	}
	public Matrix(int[,] array){
		Mat = array;
		row = array.GetLength (0);
		col = array.GetLength (1);
	}
}