package some;

import java.util.*;

public class test 
{
	public static void main(String[] args)
	{

		Scanner input = new Scanner (System.in);
		System.out.println("������Բ�İ뾶��");
		double r = input.nextDouble();
		circle a = new circle(r);
		System.out.println("Բ�������"+ a.area());
		System.out.println("Բ���ܳ���"+ a.perimeter());
		
		System.out.println("��������εĳ���");
		double x = input.nextDouble();
		System.out.println("��������εĿ�");
		double y = input.nextDouble();
		rectangle b =new rectangle(x,y);
		System.out.println("���ε������"+ b.area());
		System.out.println("���ε��ܳ���"+ b.perimeter());
		
		star c = new star();
		star d = new star();
		star e = new star();

		System.out.println("��Ĵ���������"+ star.cout());
	}
}
