class Program
{
    
    static void Main(string[] args)
    {
        Dictionary<string, string> myDic = new Dictionary<string, string>();

        myDic.Add("Машина", "Тесла");
        myDic.Add("Дом", "Коттедж");
        myDic.Add("Собака", "Шпитц");
        myDic.Add("Страна", "Ирландия");

        Console.WriteLine("\nПары");
        foreach (KeyValuePair<string, string> pair in myDic) { Console.WriteLine($"{pair}"); }

        Console.ReadLine();


    }
}
