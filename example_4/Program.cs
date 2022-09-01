// Есть массив array, который состоит из элементов n
//Найти элемент массива равный find
// Нужно: 1. установить счётчик index в позицию 0
//2. Если array[index]=find----завершение алгоритма
//3. index= index+1
//4. Если index < n, то перейти к шагу 2 или алгоритм завершим работу

int [] array = {1,12,31,4,15,16,17,18};
int n = array.Length;
int find = 18;
int index = 0;
 while (index < n)
 {
    if (array [index] == find)
    {
    Console.WriteLine(index);
    break; // если несколько одинаковых числа в массиве
    }
    index = index + 1;

 }


