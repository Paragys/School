int daysLate = 7;
int fee;
if (daysLate >= 14) { fee = 5; }
else if (daysLate >= 7) { fee = 3; }
else if (daysLate >= 1) { fee = 1; }
else { fee = 0; }
Console.WriteLine($"{daysLate} days late -> fee ${fee}");