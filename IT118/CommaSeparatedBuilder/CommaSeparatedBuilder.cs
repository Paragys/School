using System.Text;

string[] numbers = { "1", "2", "3", "4", "5" };

StringBuilder nums = new StringBuilder();

foreach (string num in numbers)
{
    nums.Append(num);
    nums.Append(", ");
}

Console.WriteLine(nums.ToString());