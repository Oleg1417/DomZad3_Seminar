//                                      Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли 
//                                  оно палиндромом.


//  Вариант 1
 Console.WriteLine("Введите пятизначное число");
 int number = int.Parse(Console.ReadLine()!);
if (number < 10000 || number > 99999){
    Console.WriteLine("Введено неверное число");
}
//int number = new Random().Next(10000, 100000); // Получить палиндромом невозможно(((
int a1 = number / 10000;
int a2 = number % 10;
int b1 = (number / 1000) % 10;
int b2 = (number % 100) / 10;

if (a1 == a2 && b1 == b2)
{
    Console.WriteLine($"Число {number} является палиндромом!");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}


//  Вариант 2
Console.WriteLine("Введите пятизначное число");
string number1 = Console.ReadLine()!;
if (number1.Length != 5)
{
    Console.WriteLine("Введено неверное число");
}
if (number1[0] == number1[4] && number1[1] == number1[3])
{
    Console.WriteLine($"Число {number1} является палиндромом!");
}
else
{
    Console.WriteLine($"Число {number1} не является палиндромом");
}



//                                      Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//                              между ними в 3D пространстве.

Console.WriteLine("Введите значение точки X1");
int X1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение точки Y1");
int Y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение точки Z1");
int Z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение точки X2");
int X2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение точки Y2");
int Y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение точки Z2");
int Z2 = int.Parse(Console.ReadLine()!);

double langth = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
Console.Write("Расстояние между точками: ");
Console.WriteLine(Math.Round(langth));



//                                      Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int num = 1;

while (num <= N){
    double result = Math.Pow(num, 3);
    Console.Write($"{result}, ");
    num++;
}