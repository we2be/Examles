void FillArray(int[]Collection)
{
    int length = Collection.Length;
    int index = 0;
    while (index < length)
    {
        Collection[index] = new Random().Next(1, 10);
        // index = index +1;
        index++;
    }


}

void PrintArray(int[] Col)
{
    int count = Col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(Col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
array[4] = 4;
array[6] = 4;

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 444);
Console.WriteLine(pos);