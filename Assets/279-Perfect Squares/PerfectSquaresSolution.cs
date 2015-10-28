using System;
namespace PerfectSquares{
	public class Solution {
		public int NumSquares(int n) {
			if(n<=0)
				return 0;
			return  NumSquares (n, 1, int.MaxValue);
		}
		
		
		int NumSquares(int n,int deep,int min) {
			if(deep>=min)
				return min;
			int sq=Convert.ToInt32(Math.Sqrt(n));
			if (sq * sq > n)
				sq--;
			if(sq*sq==n)
				return 1;
			for(int i=sq;i>=1;i--)
			{
				int temp=1+NumSquares(n-i*i,deep+1,min);
				if( temp<min)
					min=temp;
			}
			return  min;
		}
	}
}
