 int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        sum += lastDigit;
        number /= 10;
    }
    return sum;
}

{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int sum = SumOfDigits(number);
    Console.WriteLine("The sum of digits in the number is: " + sum);
    
}
