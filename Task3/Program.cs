//Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Введите число от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
Console.WriteLine("ДА");
}
else if (dayNumber < 1 || dayNumber > 7)
{
Console.WriteLine("Вы ввели неверное число, повторите попытку");
}
else
{
Console.WriteLine("Нет");
}
