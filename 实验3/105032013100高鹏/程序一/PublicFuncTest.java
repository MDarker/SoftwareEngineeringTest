package publicFunc;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

public class PublicFuncTest {

	 PublicFunc pub=new PublicFunc();
	 
	@Before
	public void setUp() throws Exception {
       
	}

	@Test
	public void testConOp() {
		 

		assertEquals(true,pub.ConOp());
		
	}

	@Test
	public void testStuFuncChoice() {
		
		assertEquals(true,pub.StuFuncChoice());
		
	}

}
