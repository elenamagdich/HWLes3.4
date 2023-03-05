// // Задача 27: Напишите программу, которая принимает на
// // вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12


int GetQuant(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count ++;
    }
    return count;
}

void SumNum (int number, int length)
{
    int sum = 0;
    for (int i = 0; i <= length; i++)
      {
        sum = sum + number % 10;
        number = number / 10;
            }
Console.WriteLine(sum);
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = GetQuant(number);
SumNum(number, length);


