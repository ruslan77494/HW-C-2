/* Задача 1: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine(" Пожалуйста Введите Число:   ");
int n = Convert.ToInt32(Console.ReadLine());

string strr = n.ToString();

Console.WriteLine($"{n} -> {strr[1]}");

