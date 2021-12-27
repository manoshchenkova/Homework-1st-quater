// Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
//Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(int[] Array1)
//  Функция заполняет массив случайными числами
{
    for (int i = 0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().Next(1,10);
    }
}

void PrintArray(int[] Array2)
// Функция выводит массив на экран
{
    for (int j = 0; j < Array2.Length; j++)
    {
        Console.Write(Array2[j] + " ");
    }
}

int SelectEvenElements(int[] ArrayInitial, int[] ArrayResult)
// Функция выбирает четные элементы из изначального массива и копирует их в конечный массив
{
    int j = 0;

    for (int i = 0; i < ArrayInitial.Length; i++)
    {
            if(ArrayInitial[i] % 2 == 0)
            {
            ArrayResult[j] = ArrayInitial[i];
            j++;
            return ArrayResult[j];
            }
    }
}
Console.Clear();

int[] ArrayInitial = new int[10];
int[] ArrayResult = new int[ArrayResult.Length];

FillArray(ArrayInitial);
PrintArray(ArrayInitial);
SelectEvenElements(ArrayInitial, ArrayResult);
PrintArray(ArrayResult);
