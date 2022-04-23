Console.Write("Введите цифру: ");
int number = int.Parse(Console.ReadLine());
if (number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int index = 10;
    while (index < number)
    {
        index = index * 10;
    }
    int x = (number / (index / 1000)) % 10;//ищем третье число
    Console.WriteLine($"Третье число цифры {number} -> {(x)}");
}
