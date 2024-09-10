// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");
Console.WriteLine("-------------------------------------------------------------------------------");

int a = 1509; int b = 744; int c = a + b;
Console.Write("The sum of ");
Console.Write(a);
Console.Write(" and ");
Console.Write(b);
Console.Write(" equals ");
Console.WriteLine(c);
Console.WriteLine("The sum of " + a + " and " + b + " = " + c);
Console.WriteLine(" {0} + {1} = {2}", a, b, c);
Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine("Standard Numeric Format Specifiers");
Console.WriteLine(
        "(C) Currency: . . . . . . . . 	{0:C}\n" +
        "(D) Decimal:. . . . . . . . .  	{0:D}\n" +
        "(E) Scientific: . . . . . . .   	{1:E}\n" +
        "(F) Fixed point:. . . . . . . 	{1:F}\n" +
        "(G) General:. . . . . . . . .  	{0:G}\n" +
        "    (default):. . . . . . . .     	{0} (default = 'G')\n" +
        "(N) Number: . . . . . . . . .  	{0:N}\n" +
        "(P) Percent:. . . . . . . . .   	{1:P}\n" +
        "(R) Round-trip: . . . . . . . 	{1:R}\n" +
        "(X) Hexadecimal:. . . . . . .	{0:X}\n",
        -123, -123.45f);
Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine("Standard DateTime Format Specifiers");
Console.WriteLine(
        "(d) Short date: . . . . . . . 		11/20/2011\n" +
        "(D) Long date:. . . . . . . . 	Sunday, November 20, 2011\n" +
        "(t) Short time: . . . . . . . 		5:54 PM\n" +
        "(T) Long time:. . . . . . . . 		5:54:04 PM\n" +
        "(f) Full date/short time: . . 	Sunday, November 20, 2011 5:54 PM\n" +
        "(F) Full date/long time:. . . 	Sunday, November 20, 2011 5:54:04 PM\n" +
        "(g) General date/short time:. 	11/20/2011 5:54 PM\n" +
        "(G) General date/long time: . 	11/20/2011 5:54:04 PM\n" +
        "    (default):. . . . . . . . 		11/20/2011 5:54:04 PM (default = 'G')\n" +
        "(M) Month:. . . . . . . . . . 		November 20\n" +
        "(R) RFC1123:. . . . . . . . . 	Sun, 20 Nov 2011 17:54:04 GMT\n" +
        "(s) Sortable: . . . . . . . . 		2011-11-20T17:54:04\n" +
        "(u) Universal sortable: . . . 	2011-11-20 17:54:04Z (invariant)\n" +
        "(U) Universal sortable: . . . 	Sunday, November 20, 2011 10:54:04 AM\n" +
        "(Y) Year: . . . . . . . . . . 		November, 2011\n");
Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine("sbyte:{0} to {1} ", sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine("byte:{0} to {1}", byte.MinValue, byte.MaxValue);
Console.WriteLine("short:{0} to {1}", short.MinValue, short.MaxValue);
Console.WriteLine("ushort:{0} to {1}", ushort.MinValue, ushort.MaxValue);
Console.WriteLine("int:{0} to {1}", int.MinValue, int.MaxValue);
Console.WriteLine("long:{0} to {1}", long.MinValue, long.MaxValue);
Console.WriteLine("decimal:{0} to {1}", decimal.MinValue, decimal.MaxValue);
Console.WriteLine("-------------------------------------------------------------------------------");
void MyMethod1()
{
    int num1 = 7, num2 = 9;
    Swap(ref num1, ref num2);
    // num1 = 9, num2 = 7
}
void Swap(ref int x, ref int y)
{
    int temp = x; x = y; y = temp;
}
Console.WriteLine("-------------------------------------------------------------------------------");


void MyMethod2()
{
    int num1 = 7, num2;
    Subtraction(num1, out num2);
    // num1 = 7, num2 = 5
}
void Subtraction(int x, out int y)
{
    y = x - 2;
    // y must be assigned a value
}
Console.WriteLine("-------------------------------------------------------------------------------");

void MyMethod3()
{
    int sum = Addition(1, 2, 3); // sum = 6

}
int Addition(params int[] integers)
{
    int result = 0;
    for (int i = 0; i < integers.Length; i++)
        result += integers[i];
    return result;
}
Console.WriteLine("-------------------------------------------------------------------------------");



