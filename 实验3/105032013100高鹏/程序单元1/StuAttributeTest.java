package stuFunc;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class StuAttributeTest {
	StuAttribute stu=new StuAttribute("张三","123","男","3","2");
	public StuAttributeTest() {
	}

	@Before
	public void setUp() throws Exception {
	}

	@After
	public void tearDown() throws Exception {
	}

	@Test
	public void testGetStuName() {
		assertEquals("张三",stu.getStuName());
	}

	@Test
	public void testGetStuNo() {
		assertEquals("123",stu.getStuNo());
	}

	@Test
	public void testGetStuGender() {
		assertEquals("男",stu.getStuGender());
	}

	@Test
	public void testGetStuClass() {
		assertEquals("3",stu.getStuClass());
	}

	@Test
	public void testGetStuGrade() {
		assertEquals("2",stu.getStuGrade());
	}

}
