static void Main(string[] args)
{
    Console.Title = "Binary Clock";
    Console.SetWindowSize(50, 10);

    while (true)
    {
        Console.Clear();
        DisplayBinaryClock();
        System.Threading.Thread.Sleep(1000);
    }
}

static void DisplayBinaryClock()
{
    DateTime currentTime = DateTime.Now;

    int hour = currentTime.Hour;
    int minute = currentTime.Minute;
    int second = currentTime.Second;

    Console.WriteLine("Hour\t\tMinute\t\tSecond");

    DisplayBinaryValue(hour, 5);
    Console.Write("\t\t");
    DisplayBinaryValue(minute, 6);
    Console.Write("\t\t");
    DisplayBinaryValue(second, 6);
    Console.WriteLine();
}

static void DisplayBinaryValue(int value, int length)
{
    string binary = Convert.ToString(value, 2).PadLeft(length, '0');
    Console.Write(binary);
}
