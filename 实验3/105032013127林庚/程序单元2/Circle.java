
public class Circle implements IShape{
	
	private double radius;
	public Circle(double radius){
		this.radius = radius;
	}
	
	private double PI = 3.14; 
	
	public double getArea(){
		double area = PI * radius * radius;
		System.out.println("圆的面积："+area);
		return area;
	}
	
	public double getPerimeter(){
		double peri = 2 * PI * radius;
		System.out.println("圆的周长："+peri);
		return peri;
	}
}
