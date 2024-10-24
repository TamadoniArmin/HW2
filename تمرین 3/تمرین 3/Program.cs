using System;
Console.Write("Please enter your numbers (press space is order to sprate numbers): ");
string input = Console.ReadLine();
int length = input.Length;
int[] numbers = new int[length]; 
int index = 0;
string number = "";
for (int i = 0; i < length; i++)
{
  char currentChar = input[i];

  if (currentChar != ' ') 
  {
      number += currentChar; 
  }
  else if (number != "") 
  {
      numbers[index++] = int.Parse(number); 
      number = ""; 
  }
  }
  if (number != "")
  {
     numbers[index++] = int.Parse(number);
  }
Console.WriteLine("correct order of the numbers:");
for (int i = 0; i < index; i++)
{
    Console.WriteLine(numbers[i]);
}