using System;
using static System.Console;

void PrintArray (int[] array){
    WriteLine($"[{String.Join(", ", array)}]");
}

int[] CountSort (int[] array){

    int size = array.Length;
    int max = array[0];

    for(int i = 1; i < size; i++){
        if(array[i] > max) max = array[i];
    }

    int[] count = new int[max + 1];

    for(int i = 0; i < size; i++) count[array[i]]++;
    
    int index = 0;

    for (int i = 0; i < max + 1; i++)
      for (int j = 0; j < count[i]; j++)
        array[index++] = i;

    return array;
}

int[] array = {10,9,8,7,6,5,4,3,2,1};

Write("Исходный массив: ");
PrintArray(array);

int[] countSort = CountSort(array);

Write("Count Sort: ");
PrintArray(countSort);
