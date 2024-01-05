// Explore integer math in C#
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c; // Integer division always returns an integer result
int e = (a + b) % c; // modulo % returns the remainder after dividing
Console.WriteLine($"Quotient is: {d}");
Console.WriteLine($"Remainder is: {e}");

// Operator precedence
int f = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(f);

// Integer precision and limits
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

/* If a calculation produces a value that is outside the range
 * of the integer type, you get an overflow or underflow. 
 */

// Overflow example
int overflow = max + 3;
Console.WriteLine($"An example of overflow: {overflow}");

// Double type
double g = 5;
double h = 4;
double j = 2;
double k = (g + h) / j;
Console.WriteLine($"k is: {k}");

double l = 19;
double m = 23;
double n = 8;
double p = (l + m) / n;
Console.WriteLine($"p is: {p}");

// The range of double is much larger than int
double maxDouble = double.MaxValue;
double minDouble = double.MinValue;
Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");

// Doubles can have rounding errors
double third = 1.0 / 3.0;
Console.WriteLine(third);

/* we get 0.3333333333333333, which is a close approximation of 1/3, but not exact,
 * because 0.3 is 3/10 and not exactly same as 1/3, similarly 0.33 is 33/100 .
 * If you need more precision, you can use the decimal type, which gives you 28 
 * significant digits. That is, it gives you precision up to 28 digits after the decimal point. 
 */

// Decimal type, has smaller range but greater precision than double
decimal minDecimal = decimal.MinValue;
decimal maxDecimal = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {minDecimal} to {maxDecimal}");

double q = 1.0;
double r = 3.0;
Console.WriteLine($"Division of double: {q / r}");

/* The M suffix on the numbers is how you indicate that a constant should use the decimal type
 * otherwise it defaults to double
 */
decimal s = 1.0M;
decimal t = 3.0M;
Console.WriteLine($"Division of decimal: {s / t}");

// Challenge: Calculate the area of a circle
double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine($"Area of circle with radius {radius} is {area}");