// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// 345, 897, 568, 234] -> 2

int []GenerateRandomArray (int size, int start, int end)
    {
        int RandomArray = new int[size];
        for (int i = 0; i< size; i++)
        {
            RandomArray[i] = new Random().Next(start, end+1);
            return RandomArray;
        }
        void PrintArray(int[] Arrey1)
        {
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine(Convert.ToString(Arrey1[i]));
            }
        }
        int CountEven(int[] Array2)
        {
            int count = 0;
            for (int =0; i < Array2.Length; i++)
                if (Array2[i] % 2 ==0)
                {
                    count = count + 1;
                }
            return count;    
        }

        int[] Array = new int[5];
        Array = GeneratedRandomArray(5, 100, 999);
        PrintArray(Array);
        Console.WriteLine("количество четных чисел массива" + CountofEven (Array));
    }