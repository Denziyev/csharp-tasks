int maxvalue(params int[] arr)
{   int max = arr[0]; 
    for(int i=1;i<arr.Length;i++)
    {
        if (arr[i]>max)
        { max = arr[i]; }   
    }
    return max;
}
Console.WriteLine(maxvalue(20, 30, 50, 10, 29, 45,-100));   



