package some;

public class rectangle implements shape
{
	double x,y;
	
	public rectangle(double x,double y)
	{
		this.x = x;
		this.y = y;
	}
	
	public double area()
	{
		return x * y;
	}
	
	public double perimeter()
	{
		return 2 * ( x + y );
	}
}
