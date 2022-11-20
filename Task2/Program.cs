// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры не существует

Console.Write("Введите число: ");
string N = Convert.ToString(Console.ReadLine());

if (N.Length > 2)
{
  Console.WriteLine(N[2]);
}
else
{
  Console.WriteLine("третьей цифры не существует");
}