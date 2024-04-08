// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


int[] array = { 1, 2, 5, 0, 10, 34 }; // Произвольный массив
PrintArrayReverse(array, array.Length - 1);


static void PrintArrayReverse(int[] array, int index)
{
    if (index < 0) // Условие выхода из рекурсии
    {
        return;
    }

    Console.Write(array[index] + " "); // Печать текущего элемента

    PrintArrayReverse(array, index - 1); // Рекурсивный вызов для следующего элементa
}