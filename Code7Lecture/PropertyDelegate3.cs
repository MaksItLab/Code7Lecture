//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Code7Lecture
//{
//    delegate int AirlineAction();

//    // Всё тот же класс Авиакомпании
//    class Airline
//    {
//        private static Random gen;

//        // Свойство Flight типа делегата AirlineAction (!)
//        // Задавать значение которому можно только изнутри этого класса
//        public AirlineAction Flight { get; private set; }

//        static Airline()
//        {
//            gen = new Random();
//        }

//        // Конструктор по умолчанию
//        public Airline()
//        {
//            // Назначает свойству Flight (т.е. делегату)
//            // метод SendFlight, который теперь приватный (!)
//            Flight = SendFlight;
//        }

//        // Метод SendFlight стал приватным, т.е. его больше нельзя вызвать напрямую извне
//        private int SendFlight()
//        {
//            int passengers = gen.Next(140, 780);
//            Console.WriteLine("The plane leaves with {0} passengers on board", passengers);
//            // Генерируем новое случайное число
//            int badLuck = gen.Next(20);
//            // Если удача подвела
//            if (badLuck == 13)
//            {
//                // Назначаем свойству Flight (которое имеет тип делегата)
//                // Метод DelayedFlight, который также стал приватным
//                Flight = DelayedFlight;
//            }
//            return passengers;
//        }

//        // Приватный метод DelayedFlight
//        private int DelayedFlight()
//        {
//            Console.WriteLine("The plane is delayed");
//            // Возвращает делегату Flight метод SendFlight
//            Flight = SendFlight;
//            return 0;

//        }
//    }

//    internal class PropertyDelegate3
//    {
//        static void Main(string[] args)
//        {
//            // Здесь всё работает так же, как и раньше:
//            // Создаётся авиакомпания
//            Airline myAirline = new Airline();

//            // Переменная для количества пассажиров, которое вернёт Flight
//            int passgrs;
//            do
//            {
//                // Вызываем свойство (!) Flight нашей авиакомпании
//                // Поскольку свойство имеет тип делегата, то его можно вызвать
//                passgrs = myAirline.Flight();
//                // И иногда это будет вызов метода SendFlight, а иногда вызов метода DelayedFlight
//                // В зависимости от внутренней логики класса Airline
//                // Там в принципе может вызываться что-угодно!
//            }
//            while (passgrs != 0);
//            // Заканчиваем цикл, когда метод в свойстве Flight вернёт 0
//        }
//    }
//}
