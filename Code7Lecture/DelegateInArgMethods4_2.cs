using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code7Lecture
{
    // Объявляем тип делегата, возвращающий булево значение
    // И принимающий 2 параметра типа int
    delegate bool Comparison(int a, int b);

    static class ArrayUtils
    {
        // Вместо метода для поиска минимального элемента,
        // Метода для поиска максимального элемента, и др.
        // Мы добавили один единственный универсальный метод
        // Условие работы которого определяется вторым аргументом
        // Типа делегата Comparison
        public static int ShowByExpr(int[] arr, Comparison compare)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty");
            }
            int element = arr[0];
            for (int i = 1; i < arr.Length; ++i)
            {
                // Там, где в алгоритме раньше находилась ключевая проверка
                // Вызывается делегат. И от результата его выполнения зависит вся логика этого метода
                if (compare(arr[i], element))
                {
                    element = arr[i];
                }
            }
            // Возвращаем полученный результат
            return element;
        }
    }

    internal class DelegateInArgMethods4_2
    {
        // Вспомогательный статический метод
        // Для поиска минимального элемента методом ShowByExpr
        static bool Min(int a, int b)
        {
            return a < b;
        }

        // Вспомогательный статический метод
        // Для поиска максимального элемента методом ShowByExpr
        static bool Max(int a, int b)
        {
            return a > b;
        }

        // Вспомогательный статический метод
        // Для поиска минимального положительного элемента методом ShowByExpr
        static bool MinPositive(int a, int b)
        {
            return a > 0 ? Min(a, b) : false;
        }

        // И тут можно написать ещё сколько угодно разных методов,
        // Которые будут как-либо менять поведение метода ShowByExpr

        static void Main(string[] args)
        {
            // Создаётся массив
            int[] array1 = { 10, 17, 23, 6, -5, 14, 0, -11, -2 };

            // Вызывается метод ShowByExpr, в качестве параметра-делегата
            // Передаётся метод Min - благодаря чему метод возвращает минимальное число
            int result = ArrayUtils.ShowByExpr(array1, Min);
            Console.WriteLine("Min value in the array is {0}", result);

            // Вызывается метод ShowByExpr, в качестве параметра-делегата
            // Передаётся метод Max - благодаря чему метод возвращает максимальное число
            result = ArrayUtils.ShowByExpr(array1, Max);
            Console.WriteLine("Max value in the array is {0}", result);

            // Вызывается метод ShowByExpr, в качестве параметра-делегата
            // Передаётся метод MinPositive - благодаря чему метод возвращает минимальное положительное число
            result = ArrayUtils.ShowByExpr(array1, MinPositive);
            Console.WriteLine("Min positive value in the array is {0}", result);
        }

    }
}
