class Program
{
    public delegate void MyDelegate();
    static void Main()
    {
        MyDelegate mD = new MyDelegate(delegate
        {
            Console.WriteLine("Hello, Dear Friend");
        });
        mD();
    }
}