int day = new Random().Next(1,8);
Console.WriteLine($"День {day}");
if (day > 5) Console.WriteLine("ВЫХОДНОЙ УРА!!!!");
else Console.WriteLine ("Будничный день");
