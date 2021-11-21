using System;

using System;

//ExploreIf();
//ExploreLoops();

void ExploreIf()
{
    int a = 5;
    int b = 3;
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
    }

    int c = 4;
    if ((a + b + c > 10) && (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not greater than the second");
    }

    if ((a + b + c > 10) || (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second");
    }
}
void ExploreLoops()
{
    int counter = 0;
    while (counter < 10)
    {
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
    }
    int counter2 = 0;
    do
    {
        Console.WriteLine($"Hello World! The counter is {counter2}");
        counter2++;
    } while (counter2 < 10);
    for (int row = 1; row < 11; row++)
    {
        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The cell is ({row}, {column})");
        }
    }
}
//Challenge
int sum = 0;
int div = 3;
for (int a = 1; a <= 20; a++)
{
    if (a % div == 0) 
    {
        sum = sum + a;
    }

}
Console.WriteLine($"Sum is {sum}");
