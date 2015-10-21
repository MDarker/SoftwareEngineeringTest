import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;


public class CircleTest {

	Circle c;
	@Before
	public void setUp() throws Exception {
		c = new Circle(6);
		System.out.println("Ô²µÄ°ë¾¶£º"+6);
	}

	@After
	public void tearDown() throws Exception {
	}

	@Test
	public void testGetArea() {
		System.out.println("test circle getArea()");
		assertEquals(113.04,c.getArea(),0.001);
	}

	@Test
	public void testGetPerimeter() {
		System.out.println("test circle getPerimeter()");
		assertEquals(37.68,c.getPerimeter(),0.001);
	}

}
