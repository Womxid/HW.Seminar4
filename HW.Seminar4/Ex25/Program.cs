// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("Введите два числа чтобы возвести первое в степень второго");
// double num1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Теперь второе число");
// double num2 = double.Parse(Console.ReadLine());
// Console.WriteLine($"Результат равен{Math.Pow((num1),(num2))}");
double PrintEnter(string str)
{
System.Console.WriteLine(str);
double num = double.Parse(Console.ReadLine());
return num;
} 

double num1 = PrintEnter("Введите два числа чтобы возвести первое в степень второго");
double num2 = PrintEnter("Теперь второе");
Console.WriteLine($"Результат равен - {Math.Pow((num1),(num2))}");
