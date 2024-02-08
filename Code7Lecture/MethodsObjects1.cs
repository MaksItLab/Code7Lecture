//// Класс Авиакомпания
//using System;

//class Airline
//{
//    private static Random gen;

//    static Airline()
//    {
//        gen = new Random();
//    }

//    // Метод Отправить самолёт в рейс
//    public int SendFlight()
//    {
//        // Случайное количество пассажиров
//        int passengers = gen.Next(140, 780);
//        // Выводим на консоль, сколько человек полетело на самолете
//        Console.WriteLine("The plane leaves with {0} passengers on board", passengers);
//        // Возвращаем количество отправленных пассажиров
//        return passengers;
//    }

//    // Метод задержать самолёт
//    public int DelayedFlight()
//    {
//        // Выводим на консоль, что самолёт задержан
//        Console.WriteLine("The plane is delayed");
//        // Возвращаем 0, что значит, что не было отправлено ни одного пассажира
//        return 0;
//    }
//}

//// Объявлен тип делегата AirlineAction
//// Возвращаемое значени типа int, параметров нет
//delegate int AirlineAction();

//class MethodsObjects1
//{
//    static void Main(string[] args)
//    {
//        // Создаём экземпляр Авиакомпании
//        Airline myAirline = new Airline();

//        // Создаём делегат и назначаем ему метод SendFlight объекта myAirline
//        AirlineAction act = myAirline.SendFlight;

//        Random rndGen = new Random();
//        int rnd = 0;
//        do
//        {
//            // Случайное число
//            rnd = rndGen.Next(20);

//            if (rnd == 13)
//            {
//                act = myAirline.DelayedFlight;
//            }
//            // Вызываем делегат, т.е. метод на который он ссылается
//            act();
//        }
//        while (act == myAirline.SendFlight);
//        // Цикл продолжается, пока метод делегата - метод SendFlight

//    }
//}