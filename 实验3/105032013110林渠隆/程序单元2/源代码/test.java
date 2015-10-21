package some;

import java.util.*;

public class test 
{
	public static void main(String[] args)
	{

		Scanner input = new Scanner (System.in);
		System.out.println("请输入圆的半径：");
		double r = input.nextDouble();
		circle a = new circle(r);
		System.out.println("圆的面积："+ a.area());
		System.out.println("圆的周长："+ a.perimeter());
		
		System.out.println("请输入矩形的长：");
		double x = input.nextDouble();
		System.out.println("请输入矩形的宽：");
		double y = input.nextDouble();
		rectangle b =new rectangle(x,y);
		System.out.println("矩形的面积："+ b.area());
		System.out.println("矩形的周长："+ b.perimeter());
		
		star c = new star();
		star d = new star();
		star e = new star();

		System.out.println("类的创建个数："+ star.cout());
	}
}
