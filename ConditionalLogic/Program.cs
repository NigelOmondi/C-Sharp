int a = 5;
int b = 3;
if (a + b > 10)
	Console.WriteLine("The answer is greater than 10.");
else
	Console.WriteLine("The answer is not greater than 10.");

/* C# doesnt treat indentation or any whitespace as significant
 * but it is good practice to indent your code to make it more readable.
 * You need to use {} to enclose the code block for if and else statements,
 * when you have more than one statement to execute.
 */

int c = 5;
int d = 3;
int e = 4;
if ((c + d + e > 10) && (c == d))
{
	Console.WriteLine("The answer is greater than 10");
	Console.WriteLine("And the first number is equal to the second");
}
else
{
	Console.WriteLine("The answer is not greater than 10");
	Console.WriteLine("Or the first number is not equal to the second");
}

int f = 5;
int g = 3;
int h = 4;
if ((f + g + h > 10) || (f == g))
{
	Console.WriteLine("The answer is greater than 10");
	Console.WriteLine("Or the first number is equal to the second");
}
else
{
	Console.WriteLine("The answer is not greater than 10");
	Console.WriteLine("And the first number is not equal to the second");
}

// Loops for repeating code
int counter = 0;
while (counter < 10)
{
	Console.WriteLine($"Hello Dev! The counter is {counter}");
	counter++;
}

/* For a while loop, make sure the condition will eventually be false,
 * otherwise you will have an infinite loop.
 * 
 * While loops also test condition before executing the code block.
 * The DO...WHILE loop, however, executes the code block first and
 * then checks the condition.
 */

int doCounter = 0;
do
{
	Console.WriteLine($"Hello Dev! The doCounter is {doCounter}");
	doCounter++;
} while (doCounter < 10);

/* The do...while loop is useful when you want to make sure the code block executes at least once
 * regardless of whether the condition is true or false.
 * */


/* 
USE CASES FOR WHILE LOOP:
When you want to execute a loop an indefinite number of times but only
if the condition is true from the start.
Example: READING DATA until the end is reached, but if there is no data, 
don't enter the loop.

USE CASES FOR DO...WHILE:
When you need to execute the loop at least once, but after the first execution, 
the continuation depends on the given condition.
Example: MENU SYSTEMS where a user should see the menu at least once
and then continue seeing it until they choose to exit.
*/

for (int count = 0; count < 10; count++)
{
	Console.WriteLine($"Hello Dev! The for loop counter is {count}");
}

// foreach loop is more useful for iterating through arrays and collections

// Nested loops


// The outer loop increments once for each full run of inner loop

for (int row = 1; row < 11; row++)
{
	for (char column = 'a'; column < 'k'; column++)
	{
		Console.WriteLine($"The cell is ({row}, {column})");
	}
}

int sumOfThrees = 0;
for (int number = 1; number <= 20; number++)
{
	if (number % 3 == 0)
	{
		sumOfThrees += number;
	
	}
	
}
Console.WriteLine($"The sum of the multiples of 3 is {sumOfThrees}");