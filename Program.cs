// See https://aka.ms/new-console-template for more information

Console.Write("ВВЕДИТЕ ЧИСЛО А - ");
int a = Int32.Parse(Console.ReadLine());
Console.Write("ВВЕДИТЕ ЧИСЛО Б - ");
int b = Int32.Parse(Console.ReadLine());

int c = a - b;
int d = a + b;
int e = a * b;
float f1 = a / b;
double f = (double)a / (double)b;
int g = a % b;

Console.WriteLine("ВАШ РЕЗУЛЬТАТ");

Console.WriteLine("Разность - " + c.ToString());
Console.WriteLine("СУММА - " + d.ToString());
Console.WriteLine("ПРОИЗВЕДЕНИЕ - " + e.ToString());
Console.WriteLine("Деление - " + f.ToString());
Console.WriteLine("Деление_1 - " + f1.ToString());
Console.WriteLine("Остаток - " + g.ToString());
