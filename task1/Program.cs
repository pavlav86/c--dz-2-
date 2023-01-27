// напишите программу которая на вход принимает трехзначное число и на выходе показывает вторую цыфру этого числа
int num = new Random().Next(100, 1000) ;
Console.WriteLine ($"{num} ") ;
int result = num / 10 % 10 ;
Console.WriteLine ($"{result} ") ;

