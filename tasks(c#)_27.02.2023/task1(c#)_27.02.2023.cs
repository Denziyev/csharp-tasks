void searching(int[] array,int number)
{
    for(int i=0;i<array.Length;i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine(number + " exist in array given");
            break;
        }
        else if (i == array.Length - 1)
        {
            Console.WriteLine(number + " doesnt exist");
        }
    }
}


int[] enterarray()
{
    Console.Write("enter the number of elements in array: ");
    int numbersofelements = int.Parse(Console.ReadLine());

    int[] arr = new int[numbersofelements];

    for (int i = 0; i < numbersofelements; i++)
    {
        Console.Write("enter " + (i + 1) + " element: ");
        int x = int.Parse(Console.ReadLine());
        arr[i] = x;
    }
    
    return arr;
}


int enternumber()                       
{
    Console.Write("Enter the number you search: ");
    return int.Parse(Console.ReadLine());
}


int[] arr = enterarray();
int N=enternumber();
searching( arr, N);

