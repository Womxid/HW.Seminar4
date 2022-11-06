// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int NumEnter(string str)
{
System.Console.WriteLine(str);
int num = int.Parse(Console.ReadLine());
return num;
} 
int SumNums(int number)
{
int sum = 0;
while (number > 0)
{
sum += number%10;
number /= 10;
}
return sum;
}

int num = NumEnter("Введите число чтобы найти сумму составляющих его цифр");
Console.WriteLine($"Сумма равна - {SumNums(num)}");