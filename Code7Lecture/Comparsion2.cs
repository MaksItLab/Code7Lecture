//using System;


//namespace Code7Lecture
//{
//    internal class Comparsion2
//    {
//        static void Main(string[] args)
//        {
//            // Авиакомпания №1
//            Airline myAirline = new Airline();
//            // Авиакомпания №2
//            Airline air2 = new Airline();

//            // Первому делегату назначен метод SendFlight объекта myAirline
//            AirlineAction act1 = myAirline.SendFlight;

//            // Второму делегату назначен метод DelayedFlight объект myAirline
//            AirlineAction act2 = myAirline.DelayedFlight;

//            // Третьему делегату назначен метод DelayedFlight объект air2
//            AirlineAction act3 = air2.DelayedFlight;

//            // Сравнивается первый делегат с методом Send Flight объекта myAirline
//            if (act1 == myAirline.SendFlight)
//            {
//                // Именно этот метод был ему назначен, поэтому условие выполнится
//                Console.WriteLine("Delegate act1 refers to the method SendFlight of the object myAirline");
//            }
//            // Сравнивается первый делегат со вторым делегатом
//            if (act1 != act2)
//            {
//                // Они ссылаются на разные методы, а значит не равны, поэтому условие выполнится
//                Console.WriteLine("Delegates act1 and act2 refers to different methods");
//            }
//            // Сравнивается второй делегат с третьим
//            // Хотя они оба указывают на метод DelayedFlight
//            // Но эти методы принадлежат разным объектам, поэтому считаются разными
//            if (act2 != act3)
//            {
//                // Методы не совпадают, поэтому условие выполнится
//                Console.WriteLine("The same methods from different object are not equal.");
//            }
//        }
//    }
//}
