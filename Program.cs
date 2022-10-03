/*
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру число
int number = new Random().Next(10,100);
int numb1 = number / 10;
int numb2 = number % 10;
int max = numb1;
if (max < numb2){
    max = numb2;
}

Console.WriteLine($"Максимальная цифра числа {number} = {max}");
*/
/*
// Написать программу, которая выводитт случайное трехзначное число и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
int num1 = number / 100;
int num2 = number % 10;
int num3 = num1 * 10 + num2;
Console.WriteLine(number);
Console.WriteLine(num3);
*/

/*
// Написать программу, которая на вход принимает 2 числа и выводит, является ли второе число кратным первому, если второе число не кратно первому, то прграмма выводит остаток от деления

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второое число");
int num2 = int.Parse(Console.ReadLine());
if(num1 % num2 == 0){
    Console.WriteLine("Кратно");
}
else {
    int num3 = num1 % num2;
    Console.WriteLine($"Не кратно, остаток {num3}");
}
*/

/*
// Написать программу, которая принимает число на вход и проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
if ((num1 % 7 == 0) && (num1 % 23 == 0))
{
    Console.WriteLine("Кратно 7 и 23");
}
else 
{
    Console.WriteLine("Не кратно 7 и 23");
}
*/

//
