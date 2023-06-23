Console.Write("Введите число: ");
string number_str = Console.ReadLine();
char[] number_array = number_str.ToCharArray();
int result_sum = 0;
foreach (char i in number_array)
    result_sum += Convert.ToInt32(char.ToString(i));
Console.Write(result_sum);