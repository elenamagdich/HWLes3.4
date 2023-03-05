// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void Numbers (int A, int B)
{
int exponentiation = 1;
for (int i = 1; i <= B; i++)
{
  exponentiation = exponentiation * A;
}
Console.Write(exponentiation + " ");
}

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Numbers(A,B);
