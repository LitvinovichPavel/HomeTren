using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class CheckIn
    {
        private const byte massLimit = 23;          // лимит массы багажа в кг.
        private const byte priceExscessWeidht = 10; // доплата за перевес каждого кг. багажа
        private string surname;                     // фамилия пассажира
        private string name;                        // имя пассажира
        private string patronymic;                  // отчество пассажира
        public void Greeting() // приветствие
        {
            byte realTime;
            realTime = Convert.ToByte(DateTime.Now.Hour); // приветствуем исходя из реального времени
            string timeOfDay;

            if (realTime >= 6 && realTime < 12 )
            {
                timeOfDay = "Доброе утро! ";
            }
            else if (realTime >= 12 && realTime < 18)
            {
                timeOfDay = "Добрый день! ";
            }
            else if (realTime >= 18 && realTime < 21)
            {
                timeOfDay = "Добрый вечер! ";
            }
            else
            {
                timeOfDay = "Доброй ночи! ";
            }

            Console.WriteLine($"{timeOfDay}Вас приветствует аэропорт имени Маши и Медведя!");
        }
        public void FullName() //здесь вводим ФИО
        {
            Console.Write("Назовите Вашу фамилию: ");            
            surname = Console.ReadLine();

            Console.Write("Назовите Ваше имя: ");            
            name = Console.ReadLine();

            Console.Write("Назовите Ваше отчество: ");
            patronymic = Console.ReadLine();
        }
        public void Passport() //паспортные данные
        {
            Console.Write("Укажите серию и номер Вашего паспорта: ");
            
            string passportSeries;
            passportSeries = Console.ReadLine();
        }
        public void Luggage() // проверяем багаж
        {
            Console.Write("У Вас есть багаж? (да/нет): ");
            string questionLuggage;
            questionLuggage = Console.ReadLine();
            if (questionLuggage == "да" || questionLuggage == "lf")
            {
                Console.WriteLine("Положите свой багаж на ленту.");

                byte massLuggage;
                massLuggage = (byte)new Random().Next(1, 50); // делаем вес багажа рандомным
                Console.WriteLine($"Масса Вашего багажа составляет {massLuggage} кг");

                if (massLuggage > massLimit) // т.к. есть лимиты по бесплатному провозу багажа,
                                             // расчитываем доплату за перевес
                {
                    byte massBigger;
                    massBigger = (byte)(massLuggage - massLimit);
                    uint money;
                    money = (uint)(priceExscessWeidht * massBigger);
                    Console.WriteLine($"Превышение составляет {massBigger}кг.\nНеобходимо доплатать {money}$ " +
                                      $"({priceExscessWeidht}$ за каждый кг.)");
                }
            }
            else
            {
                Console.WriteLine("Ясно, багаж отсутствует!");
            }
        }
    }
}
