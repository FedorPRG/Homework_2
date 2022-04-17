Console.Write("Введите цифру: ");
int number = int.Parse(Console.ReadLine());

if (number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
int index = 1;
int discharge = 10;
while (index < 1000)
{
    if (number / discharge == 0)
    {
        break;
    }
    discharge = discharge * 10; index = index + 1;
}
Console.WriteLine(discharge);
Console.WriteLine(index);
Console.WriteLine(number);
