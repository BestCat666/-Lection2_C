

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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // cтавим -1 чтобы при введении несуществующего числа в данном массивн мы понимали, что его нет, иначе он будет выдаваться каак позиция 0

while(index < count)
{
   if(collection[index] == find)
   {
      position = index;
      break;
   }
   {
   index++;
   }
}
return position;
}

int [] array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 5);
Console.WriteLine(pos);