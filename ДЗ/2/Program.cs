int number = new Random().Next(10,99999);
Console.WriteLine($"Число {number}");
int res = -1;
while (number > 99)
{ 
    res = number%10;
    number = number/10;
}
if (res >=0 )
{
    Console.WriteLine($"Третья цифра числа {res} ");
}
else Console.WriteLine("Третья цифра отсутствует");