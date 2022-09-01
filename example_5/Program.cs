
//void не возвращает значение, не нужно исп return
// создание массива из слуайных чисел
void FillArray(int[] collection)
{
 int length = collection.Length;
 int index = 0;
 while (index < length)

 {
    collection[index] = new Random().Next(1, 10);
    index++;
 }
}



void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
{
    Console.WriteLine(col[position]);
    position++;
}
}

int [] array = new int [10]; // new int[число]; создать массив с определённым кол-ом чисел.изначально будет заполнен нулями

FillArray(array);
PrintArray(array);