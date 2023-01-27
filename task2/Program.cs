//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Enter your number: ");
int num = int.Parse(Console.ReadLine());

if (num < 100) 
{
  Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
  while(num > 999)
  {
    num /= 10;
    Console.WriteLine(num);
  }
  int thirdNum = num % 10;
  Console.WriteLine($"{num} -> {thirdNum}");
}
