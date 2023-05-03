// ********************************************************
//19 ИЗ НЕОБЯЗАТЕЛЬНЫХ (ОБЪЕДИНЕНО С 19 ИЗ ОБЯЗАТЕЛЬНЫХ):
//Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. 
// Через строку нельзя решать само собой.
// Boolean Palindrom(int x){
//     int num = x;
//     int res = 0;
//     while (num > 9){
//         res = (res + num % 10) * 10;
//         num = num / 10;
//     }
//     res = res + num % 10;
// return x == res;
// }
// // проверка:
// Console.WriteLine(Palindrom(23432)); 
// ********************************************************



// ********************************************************
// 21 ИЗ НЕОБЯЗАТЕЛЬНЫХ (ОБЪЕДИНЕНО С 21 ИЗ ОБЯЗАТЕЛЬНЫХ):
// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.
// double Distance(double[] one, double[] two){
//     double s = 0.0;
//     for (int i = 0; i < one.Length; i++){
//         s = s + Math.Pow((one[i] - two[i]), 2);
//     }
// return Math.Sqrt(s);
// }



// Console.WriteLine("Введите размерность пространства");
// int x = Convert.ToInt32(Console.ReadLine());
// double[] mas1 = new double[x];
// Console.WriteLine("Введите координаты первой точки (последовательно, через enter)");
// for (int i = 0; i < mas1.Length; i++){
//     mas1[i] = Convert.ToDouble(Console.ReadLine());
// }
// Console.WriteLine("Введите координаты второй точки (последовательно, через enter)");
// double[] mas2 = new double[x];
// for (int i = 0; i < mas2.Length; i++){
//     mas2[i] = Convert.ToDouble(Console.ReadLine());
// }
// Console.WriteLine("Расстояние между точками: " + Distance(mas1, mas2));
// ********************************************************



// ********************************************************
// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// string Cube(int N){
//     string res = "";
//     for (int i = 1; i <= N; i++){
//         res = res + Math.Pow(i, 3) + " ";
//     }
//     return res;
// }
// //проверка:
// Console.WriteLine(Cube(5));
// ********************************************************




// ********************************************************
// Задача 3 НЕОБЯЗАТЕЛЬНАЯ. Напишите программу для.
// проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (Теорема Де Моргана) .
// Но теперь количество предикатов не три, а генерируется случайным образом от 5 до 25, 
// сами значения предикатов случайные, проверяем это утверждение 100 раз, 
// с помощью модуля time выводим на экран , сколько времени отработала программа. 
// В конце вывести результат проверки истинности этого утверждения.
// DateTime dt = new DateTime();
// DateTime time_start = DateTime.Now;
// bool res = true;
// Random rnd = new Random();
// int count = rnd.Next(5, 26);

// for (int j=1; j <= 100; j++){
// bool p = Convert.ToBoolean(rnd.Next(2));
// bool left = p;
// bool right = !p;
// for (int i = 1; i < count; i++)
// {   
//     p = Convert.ToBoolean(rnd.Next(2));
//     left = left | p;
//     right = right & !p;
// }
// res = res & (!left == right);
// }
// Console.WriteLine("Результат:" + res);
// DateTime time_end = DateTime.Now;
// Console.WriteLine("Время работы программы составляет: " + time_end.Subtract(time_start));
// ********************************************************
// Вариант с выводом проверок
DateTime dt = new DateTime();
DateTime time_start = DateTime.Now;
bool res = true;
Random rnd = new Random();
int count = rnd.Next(5, 26);
bool[] mas = new bool[count];
for (int j=1; j <= 100; j++){
    bool p = Convert.ToBoolean(rnd.Next(2));
    bool left = p;
    bool right = !p;
    mas[0] = p;
    for (int i = 1; i < count; i++)
    {   
        p = Convert.ToBoolean(rnd.Next(2));
        mas[i] = p;
        left = left | p;
        right = right & !p;
    }
    Console.WriteLine();
    Console.WriteLine("¬(" + string.Join(" V ", mas)  + ") ==  ¬" + string.Join(" &  ¬", mas) + ")   " + "результат: " + (!left == right));
    res = res & (!left == right);
    }
Console.WriteLine("Итоговый результат 100 проверок:" + res);
DateTime time_end = DateTime.Now;
Console.WriteLine("Время работы программы составляет: " + time_end.Subtract(time_start));
