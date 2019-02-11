using System;
					
public class Program
{
	public static void Main()
	{
		var arr = new int[]{5,9,2,6,8,1,9};
		mergesort(arr);
		Console.WriteLine(string.Join("; ", arr));
	}
	
	public static void mergesort(int[] arr){
		var temp = 	new int[arr.Length];
		mergesort(arr, temp, 0, arr.Length - 1);
	}
	
	public static void mergesort(int[] arr, int[] temp, int low, int high){
		if(low >= high) return;
		int middle = (low + high) / 2;
		mergesort(arr, temp, low, middle);
		mergesort(arr, temp, middle + 1, high);
		merge(arr, temp, low, middle, high);
	}
	
	public static void merge(int[] arr, int[] temp, int low, int middle, int high){
		for(int i = 0; i <= high; i++) temp[i] = arr[i];
		
		int tempLeft = low;
		int tempRight = middle + 1;
	    int current = low;
		
		while(tempLeft <= middle && tempRight <= high){
			if(temp[tempLeft] <= temp[tempRight]){
				arr[current] = temp[tempLeft];
				tempLeft++;
			} else {
				arr[current] = temp[tempRight];
				tempRight++;
			}
			current++;
		}
		
		int remaining = middle - tempLeft;
		for(int i = 0; i <= remaining; i++) arr[current  + i] = temp[tempLeft + i];
	}
	
}
