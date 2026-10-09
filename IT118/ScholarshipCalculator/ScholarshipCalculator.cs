double gpa = 3.4;
int creditsThisTerm = 12;
bool isResident = true;
string financialNeed = "Low";
string normalized = financialNeed.ToLower();

if (creditsThisTerm < 6)
{
    Console.WriteLine("Not eligible: must be enrolled in at least 6 credits.");
}
else if (gpa < 2.5)
{
    Console.WriteLine("Not eligible: GPA below 2.5 minimum.");
}
else
{
    int baseAward = gpa switch
    {
        >= 3.75 => 4000,
        >= 3.5 => 3000,
        >= 3 => 2000,
        _ => 1000
    };
    int needBonus = 0;
    switch (financialNeed)
    {
        case "High":
            needBonus = 1500;
            break;
        case "Medium":
            needBonus = 750;
            break;
        case "Low":
            needBonus = 0;
            break;
        default:
            needBonus = 0;
            Console.WriteLine($"Warning: unrecognized financial need '{financialNeed};'no need bonus applied");
            break;
    };
    int residentBonus = (isResident, creditsThisTerm) switch
    {
        (true, >=12) => 500,    
        _ => 0
    };

    int total = baseAward + needBonus + residentBonus;
    if (total > 5000)
    {
        Console.WriteLine("Award capped at 5000.");
        total = 5000;
    }

Console.WriteLine($"Base: {baseAward}, Need bonus: {needBonus}, Resident bonus: {residentBonus}");
Console.WriteLine($"Scholarship award: ${total}");

}
