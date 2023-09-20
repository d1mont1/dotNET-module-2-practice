using System;

class Program
{
    static void Main()
    {
        zadacha_1();
        zadacha_2();
        zadacha_3();
        zadacha_4();
        zadacha_5();
        zadacha_6();
        zadacha_7();
        zadacha_8();
        zadacha_9();
        zadacha_10();
        zadacha_11();
        zadacha_12();
        zadacha_13();
        zadacha_14();
        zadacha_15();
        zadacha_16();
        zadacha_17();
        zadacha_18();
        zadacha_19();
        zadacha_20();
        zadacha_21();
        zadacha_22();
        zadacha_23();
        zadacha_24();
        zadacha_25();
        zadacha_26();
        zadacha_27();
        zadacha_28();
        zadacha_29();
        zadacha_30();
        zadacha_31();
    }

    static void zadacha_1()
    {
        Console.WriteLine("Задача №1");
        int num1 = 5;
        int num2 = 10;
        int num3 = 21;
        Console.WriteLine($"{num1}  {num2}  {num3}");
    }

    static void zadacha_2()
    {
        Console.WriteLine("Задача №2");
        Console.WriteLine("5");
        Console.WriteLine("10");
        Console.WriteLine("21");
    }

    static void zadacha_3()
    {
        Console.WriteLine("Задача №3");
        Console.Write("Введите расстояние в сантиметрах: ");
        int distanceInCentimeters = int.Parse(Console.ReadLine());
        int meters = distanceInCentimeters / 100;
        Console.WriteLine($"Число полных метров: {meters}");
    }

    static void zadacha_4()
    {
        Console.WriteLine("Задача №4");
        int days = 234;
        int weeks = days / 7;
        Console.WriteLine($"Полных недель прошло: {weeks}");
    }

    static void zadacha_5()
    {
        Console.WriteLine("Задача №5");
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        int tens = number / 10;
        int units = number % 10;
        int sum = tens + units;
        int product = tens * units;

        Console.WriteLine($"Число десятков: {tens}");
        Console.WriteLine($"Число единиц: {units}");
        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {product}");
    }

    static void zadacha_6()
    {
        Console.WriteLine("Задача №6");
        bool A = true;
        bool B = false;
        bool C = false;

        Console.WriteLine($"A или B: {A || B}");
        Console.WriteLine($"A и B: {A && B}");
        Console.WriteLine($"B или C: {B || C}");
    }

    static void zadacha_7()
    {
        Console.WriteLine("Задача №7");
        Console.Write("Введите радиус круга: ");
        double radius = double.Parse(Console.ReadLine());

        Console.Write("Введите сторону квадрата: ");
        double side = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * radius * radius;
        double squareArea = side * side;

        if (circleArea > squareArea)
            Console.WriteLine("Площадь круга больше.");
        else if (circleArea < squareArea)
            Console.WriteLine("Площадь квадрата больше.");
        else
            Console.WriteLine("Площади равны.");
    }

    static void zadacha_8()
    {
        Console.WriteLine("Задача №8");
        Console.Write("Введите объем первого тела: ");
        double volume1 = double.Parse(Console.ReadLine());

        Console.Write("Введите массу первого тела: ");
        double mass1 = double.Parse(Console.ReadLine());

        Console.Write("Введите объем второго тела: ");
        double volume2 = double.Parse(Console.ReadLine());

        Console.Write("Введите массу второго тела: ");
        double mass2 = double.Parse(Console.ReadLine());

        double density1 = mass1 / volume1;
        double density2 = mass2 / volume2;

        if (density1 > density2)
            Console.WriteLine("Материал первого тела имеет большую плотность.");
        else if (density1 < density2)
            Console.WriteLine("Материал второго тела имеет большую плотность.");
        else
            Console.WriteLine("Плотности одинаковы.");
    }

    static void zadacha_9()
    {
        Console.WriteLine("Задача №9");
        Console.Write("Введите сопротивление первого участка цепи: ");
        double resistance1 = double.Parse(Console.ReadLine());

        Console.Write("Введите напряжение на первом участке цепи: ");
        double voltage1 = double.Parse(Console.ReadLine());

        Console.Write("Введите сопротивление второго участка цепи: ");
        double resistance2 = double.Parse(Console.ReadLine());

        Console.Write("Введите напряжение на втором участке цепи: ");
        double voltage2 = double.Parse(Console.ReadLine());

        double current1 = voltage1 / resistance1;
        double current2 = voltage2 / resistance2;

        if (current1 < current2)
            Console.WriteLine("Меньший ток протекает по первому участку цепи.");
        else if (current1 > current2)
            Console.WriteLine("Меньший ток протекает по второму участку цепи.");
        else
            Console.WriteLine("Токи равны на обоих участках.");
    }

    static void zadacha_10()
    {
        Console.WriteLine("Задача №10");
        Console.WriteLine("a. Все целые числа от 20 до 35:");
        for (int i = 20; i <= 35; i++)
        {
            Console.WriteLine(i);
        }

        Console.Write("b. Введите значение b (b > 10): ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Квадраты всех целых чисел от 10 до {b}:");
        for (int i = 10; i <= b; i++)
        {
            int square = i * i;
            Console.WriteLine(square);
        }

        Console.Write("c. Введите значение a (a < 50): ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Третьи степени всех целых чисел от {a} до 50:");
        for (int i = a; i <= 50; i++)
        {
            int cube = i * i * i;
            Console.WriteLine(cube);
        }

        Console.Write("d. Введите значение a: ");
        int a2 = int.Parse(Console.ReadLine());
        Console.Write("Введите значение b (b > a): ");
        int b2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Все целые числа от {a2} до {b2}:");
        for (int i = a2; i <= b2; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void zadacha_11()
    {
        Console.WriteLine("Задача №11");
        Console.Write("Введите значение x: ");
        int x = int.Parse(Console.ReadLine());
        int y = CalculateFunctionValue(x);
        Console.WriteLine($"Значение функции при x = {x}: {y}");
    }

    static int CalculateFunctionValue(int x)
    {
        // Здесь можно определить формулу функции и вычислить ее значение
        return x * x + 2 * x + 1;
    }

    static void zadacha_12()
    {
        Console.WriteLine("Задача №12");
        Console.Write("Введите радиус окружности: ");
        double radius = double.Parse(Console.ReadLine());

        double circumference = 2 * Math.PI * radius;
        double circleArea = Math.PI * radius * radius;

        Console.WriteLine($"Длина окружности: {circumference}");
        Console.WriteLine($"Площадь круга: {circleArea}");
    }

    static void zadacha_13()
    {
        Console.WriteLine("Задача №13");
        Console.Write("Введите расстояние в сантиметрах: ");
        int distanceInCentimeters = int.Parse(Console.ReadLine());
        int meters = distanceInCentimeters / 100;
        Console.WriteLine($"Число полных метров: {meters}");
    }

    static void zadacha_14()
    {
        Console.WriteLine("Задача №14");
        int days = 234;
        int weeks = days / 7;
        Console.WriteLine($"Полных недель прошло: {weeks}");
    }

    static void zadacha_15()
    {
        Console.WriteLine("Задача №15");
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        int tens = number / 10;
        int units = number % 10;
        int sum = tens + units;
        int product = tens * units;

        Console.WriteLine($"Число десятков: {tens}");
        Console.WriteLine($"Число единиц: {units}");
        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {product}");
    }

    static void zadacha_16()
    {
        Console.WriteLine("Задача №16");
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int thousands = number / 1000;
        int hundreds = (number / 100) % 10;
        int tens = (number / 10) % 10;
        int units = number % 10;

        int sum = thousands + hundreds + tens + units;
        int product = thousands * hundreds * tens * units;

        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {product}");
    }

    static void zadacha_17()
    {
        Console.WriteLine("Задача №17");
        int x = 456;

        int tens = (x / 100) % 10;
        int originalX = 100 * tens + x % 10;

        Console.WriteLine($"Исходное число x: {originalX}");
    }

    static void zadacha_18()
    {
        Console.WriteLine("Задача №18");
        bool[] valuesX = { true, true, false, false };
        bool[] valuesY = { true, false, true, false };

        foreach (bool X in valuesX)
        {
            foreach (bool Y in valuesY)
            {
                bool resultA = !(X || Y);
                bool resultB = X || (!X && Y);
                bool resultC = (!X && Y) || Y;

                Console.WriteLine($"a. !{X} && !{Y} = {resultA}");
                Console.WriteLine($"b. {X} || (!{X} && {Y}) = {resultB}");
                Console.WriteLine($"c. (!{X} && {Y}) || {Y} = {resultC}");
                Console.WriteLine();
            }
        }
    }

    static void zadacha_19()
    {
        Console.WriteLine("Задача №19");
        int a = 5;
        int b = 10;

        Console.WriteLine($"До обмена: a = {a}, b = {b}");
        swap1(ref a, ref b);
        Console.WriteLine($"После обмена: a = {a}, b = {b}");
    }

    static void swap1(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void zadacha_20()
    {
        Console.WriteLine("Задача №20");
        int a = 5;
        int b = 10;

        Console.WriteLine($"До обмена: a = {a}, b = {b}");
        swap2(ref a, ref b);
        Console.WriteLine($"После обмена: a = {a}, b = {b}");
    }

    static void swap2(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void zadacha_21()
    {
        Console.WriteLine("Задача №21");
        int a = 5;
        int b = 10;
        int x = 3;
        int y = 2;

        f1(ref a, ref b, x, y);

        Console.WriteLine($"a = {a}, b = {b}");
    }

    static void f1(ref int a, ref int b, int x, int y)
    {
        a = x * y;
        b = x / y;
    }

    static void zadacha_22()
    {
        Console.WriteLine("Задача №22");
        Console.Write("Введите значение x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Введите значение y: ");
        int y = int.Parse(Console.ReadLine());

        int result = f2(x, y);

        Console.WriteLine($"Результат: {result}");
    }

    static int f2(int x, int y)
    {
        if (x == 0 && y == 0)
            return 0;
        else if (y == 0)
            return 12 / x;
        else if (x == 0)
            return 12 / y;
        else
            return 144 / (x * y);
    }

    static void zadacha_23()
    {
        Console.WriteLine("Задача №23");
        Console.Write("Введите часы: ");
        int h = int.Parse(Console.ReadLine());

        Console.Write("Введите минуты: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите секунды: ");
        int s = int.Parse(Console.ReadLine());

        int seconds = f3(h, m, s);

        Console.WriteLine($"Прошло секунд с начала дня: {seconds}");
    }

    static int f3(int h, int m, int s)
    {
        return h * 3600 + m * 60 + s;
    }

    static void zadacha_24()
    {
        Console.WriteLine("Задача №24");
        Console.Write("Введите номер месяца (1-12): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите день (1-30): ");
        int d = int.Parse(Console.ReadLine());

        int days = f4(m, d);

        Console.WriteLine($"Прошло дней с начала года: {days}");
    }

    static int f4(int m, int d)
    {
        return (m - 1) * 30 + d;
    }

    static void zadacha_25()
    {
        Console.WriteLine("Задача №25");
        Console.Write("Введите номер месяца (1-12): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите день (1-31): ");
        int d = int.Parse(Console.ReadLine());

        int days = f5(m, d);

        Console.WriteLine($"Прошло дней с начала года: {days}");
    }

    static int f5(int m, int d)
    {
        int[] daysInMonth = { 30, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30, 31 };
        int days = d;
        for (int i = 0; i < m - 1; i++)
        {
            days += daysInMonth[i];
        }
        return days;
    }

    static void zadacha_26()
    {
        Console.WriteLine("Задача №26");
        Console.Write("Введите первое число (от 1 до 999): ");
        int m1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число (от 1 до 999): ");
        int m2 = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число (от 1 до 999): ");
        int m3 = int.Parse(Console.ReadLine());

        int min = f6(m1, m2, m3);

        Console.WriteLine($"Наименьшее из чисел: {min}");
    }

    static int f6(int m1, int m2, int m3)
    {
        if (m1 <= m2 && m1 <= m3)
            return m1;
        else if (m2 <= m1 && m2 <= m3)
            return m2;
        else
            return m3;
    }

    static void zadacha_27()
    {
        Console.WriteLine("Задача №27");
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine());

        bool isEven = even(n);

        if (isEven)
            Console.WriteLine($"{n} - четное число");
        else
            Console.WriteLine($"{n} - нечетное число");
    }

    static bool even(int n)
    {
        return n % 2 == 0;
    }

    static void zadacha_28()
    {
        Console.WriteLine("Задача №28");
        Console.Write("Введите первое целое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе целое число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Введите третье целое число: ");
        int num3 = int.Parse(Console.ReadLine());

        int min = num1;

        if (num2 < min)
            min = num2;

        if (num3 < min)
            min = num3;

        Console.WriteLine($"Наименьшее число: {min}");
    }

    static void zadacha_29()
    {
        Console.WriteLine("Задача №29");
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            int grade = rand.Next(2, 6);
            switch (grade)
            {
                case 2:
                    Console.WriteLine("Неуд");
                    break;
                case 3:
                    Console.WriteLine("Удовл");
                    break;
                case 4:
                    Console.WriteLine("Хорошо");
                    break;
                case 5:
                    Console.WriteLine("Отлично");
                    break;
                default:
                    Console.WriteLine("Некорректная оценка");
                    break;
            }
        }
    }

    static void zadacha_30()
    {
        Console.WriteLine("Задача №30");
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = f7(M, N);

        Console.WriteLine($"Сумма нечетных чисел от {M} до {N}: {sum}");
    }

    static int f7(int M, int N)
    {
        int sum = 0;
        for (int i = M; i <= N; i++)
        {
            if (i % 2 != 0)
                sum += i;
        }
        return sum;
    }

    static void zadacha_31()
    {
        Console.WriteLine("Задача №31");
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = f8(N, n);

        Console.WriteLine($"Наименьшее число, большее или равное {N} и делится на {n}: {result}");
    }

    static int f8(int N, int n)
    {
        int x = N;
        while (x % n != 0)
        {
            x++;
        }
        return x;
    }
}
