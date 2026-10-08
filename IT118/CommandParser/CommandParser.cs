string command = "Dance";

string normalized = command.ToLower();

switch (normalized)
{
    case "look":
        Console.WriteLine("You see a dusty room with two doors.");
        break;
    case "north":
    case "n":
        Console.WriteLine("You walk north.");
        break;
    case "south":
    case "s":
        Console.WriteLine("You walk south.");
        break;
    case "quit":
    case "exit":
    case "q":
        Console.WriteLine("Goodbye!");
        break;
    default:
        Console.WriteLine($"I don't understand '{command}'.");
        break;
}