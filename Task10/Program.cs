Console.Write("Введите трехзначное число: ");
short a = Convert.ToInt16(Console.ReadLine());
int res = ((a % 100) - (a % 10)) / 10;
Console.WriteLine($"{a} -> {res}");