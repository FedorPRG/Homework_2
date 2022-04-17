int decision(int a)
{
    int result = a / 100 * 10 + a % 10;
    return result;
}

int a = new Random().Next(100,1000);
Console.WriteLine($"{a}->{decision(a)}");

a = new Random().Next(100,1000);
Console.WriteLine($"{a}->{decision(a)}");

a = new Random().Next(100,1000);
Console.WriteLine($"{a}->{decision(a)}");
