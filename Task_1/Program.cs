Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < degree; i++)
    result = result * number;
Console.Write(result);