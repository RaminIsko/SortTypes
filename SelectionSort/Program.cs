// Сортировка выбором

// Сложность алгоритма сортировки выбором - O(n ^ 2 / 2)

using System;
using static System.Console;

int[] GetArray (int length, int min, int max) {

    int[] result = new int[length];
    
    for(int i = 0; i < result.Length; i++){
        
        result[i] = new Random().Next(min,max);
    }
    
    return result;
}

void PrintArray (int[] array) {

    WriteLine($"[{String.Join(", ", array)}]");

}

int[] SelectionSort (int[] array) {
    int size = array.Length;

    for (int i = 0; i < size - 1; i++){
      
      int minIndex = i;
      
      for (int j = i + 1; j < size; j++){
        
        if (array[j] < array[minIndex]) minIndex = j;
      
      }
      
      int temp = array[i];
      array[i] = array[minIndex];
      array[minIndex] = temp;
    
    }

    return array;

}

int[] array = GetArray(10, 1, 100);

Write("Изначальный массив: ");
PrintArray(array);

int[] selectionSort = SelectionSort(array);

Write("Selection Sort: ");
PrintArray(selectionSort);