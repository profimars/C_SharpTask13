//Задача 13
//Напишите програамму, которая выводит третью цифру заданного числа, или сообщает  
//что третьей цифры нет. Через строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//https://github.com/profimars/C_SharpTask13
Console.WriteLine("Ведите любое целое число");
int q = Convert.ToInt32(Console.ReadLine());
if (q < 100)
    Console.WriteLine("третьей цифры нет");
else if (q >= 100 && q <= 999)
{
    int q3 = q % 10;
    Console.WriteLine("Третья цифра выбранного числа = " + q3);
}
else
{
    int q123 = q;
    while (q123 > 999)
        q123 = q123 / 10;
    Console.WriteLine("Первые три цифры выбранного числа = " + q123);
    int q3 = q123 % 10;
    Console.WriteLine("Третья цифра выбранного числа = " + q3);
}
