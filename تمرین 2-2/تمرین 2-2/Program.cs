using System;
Console.Write("Please enetr your string: ");
string input1 = Console.ReadLine();
Console.Write("Please enter your string: ");
string input2 = Console.ReadLine();
int temp1 = 0;
int temp2 = 0;
string longest = "";
string box = "";
for (int i = 0; i < input1.Length; i++)
{
    for(int j=0;j<input2.Length;j++)
    {
        box = "";
        temp1 = i;
        temp2 = j;
        while (temp1<input1.Length && temp2<input2.Length && input1[temp1] == input2[temp2])
        {
            box += input1[temp1];
            temp1++;
            temp2++;
        }
        if (box.Length>longest.Length)
        {
            longest = box;
        }
    }
}
Console.WriteLine($"The longest substring is: {longest}.");