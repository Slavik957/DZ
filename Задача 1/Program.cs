﻿//Напишите программу, которая на вход принимает 
//два числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число!");
int a  = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число!");
int b  = int.Parse(Console.ReadLine());
if (a > b){
    Console.WriteLine($"Больше: {a}");
}
else Console.WriteLine($"Больше: {b}");
    