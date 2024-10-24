Console.Write("Please enter the cost of product: ");
int amount = Convert.ToInt32(Console.ReadLine());
int count50 = 0, count10 = 0, count5 = 0, count1 = 0;
while (amount >= 50)
{
    amount -= 50;
    count50++;
}
while (amount >= 10)
{
    amount -= 10;
    count10++;
}
while (amount >= 5)
{
    amount -= 5;
    count5++;
}
while (amount >= 1)
{
    amount -= 1;
    count1++;
}
Console.WriteLine($"number of 50 tomans coin which is requare is: {count50}");
Console.WriteLine($"number of 10 tomans coin which is requare is: {count10}");
Console.WriteLine($"number of 5 tomans coin which is requare is: {count5}");
Console.WriteLine($"number of 1 tomans coin which is requare is: {count1}");