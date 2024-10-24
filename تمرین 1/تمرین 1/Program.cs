using System;
Console.Write("please enter your amount: ");
int amount = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[amount];
for (int i = 0; i < amount; i++)
{
    Console.Write($"Please enter your {i + 1} number: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
//مشخص کردن بزرگترین و کوچک ترین
int maxnumber = numbers[0];
int minnumber = numbers[0];
for (int i = 1; i < amount; i++)
{
    if (numbers[i] > maxnumber)
    {
        maxnumber = numbers[i];
    }
    else
        if (numbers[i] < minnumber)
    {
        minnumber = numbers[i];
    }
}
Console.WriteLine($"the Maximom number is: {maxnumber}  and the minimom number is: {minnumber}");
Console.WriteLine("*****************************");
//کپی کردن اعضای یک آرایه در یک آرایه ی دیکر
int[] reverce = new int[amount];
int x = 0;
for (int i = amount - 1; i >= 0; i--)
{
    reverce[i] = numbers[x];
    x++;
}
Console.WriteLine("The reverce mode of your array is: ");
foreach (int item in reverce)
{
    Console.WriteLine(item);
}
Console.WriteLine("*****************************");
//مرتب کردن یک آرایه
int temp;
for (int i = 0; i < amount - 1; i++)
{
    for (int j = 0; j < amount - 1; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}
Console.WriteLine("The correct order of your array is: ");
foreach (int item in numbers)
{
    Console.WriteLine(item);
}
/*Array.Sort(numbers);
foreach(int item in numbers)
{
    Console.WriteLine(item);
}                     
*/
Console.WriteLine("*****************************");
//مشخص کردن تعداد اعضای تکراری
int counter = 0;
for (int i = 0; i < amount; i++)
{
    for (int j = i + 1; j < amount; j++)
    {
        if (numbers[i] == numbers[j])
        {
            counter++;
        }
    }
    if (counter > 0)
    {
        Console.WriteLine($"the number that repeated in this array is {numbers[i]}. ");
        Console.WriteLine($" the number of subset is {i}.");
        if (counter > 1)
        {
            Console.WriteLine($" it repeated {counter} times.");
        }
        else
        {
            Console.WriteLine($" it repeated (ONE) time.");
        }
        Console.WriteLine("*********************************");
        counter = 0;
    }
}
//تایین اعضای مشترک بین دو آرایه
Console.Write("Please enter your second array's amount:");
int amount1 = Convert.ToInt32(Console.ReadLine());
int[] secondarray = new int[amount1];
for (int i = 0; i < amount1; i++)
{
    Console.Write("Please enter your number on second array: ");
    secondarray[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < amount; i++)
{
    counter = 0;
    for (int j = 0; j < amount1; j++)
    {
        if (numbers[i] == secondarray[j])
        {
            counter++;
        }
    }
    if (counter > 0)
    {
        Console.WriteLine($"the number that repeated between these two arrays, is {numbers[i]}. ");
        Console.WriteLine("*********************************");
    }
}
