package some;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class rectangleTest {

	rectangle a = new rectangle(2,3);
	@Before
	public void setUp() throws Exception 
	{
	}

	@Test
	public void testArea() 
	{
		assertEquals(6,a.area(),0.000001);
	}

}
