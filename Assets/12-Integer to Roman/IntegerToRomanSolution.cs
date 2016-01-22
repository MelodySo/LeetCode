namespace IntegerToRoman{
	public class Solution {
		public string IntToRoman(int num) {
			if (num > 3999||num<1)
				return "";
			const string I = "I";//1
			const string V = "V";//5
			const string X = "X";//10
			const string L = "L";//50
			const string C = "C";//100
			const string D = "D";//500
			const string M = "M";//1000
			string str;
			int head = num / 1000;
			num = num - 1000 * head;
			str = IntToRoman (head, M, string.Empty, string.Empty);
			head = num / 100;
			num = num - 100 * head;
			str += IntToRoman (head, C, D, M);
			head = num / 10;
			num = num - 10 * head;
			str += IntToRoman (head, X, L, C);
			str += IntToRoman (num, I, V, X);
			return str;
		}
		private string IntToRoman(int num,string str1,string str5,string str10){
			switch (num) {
			case 1:
				return str1;
			case 2:
				return str1 + str1;
			case 3:
				return str1 + str1 + str1;
			case 4:
				return str1 + str5;
			case 5:
				return str5;
			case 6:
				return str5 + str1;
			case 7:
				return str5 + str1 + str1;
			case 8:
				return str5 + str1 + str1 + str1;
			case 9:
				return str1 + str10;
			default:
				return "";
			}
		}

	}
}
