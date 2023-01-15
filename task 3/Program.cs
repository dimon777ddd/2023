{
    int[] myArray = new int[8];
    for (int i = 0; i < 8; i++)
    {
        Console.Write("Enter element {0}: ", i + 1);
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("The elements of the array are:");
    for (int i = 0; i < 8; i++)
    {
        Console.Write(myArray[i] + " ");
    }
}
