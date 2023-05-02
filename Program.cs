//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] CreateArray(int lengthArray){
    int [] array = new int[lengthArray];
    for(int i=0; i<lengthArray;i++){
        array[i] = new Random().Next(100,1000);
    }
return array;
}

void NumberOfEven(int [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0 ) count++;
    }
    Console.WriteLine($"Количество четных чисел в массиве = {count}");
}

void PrintArray(int [] array){
    Console.Write("[");
    for(int i=0;i<array.Length;i++){
        if(i!=array.Length-1)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine($"{array[i]}]");
    }
}

Console.Write("Введите длину массива N=");
int lengthArr = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(lengthArr);
PrintArray(arr);
NumberOfEven(arr);

