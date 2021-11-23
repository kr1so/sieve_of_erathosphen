// Рабочий код задачи решета:
Console.Clear();
System.Console.WriteLine("Программа вычисления простых чисел от min до max");
System.Console.WriteLine("Введите минимальное число");
int? min_Value = Int32.Parse (Console.ReadLine());
System.Console.WriteLine("Введите максимальное число");
int N = Int32.Parse(Console.ReadLine());
bool IsPrimeNumber(int number)
{
    if (number<2) return false;
    for (int i = 2; i < number; i++)
    {
        if (number%i==0)return false;
    }
    return true;
}
System.Console.WriteLine("Таблица простых чисел от min до max");
for (int i = min_Value.Value; i <= N; i++)
{
    if (IsPrimeNumber(i))System.Console.WriteLine(i);
}