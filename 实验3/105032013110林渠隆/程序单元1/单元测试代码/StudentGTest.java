package DIO;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class StudentGTest {
	StudentG stug = new StudentG();
	@Before
	public void setUp() throws Exception 
	{
		StudentG stug1 = new StudentG("zhangsan","1001");
		stug1.AddStudent();
		StudentG stug2 = new StudentG("lisi","1002");
		stug2.AddStudent();
	}

	
	@Test
	public void testIdToIndex() 
	{
		assertEquals(0,stug.IdToIndex("1001"));
	}
	
}
