double weightKg = -3;

string result =  weightKg switch
{
    > 0 and < 0.5 => "Letter ($3.50)",
    >= 0.5 and < 2 => "Small parcel ($7.25)",
    >= 2 and < 10 => "Medium parcel ($14.00)",
    >= 10 and <= 25 => "Large parcel ($26.50)",
    > 25 => "Too heavy: contact the freight desk",
    _ => "Invalid weight"
};

Console.WriteLine($"{weightKg}kg: {result}.");