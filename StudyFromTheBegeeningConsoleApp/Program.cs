Console.WriteLine("Имя первого игрока:");
string Player1= Console.ReadLine();
Console.WriteLine("Имя второго игрока:");
string Player2= Console.ReadLine();
Random random = new Random();
int firstValue = random.Next(12, 121);
for (int i = 0; i < firstValue; i++)
{
    Console.WriteLine($"Загаданное число: {firstValue}");
    Console.WriteLine($"{Player1} вводит число:");
    int enterValue1=int.Parse(Console.ReadLine());
    firstValue-= enterValue1;
    Console.WriteLine($"{Player2} вводит число:");
    int enterValue2 = int.Parse(Console.ReadLine());
    firstValue-=enterValue2;
    if(firstValue<=0)
    {
        Console.WriteLine("Конец!");
        break;
    }

}
Console.ReadKey();
