int[] array = {1, 34, 23, 45, 56, 76, 12, 34};

int n = array.Length;
int find = 34;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}