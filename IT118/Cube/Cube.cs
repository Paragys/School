int[] Values = { 2, 3, 4 };

foreach (int val in Values)
{
    int resultFull = Cube(val);
    int resultExport = CubeExport(val);

    Console.WriteLine($"Starting value: {val}, cubed is {resultExport}");
}


static int Cube(int x)
{
    return x * x * x;
}

static int CubeExport(int x) => x * x * x;