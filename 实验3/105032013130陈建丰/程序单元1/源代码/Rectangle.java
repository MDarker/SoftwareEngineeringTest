package Sharp;

public class Rectangle implements Shape {
	double pmeter,area;
	public Rectangle(double len,double wide){
		this.pmeter=2*(len+wide);
		this.area=len*wide;
	}

	@Override
	public double area() {
		// TODO Auto-generated method stub
		return area;
	}

	@Override
	public double perimeter() {
		// TODO Auto-generated method stub
		return pmeter;
	}

}
