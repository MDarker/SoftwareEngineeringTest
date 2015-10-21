package test;

import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class SelectSortTest {

	int[] data = new int[] { 5, 3, 6, 2, 1, 9, 4, 8, 7 };
	SelectSort s;
	@Before
	public void setUp() throws Exception {
		s=new SelectSort();
	}

	@After
	public void tearDown() throws Exception {
	}

	@Test
	public void testSort() {
		assertTrue(s.sort());
	}

	@Test
	public void testSelectSort() {
		assertTrue(s.selectSort(data));
	}

	@Test
	public void testPrint() {
		assertTrue(s.print(data));
	}

}
