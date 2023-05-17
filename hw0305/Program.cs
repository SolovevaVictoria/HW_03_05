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
// DateTime dt = new DateTime();
// DateTime time_start = DateTime.Now;
// bool res = true;
// Random rnd = new Random();
// int count = rnd.Next(5, 26);
// bool[] mas = new bool[count];
// for (int j=1; j <= 100; j++){
//     bool p = Convert.ToBoolean(rnd.Next(2));
//     bool left = p;
//     bool right = !p;
//     mas[0] = p;
//     for (int i = 1; i < count; i++)
//     {   
//         p = Convert.ToBoolean(rnd.Next(2));
//         mas[i] = p;
//         left = left | p;
//         right = right & !p;
//     }
//     Console.WriteLine();
//     Console.WriteLine("¬(" + string.Join(" V ", mas)  + ") ==  ¬" + string.Join(" &  ¬", mas) + ")   " + "результат: " + (!left == right));
//     res = res & (!left == right);
//     }
// Console.WriteLine("Итоговый результат 100:" + res);
// DateTime time_end = DateTime.Now;
// Console.WriteLine("Время работы программы составляет: " + time_end.Subtract(time_start));




// ********************************************************
// Задача 4 VERY HARD. Необходимо реализовать три алгоритма сортировки одномерного массива - 
// пузырьком, быстрой сортировкой, методом подсчета. 
// Исходный массив заполняется случайными целыми числами. 
// Далее провести ряд экспериментов с различной размерностью массива, засечь время выполнения каждого, 
// объяснить в соответствии с нотацией Big O полученные результаты. 
// Выполнять всё с помощью методов. 
// Рассказать про плюсы и минусы каждого алгоритма.


int[] create_mas_input(int n){
    int[] mas = new int[n];
    Console.WriteLine($"Введите {n} целых чисел (последовательно, через enter)");
    for (int i = 0; i < mas.Length; i++){
        mas[i] = Convert.ToInt32(Console.ReadLine());
}
    return mas;
}


int[] create_mas_random(int size, int max_n){
    int[] mas = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < mas.Length; i++){
        mas[i] = rnd.Next(max_n + 1);
    }
    return mas;
}


void print_mas(int[] mas){
    Console.Write("[");
    for (int i = 0; i < mas.Length - 1; i++){
        Console.Write(mas[i] + ", ");
}
Console.Write($"{mas[mas.Length - 1]}]");
}

int[] bubble_sort(int[] mas){
    for (int i = 0; i < mas.Length; i++){
        for (int j = 0; j < mas.Length - i - 1; j++){
            if (mas[j] > mas[j + 1]){
                int save = mas[j + 1];
                mas[j + 1] = mas[j];
                mas[j] = save;
            } 
    }
    }
    return mas;
}

int[] quick_sort(int[] mas, int min_ind, int max_ind){
    if (min_ind >= max_ind){
        return mas;
    }
    int pivot = get_pivot(mas, min_ind, max_ind);
    quick_sort(mas, min_ind, pivot - 1);
    quick_sort(mas, pivot + 1, max_ind);
    return mas;
}

int get_pivot(int[] mas, int min_ind, int max_ind){
    int pivot = min_ind - 1;
    for(int i = min_ind; i <= max_ind; i++){
        if (mas[i] < mas[max_ind]){
            pivot++;
            swap(ref mas[pivot],  ref mas[i]);
        }
    }
    pivot++;
    swap(ref mas[pivot], ref mas[max_ind]);
    return pivot;
}

void swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;
        }

int min_number(int[] mas){
    int min_n = 1000000000;
    for(int i = 0; i < mas.Length; i++){
        if(mas[i] < min_n){
            min_n = mas[i];
        }
    }
    return min_n;
}

int max_number(int[] mas){
    int max_n = -1000000000;
    for(int i = 0; i < mas.Length; i++){
        if(mas[i] > max_n){
            max_n = mas[i];
        }
    }
    return max_n;
}

int[] count_sort(int[] mas, int min_numb, int max_numb){
    int[] mas_count = new int[max_numb - min_numb + 1];
    for (int i = 0; i < mas.Length; i++) { 
        mas_count[mas[i] - min_numb]++;
    }
    int j = 0;
    for (int i = min_numb; i <= max_numb; i++) {
        for (int k = mas_count[i - min_numb]; k > 0; k--)
                {
                    mas[j] = i;
                    j++;
                }
            }
   return mas; 

}
DateTime dt = new DateTime();
int[] m1 = create_mas_random(10, 1000);
int[] m2 = create_mas_random(10000, 1000);
int[] m3 = create_mas_random(100000, 1000);



print_mas(m1);

Console.WriteLine("\nСортировка пузырьком:");
Console.WriteLine($"Сложность O(n^2) т.к. на каждой итерации внешнего цикла происходит стремящееся к n число сравнений (n - 1, n - 2, ...).");
Console.WriteLine($"Плюсы: простая, минусы: медленная.");
DateTime  t1_start_bubble  = DateTime.Now;
int[] bubble_m1 = bubble_sort(m1);
DateTime t1_end_bubble = DateTime.Now;
TimeSpan t1_bubble = t1_end_bubble.Subtract(t1_start_bubble);
Console.WriteLine($"Время работы сортировки пузырьком массива из {m1.Length} элементов: {t1_bubble}");
//Console.WriteLine($"Отсортированный массив: ");
//print_mas(bubble_m1);

DateTime  t2_start_bubble  = DateTime.Now;
int[] bubble_m2 = bubble_sort(m2);
DateTime t2_end_bubble = DateTime.Now;
TimeSpan t2_bubble = t2_end_bubble.Subtract(t2_start_bubble);
Console.WriteLine($"Время работы сортировки пузырьком массива из {m2.Length} элементов: {t2_bubble}");
//Console.WriteLine($"Отсортированный массив: ");
//print_mas(bubble_m2);

DateTime  t3_start_bubble  = DateTime.Now;
int[] bubble_m3 = bubble_sort(m3);
DateTime t3_end_bubble = DateTime.Now;
TimeSpan t3_bubble = t3_end_bubble.Subtract(t3_start_bubble);
Console.WriteLine($"Время работы сортировки пузырьком массива из {m3.Length} элементов: {t3_bubble}");
//Console.WriteLine($"Отсортированный массив: ");
//print_mas(bubble_m3);



Console.WriteLine("\nБыстрая сортировка :");
Console.WriteLine($"Сложность О(n log n) т. к. алгоритм работает каджый раз с n/2, n/4, n/8 и т д элементов, что происходит n раз.");
Console.WriteLine($"Плюсы: одна из самых быстрых, лежит в основе встроенных методов сортировок, минусы: медленнее некоторых сортировок при работе с небольшими объёмами данных");
DateTime  t1_start_quick  = DateTime.Now;
int[] quick_m1 = quick_sort(m1, 0, m1.Length - 1);
DateTime t1_end_quick = DateTime.Now;
TimeSpan t1_quick = t1_end_quick.Subtract(t1_start_quick);
Console.WriteLine($"Время работы быстрой сортировки массива из {m1.Length} элементов: {t1_quick}");
//Console.WriteLine($"Отсортированный массив: ");
//print_mas(bubble_m1);

DateTime  t2_start_quick  = DateTime.Now;
int[] quick_m2 = quick_sort(m2, 0, m1.Length - 1);
DateTime t2_end_quick = DateTime.Now;
TimeSpan t2_quick = t2_end_quick.Subtract(t2_start_quick);
Console.WriteLine($"Время работы быстрой сортировки массива из {m2.Length} элементов: {t2_quick}");
//Console.WriteLine($"Отсортированный массив: ");
//print_mas(bubble_m1);

DateTime  t3_start_quick  = DateTime.Now;
int[] quick_m3 = quick_sort(m3, 0, m3.Length - 1);
DateTime t3_end_quick = DateTime.Now;
TimeSpan t3_quick = t3_end_quick.Subtract(t3_start_quick);
Console.WriteLine($"Время работы быстрой сортировки массива из {m3.Length} элементов: {t3_quick}");
//Console.WriteLine($"Отсортированный массив: ");
//print_mas(bubble_m1);



Console.WriteLine("\nСортировка подсчётом :");
Console.WriteLine($"Сложность O(n) т.к. элементы массива перебираются за 1 проход");
Console.WriteLine($"Плюсы: быстрая, минусы: требует дополнительную память, работает не со всеми типами данных");
DateTime  t1_start_count  = DateTime.Now;
int[] count_m1 = count_sort(m1, min_number(m1), max_number(m1));
DateTime t1_end_count = DateTime.Now;
TimeSpan t1_count = t1_end_count.Subtract(t1_start_count);
Console.WriteLine($"Время работы быстрой сортировки массива из {m1.Length} элементов: {t1_count}");
//Console.WriteLine($"Отсортированный массив: ");
//print_mas(bubble_m1);

DateTime  t2_start_count  = DateTime.Now;
int[] count_m2 = count_sort(m2, min_number(m2), max_number(m2));
DateTime t2_end_count = DateTime.Now;
TimeSpan t2_count = t2_end_count.Subtract(t2_start_count);
Console.WriteLine($"Время работы быстрой сортировки массива из {m2.Length} элементов: {t2_count}");
//Console.WriteLine($"Отсортированный массив: ");
//print_mas(bubble_m1);

DateTime  t3_start_count  = DateTime.Now;
int[] count_m3 = count_sort(m3, min_number(m3), max_number(m3));
DateTime t3_end_count = DateTime.Now;
TimeSpan t3_count = t3_end_count.Subtract(t3_start_count);
Console.WriteLine($"Время работы быстрой сортировки массива из {m3.Length} элементов: {t3_count}");
//Console.WriteLine($"Отсортированный массив: ");
//print_mas(bubble_m1);
