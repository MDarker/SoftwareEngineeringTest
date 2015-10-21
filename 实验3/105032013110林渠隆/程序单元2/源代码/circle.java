package some;

public class circle implements shape
{
	private double r;
	
	public circle(double x)
	{
		r = x;
	}
	
	public double area()
	{
		return pai * r * r;
	}
	
	public double perimeter()
	{
		return 2 * pai * r;
	}
}
