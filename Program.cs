

//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

/* 
int[] ReversMass(int[] array){
    int temp = 0;
    for (int i = 0, j = array.Length -1 ; i < j; i++, j--)   // этот вариант лучше т.к. меньше строк...  
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp; 
    } 
   /*  int i = 0;
    int j = array.Langht;
    while (i<j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        i++;
        j--;
    } 

    return array;
 
}

int[] array = {1,3,6,7,2,0};
int[] revMas =  ReversMass(array);
for (int i = 0; i < revMas.Length; i++)
{
    Console.Write(revMas[i]+" ");
}

 */








//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 19/2   9 1
// 9/2    4 1
// 4/2    2 0
// 2/2    1 0
// 1/2    0 1  
// 19 -> 10011
/* 
string ChangeDigitSystem(int n){
    string result = string.Empty;
    while (n>0)
    {
        result = n%2 + result;
        n/=2;
    }
    return result;
}   
Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
string res = ChangeDigitSystem(n);
Console.WriteLine(res);
 */



// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о не раенстве треугольника: каждая сторона трекгольника меньше суммы двух других сторон.

/* 
void Treugolnik(int a, int b, int c){
if (a>b+c && b>a+c && c>a+b){
    Console.WriteLine("Нет");}
else Console.WriteLine("Да");
}

Console.Write("Первая сторона: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая сторона: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Третья сторона: ");
int c = Convert.ToInt32(Console.ReadLine());
Treugolnik(a,b,c);

 */












//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//


//Задача.Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/* 
int[] Fibon(int n){
    int[] array = new int[n];
    array[0]=0;
    array[1]=1;
    for(int i=2; i<n; i++){
       array[i] = array[i-2] + array[i-1]; 
    }
    return array;
}

void ShowArray(int[] array){                             
    for(int i = 0; i<array.Length; i++){
    Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibon(n));

 */



