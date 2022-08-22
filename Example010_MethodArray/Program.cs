int[] array = { 1, 21, 34, 56, 62, 62, 44, 78 };

int n = array.Length;
int find = 62;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}