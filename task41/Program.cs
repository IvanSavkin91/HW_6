/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

void Task41()
{
    int numberUser = 7;
    int count = 0;
    for ( int i = 0; i < numberUser; i++)
    {
        Console.WriteLine($"Введите {i+1}-е число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0 ) count ++;
    }
        Console.WriteLine("Колличество введеных чисел больше нуля :" + count);
}
Task41();