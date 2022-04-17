Console.Write("Введите цифру: ");
int number = int.Parse(Console.ReadLine());

if (number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
int index = 1;
int discharge = 10;
while (index < 1000000)
{
    if (number / discharge == 0)
    {
        break;
    }
    discharge = discharge * 10; index = index + 1;
}

int x = (number / ((int)Math.Pow(10, (index - 3)))) % 10;

Console.WriteLine($"Третье число цифры {number} -> {(x)}");

