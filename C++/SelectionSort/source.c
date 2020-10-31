#include <stdio.h>

void swap(int *x, int *y){
	int temp = *x;
	*x = *y;
	*y = temp;
}

void S_Sort(int arr[], int size){
	int min_index = 0;
	for(int i=0;i<size-1;++i){
		min_index = i;
		for(int j=i+1;j<size;++j)
			if(arr[j]<arr[min_index])
				min_index = j;
		swap(&arr[min_index],&arr[i]);
	}
}

void printArr(int arr[], int size){
	for(int i=0;i<size;++i)
		printf("%d ",arr[i]);
	printf("\n");
}

int main(){
	int arr[] = {64, 92, 100, 12, 2, 45, 85};
	int size = sizeof(arr)/sizeof(arr[0]);
	printf("Array: ");
	printArr(arr,size);
	S_Sort(arr,size);
	printf("Sorted array: ");
	printArr(arr,size);
	return 0;
}
