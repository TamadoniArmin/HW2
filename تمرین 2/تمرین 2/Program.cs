using System;
Console.Write("Please enter your first string: ");
string str1 = Console.ReadLine();
Console.Write("Please enter your second string: ");
string str2 = Console.ReadLine();
string lcs = LongestCommonSubstring(str1, str2);
if (lcs.Length > 0)
{
    Console.WriteLine("Bigest similar substring is :  " + lcs);
}
else
{
    Console.WriteLine("There is no similar number is these two strings.");
}

    static string LongestCommonSubstring(string str1, string str2)
    {
        int maxLength = 0;
        int endIndex = 0;
        int[,] dp = new int[str1.Length + 1, str2.Length + 1];
        for (int i = 1; i <= str1.Length; i++)
        {
            for (int j = 1; j <= str2.Length; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                    if (dp[i, j] > maxLength)
                    {
                        maxLength = dp[i, j];
                        endIndex = i; 
                    }
                }
                else
                {
                    dp[i, j] = 0; 
                }
            }
        }
        return str1.Substring(endIndex - maxLength, maxLength);
    }