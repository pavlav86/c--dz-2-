// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write ( " Введите число (день) недели: " );
int day = int.Parse(Console.ReadLine());

if (day > 0 && day < 8)
{
  if (day > 0 && day < 6)
  {
    Console.WriteLine($"{day} -> нет");
  }
  else
  {
    Console.WriteLine($"{day} -> да");
  }
}
