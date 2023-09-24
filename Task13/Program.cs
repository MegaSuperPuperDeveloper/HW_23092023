Console.Write("Введите число: ");
string digit = Console.ReadLine();
int length = digit.Length;
if(length < 3) {
    Console.WriteLine($"{digit} -> третьей цифры нет");
} else {
    char ThirdDigit = digit[2];
    Console.WriteLine(ThirdDigit);
}