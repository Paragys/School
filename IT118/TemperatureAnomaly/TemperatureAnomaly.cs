int[] temperatures = { 45, 52, 48, 90, 55, 60 };

foreach (int temp in temperatures)
{
    if (temp > 80)
    {
        Console.WriteLine($"Anomaly detected, stopping.");
        break;
    }
    Console.WriteLine(temp);
}


 
