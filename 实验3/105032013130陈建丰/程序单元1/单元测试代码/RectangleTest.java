package Sharp;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Ignore;
import org.junit.Test;

public class RectangleTest {
	Rectangle re=new Rectangle(2,2);
	//��ÿ��test����֮ǰ����
	@Before
	public void setUp() throws Exception {
		System.out.println("Set up	");
		}
//���Դ˲���
	@Ignore
	@Test
	public void testRectangle() {
		
	}
//���Լ̳����еķ���
	//�������
	@Test
	public void testArea() {
		System.out.println("test rectangle.area");
		assertEquals(4, re.area(),0.0000000001);
	}
	//�����ܳ�
	@Test
	public void testPerimeter() {
		System.out.println("test rectangle.perimeter");
		assertEquals(8.0,re.perimeter(),0.00001);
	}
	  @After
	    public void tearDown() throws Exception {  
	        System.out.println("Tear down");  
	    } 
}
