namespace RomanToInteger{
	public class Solution {
		public int RomanToInt(string s) {
			char[] current = s.ToCharArray ();
			int  C_before=0;//100
			int  X_before=0;//10
			int  I_before=0;//1  CMCCXI
			int result=0;
			int i = 0;
			while(i!=s.Length)
			{
				switch(current[i])
				{
				case 'M':
					result+=C_before>0?900:1000;
					C_before=0;
					break;
				case 'D':
					result+=C_before>0?400:500;
					C_before=0;
					break;
				case 'C':
					if(X_before==0)
					{
						C_before++;
						break;
					}
					else
					{
						result+=90;
						X_before=0;
						break;
					}

				case 'L':
					result+=X_before>0?40:50;
					X_before=0;
					break;
				case 'X':
					if(I_before==0)
					{
						X_before++;
						break;
					}
					else
					{
						result+=9;
						I_before=0;
						break;
					}
				case 'V':
					result+=I_before>0?4:5;
					I_before=0;
					break;
				case 'I':
					I_before++;
					break;
				}
				i++;
			}
			result=result+100*C_before+10*X_before+I_before;
			return result;
		}
	}
}