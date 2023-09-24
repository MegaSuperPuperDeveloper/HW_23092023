string[] week = {"нет", "нет", "нет", "нет", "нет", "да", "да"};
Console.Write("Введите число от 1 до 7: ");
short a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"{a} = {week[a - 1]}");