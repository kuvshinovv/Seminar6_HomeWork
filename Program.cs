//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/* 
 void ShowArray(int[] array){
    int count = 0;
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0){
            count++;
        } 
        Console.Write(array[i]+" ");
    }
    Console.Write($"] -> ");
    Console.WriteLine($"Вы ввели {count} чисел больше 0");
}


Console.WriteLine("Введите количество чисел, которое будете вводить: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] mass = new int[size];

int i = 0; 
while ( i <= size-1 )        // Использовал while т.к. начальный и конечный индексы статичны и не изменяются по ходу нашей программы и манипуляций не производим с ними, 
                            // хотя с точки зрения количества строк я бы сделал всетаки for
                            // или возможно я не понял, когда какой цикл использовать  :)) 
{
    Console.WriteLine($"Введите {i+1} число");
    mass[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
ShowArray(mass);
 */








//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

// сначала приравниваем обе части равенств 
//k1 * x + b1 = k2 * x + b2    ->    и находим х
double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine($"Точка пересечения двух прямых будет в координатах (х={x}), (y={y})");
