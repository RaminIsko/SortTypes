using System;
using static System.Console;

int[] BubbleSort (int[] array) {

    for(int i = 0; i < array.Length - 1; i++){
        
        for(int j = 0; j < array.Length - 1 - i; j++){
            
            if(array[j] > array[j + 1]){
                
                int tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            
            }
        
        }
    
    }
    
    return array;

}

void PrintArray (int[] array) {
    
    WriteLine($"[{String.Join(", ", array)}]");

}


int[] array = {10,9,8,7,6,5,4,3,2,1};

Write("Изначальный массив: ");
PrintArray(array);

int[] sortedArray = BubbleSort(array);

Write("Bubble Sort: ");
PrintArray(sortedArray);

// Сложность алгоритма BubbleSort -> O(n^2)

// Выходит O(n^2 - 2n + 1), но по графику это схоже с O(n^2)

