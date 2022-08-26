 /* Задача 19

Напишите программу, которая принимает на вход
 пятизначное число и проверяет,
 является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */


Console.WriteLine("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
int a1= a/100;
int a2 = a1/10;
int b1 = a/100;
int b2 = b1/10;
int c = a2 = b2;
if (a2 == b2)
{ 
 Console.WriteLine(a2 + "," + b2 + "->  Palindrom");
}
 //if (не знаю что ввести)
{
    Console.WriteLine( "->  no Palindrom");
}


/* Задача 21

Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние 
между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
 */

/* Console.WriteLine("Введите коордитаты x1");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z1");
double z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите коордитаты x2");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коордитаты y2");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коордитаты z2");
double z2 = double.Parse(Console.ReadLine());
double c1 = Math.Pow(x2-x1, 2);
double c2 = Math.Pow(y2-y1, 2);
double c3 = Math.Pow(z2-z1, 2);
double res = Math.Sqrt(c1 + c2 +c3);
Console.WriteLine(res); */

/* Задача 23

Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
int i = 1;
Console.Write(N +"-> ");

while (i <= N)
{

Console.Write(Math.Pow(i, 3) + "," );
i++;

} */

Задача 13

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
string number = a.ToString();
if (a < 100)
{
  Console.WriteLine(a + " -> Третьей цифры нет");
}
else if (a > 99)
{
  Console.WriteLine(a + " -> Вывести 3 цифру -> " + number[2]);
}