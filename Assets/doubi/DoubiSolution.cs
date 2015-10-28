public class DoubiSolution{
	public double a,b,c,d;
	public double[] Doubi(){
		//sort: a<b<c<d
		double temp;
		if (a > b) {
			temp=a;
			a=b;
			b=temp;
		}
		if (b > c) {
			temp=b;
			b=c;
			c=temp;
		}
		if (c > d) {
			temp=c;
			c=d;
			d=temp;
		}
		if (b * 1.3d < c) {
			return new double[]{c,d};
		}
		else if (c * 1.3d < d) {
			return new double[]{d};
		} 
		else
			return null;
	}
}
