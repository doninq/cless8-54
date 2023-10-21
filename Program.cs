/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] GenerateArray(int n,int m)
{
    int[,] matrix = new int[n,m];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {        
           matrix[i,j] = new Random().Next(1, 10);
       }
    }return matrix; 
}

void PrintArray(int[,] matrix)
{
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {
           Console.Write(matrix[i,j]+" ");
       }
       Console.WriteLine("");
    }
}

int[,] SortArray(int[,] matrix)
{   
   int Check = 0; 
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
       Check = 0;  
       while(Check == 0){
        Check = 1;  
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
          if(j != 0) if(matrix[i,j-1] < matrix[i,j])
          {
            int tmp = matrix[i,j-1];
            matrix[i,j-1] = matrix[i,j];
            matrix[i,j] = tmp;
            Check = 0;
          }  
        }
       }
       
    }    
    return matrix;
}

int[,] result = GenerateArray(3,4);
PrintArray(result);
SortArray(result);
Console.WriteLine("");
PrintArray(result);
