﻿// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
Console.WriteLine("Введите число!");
int a  = int.Parse(Console.ReadLine());
if (a%2 == 0){
    Console.WriteLine("Является четным");
}
else  Console.WriteLine("Не является четным");
