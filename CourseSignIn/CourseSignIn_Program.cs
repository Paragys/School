// Wecome Banner
Console.WriteLine("Welcome to IT118: Introduction to Programming!");
Console.WriteLine("This is a course that will teach you the basics of programming in C#.");
// Ask user for name and store it in a variable
Console.Write("What is your name? ");
string? name = Console.ReadLine();
Console.WriteLine($"Nice to meet you, {name}!");
// Ask user for previous programming experience and store it in a variable
Console.Write("Do you have any previous programming experience? (yes/none) If yes, please specify the language(s): ");
string? experience = Console.ReadLine();
// Ask user how many hours per week they plan to dedicate to the course and store it in a variable
Console.Write("How many hours per week do you plan to dedicate to this course? ");
string? hoursInput = Console.ReadLine();
// Calculate the total number of hours the user will dedicate to the course over the term (assuming a 10-week term) and store in a variable
int totalHours = int.Parse(hoursInput!) * 10;
Console.WriteLine($"Great! You plan to dedicate {hoursInput} hours per week to this course. Over the course of the term, that will add up to roughly {totalHours} hours of learning and practice!");
// Give a summary message that includes name, proor experience, planned weekly hours, and calculated total term hours
Console.WriteLine($"Alright, {name}, hope you're ready for a fun term!");
// Give personalized message based on whether theuser has experience in programming or not
if (experience == "none")
    Console.WriteLine($"Don't worry, {name}, we'll start from the basics and build your skills step by step!");
else
    Console.WriteLine($"That's awesome, {name}! Your experience in {experience} will definitely give you a head start in this course!");
// Final message of encouragement
Console.WriteLine($"Thanks for sharing a little about yourself, {name}! You should really stop filling this out and get to work on your first assignment! I hope you have a great term!");