// Task 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = Numbers("Введите положительное число m: ");
int n = Numbers("Введите положительное число n: ");

int function = Af(m, n);

Console.Write($"Функция Аккермана = {function} ");

int Af(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Af(m - 1, 1);
  else return Af(m - 1, Af(m, n - 1));
}

int Numbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}