// Описание с Википедии.
/* Вход: натуральное число n
Выход: все простые числа от 2 до n.
Пусть A — булевый массив, индексируемый числами от 2 до n, 
изначально заполненный значениями true.

 для i := 2, 3, 4, ..., пока i2 ≤ n:
  если A[i] = true:
    для j := i2, i2 + i, i2 + 2i, ..., пока j ≤ n:
      A[j] := false

 возвращаем: все числа i, для которых A[i] = true. */
// Моя 1 попытка переписать на изученном коде.
/* int n = 853;
bool Sieve(bool[] A)
{
  int i = 2;
  bool[] A = (2,n);
  while ((i*i)<n)
  {
       i++;
       if (A[i])
       {
           for (int j = i*i; j <= n; j++)
           {
               return A[i];
           }
       }
  }
}
System.Console.WriteLine(Sieve); */

// Моя 2 попытка.

/*  int[] Fill_Array (int[] array_fill, int min) 
{
    int length = array_fill.Length;
    int i = 0;
    while (i<length)
    {
        array_fill[i] = min + i;
        i++;
    } 
    return array_fill;
}
void Print_Array(int[] array_print)
{
    int length_print = array_print.Length;
    for(int j = 0; j < length_print; j++)
    {
        Console.Write($"{array_print[j]}");
    }
}
Console.Clear();
int[] number = new int [1000];
int min_Value = 6;
Fill_Array(number, min_Value);
int b = 0;
while ( (number[b] * number[b]) < number.Length)
{
    for (int c = 0; b <= number.Length; c++)
    {
        while (number[b] == 2 || number[b] == 3 || number[b] == 5 || number[b] == 7)
        {
        System.Console.WriteLine($"Это простое число: {number[b]}");
        b++;
        } 
        //(number[b] == 2 || number[b] == 3 || number[b] == 5 || number[b] == 7)
    }
}
Print_Array(number); */