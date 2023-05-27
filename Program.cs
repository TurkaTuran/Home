Console.Clear();
Console.WriteLine("Задача 19");
Console.Write("Введите число");
int num = int.Parse(Console.ReadLine());

string str = num.ToString();

if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}

Console.WriteLine("Задача 19 (Универсальный вар)");
Console.Write("Введите число");
int num2 = int.Parse(Console.ReadLine());

int length = num2.ToString().Length;
string str2 = num2.ToString();

int j = 0;

string res = "Да";

int cycles = 0;
int c2 = 2/4;

if (length % 2 != 0)
{
    cycles = cycles / 2;
    cycles = cycles - c2;
}
else 
{
    cycles = cycles / 2;
}

while (j <= cycles)
{
    length = length - 1;
    if (str2[j] == str2[length])
    {
        res = "Да";
    }
    else 
    {
        res = "Нет";
    }
    j++;
}

Console.WriteLine(res);

Console.WriteLine("Задача 21");
Console.Write("Введите x1");
double x1 = int.Parse(Console.ReadLine());

Console.Write("Введите y1");
double y1 = int.Parse(Console.ReadLine());

Console.Write("Введите z1");
double z1 = int.Parse(Console.ReadLine());

Console.Write("Введите x2");
double x2 = int.Parse(Console.ReadLine());

Console.Write("Введите y2");
double y2 = int.Parse(Console.ReadLine());

Console.Write("Введите z2");
double z2 = int.Parse(Console.ReadLine());



double s = Math.Sqrt(Math. Pow(x1 - x2, 2) + Math. Pow(y1 - y2, 2) + Math. Pow(z1 - z2, 2));

Console.WriteLine(s);

Console.WriteLine("Задача 23");
Console.Write("Введите num");
int num1 = int.Parse(Console.ReadLine());

int i = 1;
while (i<=num1)
{
    Console.WriteLine(Math.Pow(i, 3));
    i++;
}

Console.WriteLine("Доп Задание");
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

List<int> list = new List<int>();

int g = 1;
while (g <= n)
{
    Console.Write("Введите сторону монеты 1 или 0: ");
    int l = int.Parse(Console.ReadLine());
    list.Add(l);
    g++;
}

Console.Write("Было: ");
foreach (int number in list)
{
    Console.Write($"{number}, ");
}

Console.Write("Стало: ");
int k = 0;

while (k != n)
{
    if (list[k] != 1)
    {
        list[k] = 1;
        k++;
    }
    else
    {
        k++;
    }
}
foreach (int number in list)
{
    Console.Write($"{number}, ");
}