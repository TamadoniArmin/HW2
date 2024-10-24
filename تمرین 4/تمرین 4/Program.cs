using System;
Console.Write("Please enter your sentence: ");
string input = Console.ReadLine();
char mostfrequentchar = '\0' ;//یک متغییر برای جایکدازی کارکتر به عنوان بیشترین 
/* /0 برای نمایش جایکاه خالی در کاراکتر است*/
int maxcount = 0;
for (int i = 0; i < input.Length; i++)
{
   int count = 0;
   for (int j = 0; j < input.Length; j++)
   {
       if (input[j] == input[i])
       {
           count++;
       }
   }
   if (count > maxcount)
   {
       maxcount = count;
   //ما باید در این قسمت یک متغییر به صورت کاراکتر داشته باشیم
       mostfrequentchar = input[i];
    }
}
Console.WriteLine($"most repeated chracter is: '{mostfrequentchar}' with {maxcount} times.");