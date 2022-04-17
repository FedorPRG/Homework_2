Console.Write("Введите порядковый номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number == 6 | number == 7)
{
    Console.WriteLine($"{number}-> День выходной");
}
else Console.WriteLine($"{number}-> День не выходной");

