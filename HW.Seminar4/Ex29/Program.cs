// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int NumEnter(string str)
{
System.Console.WriteLine(str);
int num = int.Parse(Console.ReadLine());
return num;
} 

int [] GetRandomArray(int size, int begin = 0, int last = 1000)
{
int[] arr = new int[size];
Random random = new Random();
for (int i = 0; i < size; i++)
{
     arr[i] = random.Next(begin, last + 1);
}

return arr;
}


int size = 8;

int [] arr =  GetRandomArray(size);

System.Console.WriteLine($"[{String.Join(",", arr)}]");