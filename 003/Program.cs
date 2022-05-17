/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Пожалуста Введите число:  ");

int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
      case 1:
           {
             System.Console.WriteLine($"{number} -> НЕТ");
             break;
           } 
      case 2:
           {
             System.Console.WriteLine($"{number} -> НЕТ");
             break;
           }
     case 3:
           {
             System.Console.WriteLine($"{number} -> НЕТ");
             break;
           }
     case 4:
           {
             System.Console.WriteLine($"{number} -> НЕТ");
             break;
           } 
      case 5:
           {
             System.Console.WriteLine($"{number} -> НЕТ");
             break;
           }
     case 6:
           {
             System.Console.WriteLine($"{number} -> ДА");
             break;
           }
     case 7:
           {
             System.Console.WriteLine($"{number} -> ДА");
             break;
           }   
     default:
      {
              System.Console.WriteLine("Всего 7 дней в недели! ");
             break;
      }
}




