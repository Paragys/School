# IT 118 Final Project: Starter

This project already builds and runs. It uses a made-up student roster as a worked
example. Your job is to replace the example with your own scenario:

- A. Campus Library Desk
- B. Food Truck Ordering
- C. Pet Adoption Shelter

## Run it

    dotnet run

(In Visual Studio, open `IT118Project.csproj` and press Run.)

## What is in the starter

| File | What it shows |
| --- | --- |
| `Program.cs` | A menu that loops until Exit, using `while` and `switch` |
| `InputHelper.cs` | Input methods that use `TryParse` and never crash on bad input |
| `Student.cs` | Encapsulation: private fields, a constructor, properties |
| `StudentRoster.cs` | A manager class with a `List`, seed data, listing, and searching |

## Part 1 checklist

- [ ] Pick your scenario and write the design document
- [ ] Rename `Student` to your item class and `StudentRoster` to your manager class
- [ ] Replace the fields, properties, and methods with ones that fit your scenario
- [ ] Seed at least 3 records
- [ ] At least 4 working menu actions, including list all and search
- [ ] At least 3 methods of your own
- [ ] Both partners add a line to your contribution log for each work session

## Looking ahead

- Part 2: your item class becomes a base class with derived classes (inheritance).
- Part 3: add an abstract base class and an interface.
  Keep your item class easy to extend.
