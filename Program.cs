using System;

namespace ConsoleAppl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Solution solver = new Solution();

            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine(" ЛАБОРАТОРНАЯ РАБОТА 1 ");
                Console.WriteLine("1 - Методы");
                Console.WriteLine("2 - Условия");
                Console.WriteLine("3 - Циклы");
                Console.WriteLine("4 - Массивы");
                Console.WriteLine("0 - Выход");
                Console.Write("Выберите блок заданий: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка ввода! Введите число.");
                    Console.ReadKey();
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Выход из программы");
                        break;

                    case 1:
                        RunTask1(solver);
                        break;

                    case 2:
                        RunTask2(solver);
                        break;

                    case 3:
                        RunTask3(solver);
                        break;

                    case 4:
                        RunTask4(solver);
                        break;

                    default:
                        Console.WriteLine("Неверный выбор");
                        Console.ReadKey();
                        break;
                }

            } while (choice != 0);
        }

        private static void RunTask1(Solution solver)
        {
            Console.Clear();

            // Задача 2: Сумма знаков
            Console.Write("Введите число для задачи 2: ");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                int result2 = solver.sumLastNums(num2);
                Console.WriteLine($"Сумма последних цифр: {result2}");
            }

            // Задача 4: Есть ли позитив
            Console.Write("Введите число для задачи 4: ");
            if (int.TryParse(Console.ReadLine(), out int num4))
            {
                bool result4 = solver.isPositive(num4);
                Console.WriteLine($"Положительное число: {result4}");
            }

            // Задача 6: Большая буква
            Console.Write("Введите символ для задачи 6: ");
            if (char.TryParse(Console.ReadLine(), out char char6))
            {
                bool result6 = solver.isUpperCase(char6);
                Console.WriteLine($"Заглавная буква: {result6}");
            }

            // Задача 8: Делитель
            Console.Write("Введите первое число для задачи 8: ");
            if (int.TryParse(Console.ReadLine(), out int a8))
            {
                Console.Write("Введите второе число для задачи 8: ");
                if (int.TryParse(Console.ReadLine(), out int b8))
                {
                    bool result8 = solver.isDivisor(a8, b8);
                    Console.WriteLine($"Одно делит другое: {result8}");
                }
            }

            // Задача 10: Многократный вызов
            Console.Write("Введите первое число для задачи 10: ");
            if (int.TryParse(Console.ReadLine(), out int numA))
            {
                Console.Write("Введите второе число для задачи 10: ");
                if (int.TryParse(Console.ReadLine(), out int numB))
                {
                    int result10 = solver.lastNumSum(numA, numB);
                    Console.WriteLine($"Сумма последних цифр: {result10}");
                }
            }

            Console.ReadKey();
        }

        private static void RunTask2(Solution solver)
        {
            Console.Clear();
 
            // Задача 2: Безопасное деление
            Console.Write("Введите числитель(x) для задачи 2: ");
            if (int.TryParse(Console.ReadLine(), out int x2))
            {
                Console.Write("Введите знаменатель(y) для задачи 2: ");
                if (int.TryParse(Console.ReadLine(), out int y2))
                {
                    double result2 = solver.safeDiv(x2, y2);
                    Console.WriteLine($"Результат деления: {result2}");
                }
            }

            // Задача 4: Строка сравнения
            Console.Write("Введите первое число для задачи 4: ");
            if (int.TryParse(Console.ReadLine(), out int x4))
            {
                Console.Write("Введите второе число для задачи 4: ");
                if (int.TryParse(Console.ReadLine(), out int y4))
                {
                    string result4 = solver.makeDecision(x4, y4);
                    Console.WriteLine($"Результат сравнения: {result4}");
                }
            }

            // Задача 6: Тройная сумма
            Console.Write("Введите первое число для задачи 6: ");
            if (int.TryParse(Console.ReadLine(), out int x6))
            {
                Console.Write("Введите второе число для задачи 6: ");
                if (int.TryParse(Console.ReadLine(), out int y6))
                {
                    Console.Write("Введите третье число для задачи 6: ");
                    if (int.TryParse(Console.ReadLine(), out int z6))
                    {
                        bool result6 = solver.sum3(x6, y6, z6);
                        Console.WriteLine($"Два числа дают в сумме: {result6}");
                    }
                }
            }

            // Задача 8: Возраст
            Console.Write("Введите возраст для задачи 8: ");
            if (int.TryParse(Console.ReadLine(), out int age8))
            {
                string result8 = solver.age(age8);
                Console.WriteLine($"Результат: {result8}");
            }

            // Задача 10: Вывод дней недели
            Console.Write("Введите день недели для задачи 10: ");
            string day10 = Console.ReadLine();
            Console.Write("Результат: ");
            solver.printDays(day10);

            Console.ReadKey();
        }

        private static void RunTask3(Solution solver)
        {
            Console.Clear();

            // Задача 2: Числа наоборот
            Console.Write("Введите число для задачи 2: ");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                string result2 = solver.reverseListNums(num2);
                Console.WriteLine($"Числа в обратном порядке: {result2}");
            }

            // Задача 4: Степень числа
            Console.Write("Введите основание для задачи 4: ");
            if (int.TryParse(Console.ReadLine(), out int base4))
            {
                Console.Write("Введите показатель степени для задачи 4: ");
                if (int.TryParse(Console.ReadLine(), out int exp4))
                {
                    int result4 = solver.pow(base4, exp4);
                    Console.WriteLine($"Результат: {result4}");
                }
            }

            // Задача 6: Одинаковость
            Console.Write("Введите число для задачи 6: ");
            if (int.TryParse(Console.ReadLine(), out int num6))
            {
                bool result6 = solver.equalNum(num6);
                Console.WriteLine($"Все цифры одинаковы: {result6}");
            }

            // Задача 8: Левый треугольник
            Console.Write("Введите размер треугольника для задачи 8: ");
            if (int.TryParse(Console.ReadLine(), out int size8))
            {
                Console.WriteLine("Левый треугольник:");
                solver.leftTriangle(size8);
            }

            // Задача 10: Угадайка
            solver.guessGame();

            Console.ReadKey();
        }

        private static void RunTask4(Solution solver)
        {
            Console.Clear();

            // Задача 2: Поиск последнего значения
            Console.Write("Введите размер массива для задачи 2: ");
            if (int.TryParse(Console.ReadLine(), out int size2))
            {
                int[] arr2 = ReadIntArray("Введите элементы массива:", size2);
                Console.Write("Введите число для поиска: ");
                if (int.TryParse(Console.ReadLine(), out int search2))
                {
                    int result2 = solver.findLast(arr2, search2);
                    Console.WriteLine($"Индекс последнего вхождения: {result2}");
                }
            }

            // Задача 4: Добавление в массив
            Console.Write("Введите размер массива для задачи 4: ");
            if (int.TryParse(Console.ReadLine(), out int size4))
            {
                int[] arr4 = ReadIntArray("Введите элементы массива:", size4);
                Console.Write("Введите число для вставки: ");
                if (int.TryParse(Console.ReadLine(), out int insert4))
                {
                    Console.Write("Введите позицию для вставки: ");
                    if (int.TryParse(Console.ReadLine(), out int pos4))
                    {
                        int[] result4 = solver.add(arr4, insert4, pos4);
                        Console.Write("Результат: ");
                        PrintArray(result4);
                    }
                }
            }

            // Задача 6: Реверс
            Console.Write("Введите размер массива для задачи 6: ");
            if (int.TryParse(Console.ReadLine(), out int size6))
            {
                int[] arr6 = ReadIntArray("Введите элементы массива:", size6);
                solver.reverse(arr6);
                Console.Write("Массив после реверса: ");
                PrintArray(arr6);
            }

            // Задача 8: Объединение
            Console.Write("Введите размер первого массива для задачи 8: ");
            if (int.TryParse(Console.ReadLine(), out int size8a))
            {
                int[] arr8a = ReadIntArray("Введите элементы первого массива:", size8a);
                Console.Write("Введите размер второго массива для задачи 8: ");
                if (int.TryParse(Console.ReadLine(), out int size8b))
                {
                    int[] arr8b = ReadIntArray("Введите элементы второго массива:", size8b);
                    int[] result8 = solver.concat(arr8a, arr8b);
                    Console.Write("Объединенный массив: ");
                    PrintArray(result8);
                }
            }

            // Задача 10: Удалить негатив
            Console.Write("Введите размер массива для задачи 10: ");
            if (int.TryParse(Console.ReadLine(), out int size10))
            {
                int[] arr10 = ReadIntArray("Введите элементы массива:", size10);
                int[] result10 = solver.deleteNegative(arr10);
                Console.Write("Массив без отрицательных: ");
                PrintArray(result10);
            }

            Console.ReadKey();
        }

        private static int[] ReadIntArray(string prompt, int length)
        {
            int[] array = new int[length];
            Console.WriteLine(prompt);
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }
            }
            return array;
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
