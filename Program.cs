int number = new Random().Next(100,1000);
int res = (number%100-number%10)/10;
Console.WriteLine($"Число: {number}, Вторая цифра этого числа {res}");