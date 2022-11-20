//Программа, принимающая на вход трехзначное число и на выходе показывающая вторую цифру этого числа.

Console.WriteLine("Ведите трёхзначное число: ");
int threeDigitN = Convert.ToInt32(Console.ReadLine());

int twoDigitN = threeDigitN / 10;
int secondDigit = twoDigitN % 10;

if(threeDigitN < 99 || threeDigitN > 1000)
{
    Console.WriteLine("Вы ввели некорректное число!");
}
else 
{
    Console.WriteLine(secondDigit);
}





