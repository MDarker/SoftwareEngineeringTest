package test;

public class SelectSort {
	public boolean sort() {
		int[] data = new int[] { 5, 3, 6, 2, 1, 9, 4, 8, 7 };
		print(data);
		selectSort(data);
		print(data);
		return true;
	}

	public boolean selectSort(int[] data) {
		for (int i = 0; i < data.length - 1; i++) {
			int minIndex = i;
		}
		return true;}

	public boolean print(int[] data) {
		for (int i = 0; i < data.length; i++) {
			System.out.print(data[i] + "\t");
		}
		System.out.println();
		return true;	}
}