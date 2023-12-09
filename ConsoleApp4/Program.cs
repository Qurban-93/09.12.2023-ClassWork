int[] numbers = { 1, 2, 2, 4, 7, 90, 9, 8, 5 };
int mostHigh = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > mostHigh)
    {
        mostHigh= numbers[i];
    }
}
Console.WriteLine(mostHigh);


int number = 45;
int count = 0;  

for (int i = 1; i <= number; i++)
{
    if (number % i == 0)
    {
        count++;
    }
}

if (count > 2)
{
    Console.WriteLine("Murekkeb");
}
else
{
    Console.WriteLine("Sade");
}