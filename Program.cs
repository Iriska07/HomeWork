//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
    //14212 -> нет
    //12821 -> да
    //23432 -> да
Console.WriteLine("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int [5];
array[0] = num/10000;
array[1] = (num/1000)%10;
array[3] = (num/10)%10;
array[4] = num%10;
if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}