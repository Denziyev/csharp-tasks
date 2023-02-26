#region Array-i user daxil edir
Console.Write("Enter the number of array elements: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    Console.Write("Enter the " + (i + 1) + " elements: ");
    int x = int.Parse(Console.ReadLine());
    array[i] = x;
}

int number_positive = 0;
int number_negative=0;

for (int i = 0; i < N; i++)
{
    if (array[i] > 0)
    {
        number_positive++;

    }
    else if (array[i] < 0) 
    {
        number_negative++;
    }
}

Console.WriteLine("The number of positive elements: " + number_positive);
Console.WriteLine("The number of negative elements: " + number_negative);

#endregion
Console.WriteLine("given array by us:------------------------------");
#region  Array-i biz daxil edirik
int[] arr = { 0, -8, 25, 85, 45, -76, 48 };
int number__positive = 0;
int number__negative = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >0)
    {
        number__positive++;

    }
    else if (arr[i]<0)
    {
        number__negative++;
    }

}
 

Console.WriteLine("The number of positive elements:" + number__positive);
Console.WriteLine("The number of negative elements:" + number__negative);
#endregion
