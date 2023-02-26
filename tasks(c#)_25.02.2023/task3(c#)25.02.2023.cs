#region Array-i biz daxil edirik
int[] array = { 9, 4, 8, 6, 1, 5 };
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
}
Console.WriteLine("max value is " + max);

#endregion
#region User daxil edir

Console.Write("Enter the number of array elements: ");
int N = int.Parse(Console.ReadLine());
int[] arr = new int[N];
for (int i = 0; i < N; i++)
{
    Console.Write("Enter the " + (i + 1) + " elements: ");
    int x = int.Parse(Console.ReadLine());
    arr[i] = x;
}
int maxvalue = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > maxvalue)
        maxvalue = arr[i];
}
Console.WriteLine("max value is "+maxvalue);

#endregion
