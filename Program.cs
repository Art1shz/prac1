using System.Runtime.CompilerServices;
using System.Threading.Tasks;

Console.WriteLine("Введите a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("a^3-3a^2b+3ab^2-b^3 = (a - b)^3");
int otvet1 = Convert.ToInt32(Math.Pow(a - b, 3));
Console.WriteLine($"({a} - {b})^3 = {otvet1} при а={a}, b={b}");

Console.WriteLine("a^3+3a^2b+3ab^2+b^3 = (a + b)^3");
int otvet2 = Convert.ToInt32(Math.Pow(a + b, 3));
Console.WriteLine($"({a} + {b})^3 = {otvet2} при а={a}, b={b}");

Console.WriteLine("(a+b)(a^2-ab+b^2) = a^3 + b^3");
int a1 = Convert.ToInt32(Math.Pow(a, 3));
int b1 = Convert.ToInt32(Math.Pow(b, 3));
int otvet3 = a1+b1;
Console.WriteLine($"{a}^3 + {b}^3 = {otvet3} при а={a}, b={b}");

Console.WriteLine("(a-b)(a^2+ab+b^2) = a^3 - b^3");
int a2 = Convert.ToInt32(Math.Pow(a, 3));
int b2 = Convert.ToInt32(Math.Pow(b, 3));
int otvet4 = a2 - b2;
Console.WriteLine($"{a}^3 - {b}^3 = {otvet4} при а={a}, b={b}");

Console.WriteLine("(a - b) * (a + b) = a^2 - b^2");
int a3 = Convert.ToInt32(Math.Pow(a, 2));
int b3 = Convert.ToInt32(Math.Pow(b, 2));
int otvet5 = a3 - b3;
Console.WriteLine($"{a}^2 - {b}^2 = {otvet5} при а={a}, b={b}");

Console.WriteLine("a^2-2ab+b^2 = (a - b)^2");
int otvet6 = Convert.ToInt32(Math.Pow(a - b, 2));
Console.WriteLine($"({a} - {b})^2 = {otvet6} при а={a}, b={b}");

Console.WriteLine("a^2+2ab+b^2 = (a + b)^2");
int otvet7 = Convert.ToInt32(Math.Pow(a + b, 2));
Console.WriteLine($"({a} + {b})^2 = {otvet7} при а={a}, b={b}");

Console.WriteLine("((a^2-4bc)/(a - a^1/2-a^c)-(abc)^3)/(a^2-2ab+b^2) = ((a^2-4bc)/(a - a^1/2-a^c)-(abc)^3)/(a-b)^2");
int a4 = Convert.ToInt32(Math.Pow(a, 2));
int a5 = Convert.ToInt32(Math.Pow(a, 1/2));
int a6 = Convert.ToInt32(Math.Pow(a, c));
int abc = Convert.ToInt32(Math.Pow(a*b*c, 3));
int ab = Convert.ToInt32(Math.Pow(a - b, 2));
int otvet8 = ((a4 - 4 * b * c) / (a - a5 - a6) - abc) / ab;
Console.WriteLine($"(({a}^2-4*{b}*{c})/({a} - {a}^1/2-{a}^{c})-({a}*{b}*{c})^3)/({a}-{b})^2 = {otvet8} при а={a}, b={b}, c={c}");