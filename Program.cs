Console.WriteLine("Введите пятизначное число");
int == Convert.ToInt32(Console.ReadLine());

if ((n/10000) == (n %10)) n = (n/10) % 1000;
if ((n/100) == (n %10)) Console.WriteLine("Полиндром");
else System.Console.WriteLine("Не полиндром");
