//conditioal Statements
int a = 5;
int b = 6;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10.");


int a1 = 5;
int b1 = 3;
if (a1 + b1 > 10)
{
    Console.WriteLine("The answer is greater than 10.");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}

int a2 = 5;
int b2 = 3;
int c = 4;
if ((a2 + b2 + c > 10) && (a2 == b2))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

int a3 = 5;
int b3 = 3;
int c1 = 4;
if ((a3 + b3 + c1 > 10) || (a3 == b3))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}

// else if statements

Console.WriteLine("Enter the number:");      
int number = int.Parse(Console.ReadLine());
if(number == 1) 
{
    Console.WriteLine("One");
}
else if(number == 2)
{
    Console.WriteLine("two");
}
else
{
    Console.WriteLine("Other than 1 and 2");
}

//switch statement

Console.WriteLine("Enter the number:");      
double measurement = double.Parse(Console.ReadLine());

    switch (measurement)
    {
        case < 0.0:
            Console.WriteLine($"Measured value is {measurement}; too low.");
            break;

        case > 15.0:
            Console.WriteLine($"Measured value is {measurement}; too high.");
            break;

        case double.NaN:
            Console.WriteLine("Failed measurement.");
            break;

        default:
            Console.WriteLine($"Measured value is {measurement}.");
            break;
    }

//case guard statements
Console.WriteLine("Enter two number:");      
int a = int.Parse(Console.ReadLine());
int b = double.Parse(Console.ReadLine());
    switch ((a, b))
    {
        case (> 0, > 0) when a == b:
            Console.WriteLine($"Both measurements are valid and equal to {a}.");
            break;

        case (> 0, > 0):
            Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
            break;

        default:
            Console.WriteLine("One or both measurements are not valid.");
            break;
    }


//While Loop
int count = 0;
while (count < 10)
{
    Console.WriteLine($"Hello World! The count is {count}");
    count++;
}

//do While Loop
int counter = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
} while (counter < 10);

//for loop
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Hello World! The c value is {i}");
}

//nested for loop
for (int row = 1; row < 8; row++)
{
    for (char column = 'a'; column < 'd'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}

//Example of Branches and Loops
int sum = 0;
for(int j= 1; j < 20; j++)
{   
    if(j%3==0)
    {
        sum =sum+j;
    }
}
Console.WriteLine($"The sum is {sum}");

