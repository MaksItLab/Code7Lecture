using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code7Lecture
{
    // Определение типа делегата WorkAction
    // С возвращаемым значением int и без параметров
    delegate int WorkAction();

    // Класс Горожанин
    class Citizen
    {
        // Приватное поле типа делегата WorkAction
        private WorkAction workAction;
        // Обычное свойство Имя горожанина
        public string Name { get; set; }
        // Статический объект рандома
        public static Random Random { get; set; }

        // Статический конструктор для инициализации генератора случайных чисел
        static Citizen()
        {
            Random = new Random();
        }

        // Конструктор с параметром, для создания горожанина с именем
        public Citizen(string name)
        {
            Name = name;
        }

        // Метод SetWork, который принимает в качестве параметра аргумент типа делегата WorkAction
        public void SetWork(WorkAction newWork)
        {
            // Если этот делегат содержит ссылку на метод(ы)
            if (newWork != null)
            {
                // Записываем его в закрытое поле workAction
                workAction = newWork;
            }
        }

        // Метод Work
        public int Work()
        {
            // Создаём переменную, в которой будет сохраняться сумма заработанных денег
            int earnedMoney = 0;
            // Если рабочего действия нет
            if (workAction == null)
            {
                // Выводим сообщение, что у горожанина нет работы
                Console.WriteLine("The Citizen {0} has no work!", Name);
                return earnedMoney;
            }
            // Случайное число, которое определяет, сколько итераций будет у цикла работы
            int randomWork = Random.Next(10);
            Console.WriteLine("Beginning of work!");
            // По циклу, столько раз, сколько выпало рандомом
            for (int i = 0; i < randomWork; ++i)
            {
                // Вызывается делегат workAction
                // И значение, которое он возвращает, прибавляется к значению переменной earnedMoney
                earnedMoney += workAction();
            }
            Console.WriteLine("End of work!");
            Console.WriteLine("Today citizen {0} earned {1} money!", Name, earnedMoney);
            // Возвращается количество заработанных денег
            return earnedMoney;
        }
    }

    internal class DelegateInArgMethods4
    {
        // Статический метод, описывающий действие по работе писателя
        static int Write()
        {
            Console.WriteLine("Writes something...");
            // Возвращает случайное число - количество денег, полученное за эту работу
            return Citizen.Random.Next(120, 190);
        }

        // Статический метод, описывающий действие по работе программиста
        static int Programming()
        {
            Console.WriteLine("Programs back-end...");
            // Также возвращает случайное число
            return Citizen.Random.Next(160, 410);
        }

        static void Main(string[] args)
        {
            // Создаём первого горожанина
            Citizen human1 = new Citizen("Bob");
            // Он пытается работать
            human1.Work();

            // Вызывается метод SetWork, который принимает делегат
            // В качестве параметра мы передаём метод Write,
            // Который по сигнатуре схож с описанием делегата
            // Этот метод Write записывается в закрытое поле класса,
            // Чтобы потом использоваться в методе Work
            human1.SetWork(Write);
            // Отправляем Боба на работу
            human1.Work();

            // Создаём Ричарда
            Citizen human2 = new Citizen("Richard");
            // Пытаемся поработать
            human2.Work();
            // Назначаем действия по работе программиста
            human2.SetWork(Programming);
            // Отправялем на работу 2 раза
            human2.Work();
            human2.Work();

            // Назначаем Бобу тоже работу программиста
            human1.SetWork(Programming);
            // И отправляем его на работу
            human1.Work();
        }

    }
    

}
