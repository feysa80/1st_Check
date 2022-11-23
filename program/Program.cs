//Задание: Написать программу, кторая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.

using System;
Console.Clear();
Console.WriteLine("Задание: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
String[] array = new String[n];
int count = 0;
for (int i = 0; i < n; i++ ){
    Console.Write($"Введите {i+1}-й элемент: ");
    array[i] = Console.ReadLine();
    if(array[i].Length <= 3) count++;
}
if (count == 0) Console.WriteLine("Элементов, удовлетворяющих условию нет");
else{
    int index =0;
    String[] arrray2 = new String[count];
    for (int i = 0; i < n; i++ ){
    if(array[i].Length <= 3) {
        arrray2[index] = array[i]; 
        index++;
    }
    }
    Console.Write("Массив элементов, удовлетворяющих условию: ");
    Console.WriteLine(String.Join("; ", arrray2));
}


