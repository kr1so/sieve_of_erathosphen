/* Вход: натуральное число n
Выход: все простые числа от 2 до n.

Пусть A — булевый массив, индексируемый числами от 2 до n, 
изначально заполненный значениями true.

 для i := 2, 3, 4, ..., пока i2 ≤ n:
  если A[i] = true:
    для j := i2, i2 + i, i2 + 2i, ..., пока j ≤ n:
      A[j] := false

 возвращаем: все числа i, для которых A[i] = true. */

int n = 853;
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
System.Console.WriteLine(Sieve);