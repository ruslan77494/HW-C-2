/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
Console.WriteLine(" Пожалуйста Введите  Число");
int n = Convert.ToInt32(Console.ReadLine());
string strr = n.ToString();
int  length = n;
if (length >= 100)
{
    Console.WriteLine($"{n} -> {strr[2]}");
}
else if (length < 100) 
{
    Console.WriteLine("Третьей цифры нет");
}



