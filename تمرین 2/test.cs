using System;
Console.Write("Please enter your binary number: ");
string binary = Console.ReadLine();
int number=0;
for (int i = 0; i < binary.Length; i++)
{
    int temp = Convert.ToInt32(binary[i]);
	if (temp==1)
	{
		number += 2 ^ i;
	}
	else
	{
		continue;
	}
}
Console.WriteLine($"The number in desimal is: {number}");