// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите 5-ти значное число и вы узнаете являеться ли оно палиндромом: ");
int num = Convert.ToInt32(Console.ReadLine());
string fiveNum = Convert.ToString(num);
if (fiveNum[0] == fiveNum[4] && fiveNum[1] == fiveNum[3])
{
    Console.WriteLine($"Число {num} является палиндромом!!!");
}
else 
{
 Console.WriteLine($"Число {num} не является палиндромом!!!");
}
