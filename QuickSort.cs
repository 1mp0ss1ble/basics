using System;
					
public class Program
{
	public static void Main()
	{
		var arr = new int[]{1,9,2,6,4,1,9};
		qs(arr, 0, arr.Length-1);
		Console.WriteLine(string.Join(", ", arr));
	}
	
	public static void qs(int[] arr, int left, int right){
		int index = partition(arr, left, right);
		if(left < index - 1) qs(arr, left, index - 1);
		if(right > index) qs(arr, index, right);
	}
	
	public static int partition(int[] arr, int left, int right){
		int pivot = arr[(left + right) / 2];
		
		while(left <= right) {
			while(arr[left] < pivot) left++;
			while(arr[right] > pivot) right--;
			
			if(left <= right){
				int temp = arr[left];
				arr[left] = arr[right];
				arr[right] = temp;
				left++;
				right--;
			}
		}
		
		return left;	
	}
}
