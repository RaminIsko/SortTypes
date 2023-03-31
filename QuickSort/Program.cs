using System; 
using static System.Console;

// Сложность алгоритма быстрой сортировки - O(n * logn)

void PrintArray (int[] array){
    WriteLine($"[{String.Join(", ", array)}]");
}

int[] QuickSort (int[] array, int left, int right){
    int i = left;
    int j = right;

    int pivot = array[Random.Shared.Next(left, right)];

    while(i <= j){
        while(array[i] < pivot) i++;
        while(array[j] > pivot) j--;

        if(i <= j){
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;

            i++;
            j--;
        }
    }

    if(i < right) QuickSort(array, i, right);
    if(left < j)  QuickSort(array, left, j);

    return array;
} 

int[] array = {10,9,8,7,6,5,4,3,2,1};

Write("Исходный массив: ");
PrintArray(array);

int[] quickSort = QuickSort(array, 0, array.Length - 1);

Write("Quick Sort: ");
PrintArray(quickSort);