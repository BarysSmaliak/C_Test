// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

int[,]array = new int [4, 4];
TwoDimensionalArray(array => new Random().Next(0,4)); 
Console.WriteLine();
TwoDimensionalArray(array => Console.WriteLine(array)); 

void TwoDimensionalArray(Action<int, int> action) 
{ 	
    for (int i = 0; i <array.GetLength(0); i++) 	
    { 	
        for (int j = 0; j < array.GetLength(1); j++)
        {
           action(i,j);
        }		
        
    } 
}
