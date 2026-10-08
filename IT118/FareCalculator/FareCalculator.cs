int age = 70;
bool isStudent = true;

if (age < 5)
{
    Console.WriteLine("Free ride");
}
else if (age >= 65)
{
    Console.WriteLine("Senior fare: $1.25");
}
else if (age <= 17 || isStudent)
{
    Console.WriteLine("Youth/student fare: $1.50");
}
else
{
    Console.WriteLine("Adult fare: $2.75");
}