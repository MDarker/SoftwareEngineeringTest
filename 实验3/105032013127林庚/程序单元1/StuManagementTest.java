package p1;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class StuManagementTest {

	Student stu;
	StuManagement stuM;
	@Before
	public void setUp() throws Exception {
		stu = new Student();
		stuM = new StuManagement();
	}

	@After
	public void tearDown() throws Exception {
	}

	@Test
	public void testChoice() {
		assertTrue(stuM.Choice());
	}

}
