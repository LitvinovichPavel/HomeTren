using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class CheckIn
    {
        private const byte _massLimitLuggage = 23;               // лимит массы багажа в кг.
        private const byte _massLimitHandLuggage = 8;            // лимит массы ручной клади в кг.
        private const byte _priceExscessWeidhtLuggage = 10;      // доплата за перевес каждого кг. багажа
        private const byte _priceExscessWeidhtHand = 12;         // доплата за перевес кучной клади
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

            if (questionLuggage == "да" || questionLuggage == "ДА" || // на случай если не будет переключена
                questionLuggage == "lf" || questionLuggage == "LF")   // клавиатура на русский язык
            {
                Console.WriteLine("Положите свой багаж на ленту.");

                byte massLuggage;
                massLuggage = (byte)new Random().Next(1, 50); // делаем вес багажа рандомным
                Console.WriteLine($"Масса Вашего багажа составляет {massLuggage} кг");
                                                              // создаем ситуацию, когда необходимо доплачивать за перевес багажа
                if (massLuggage > _massLimitLuggage)    // т.к. есть лимиты по бесплатному провозу багажа,
                                                       // расчитываем доплату за перевес
                {
                    byte massBigger;
                    massBigger = (byte)(massLuggage - _massLimitLuggage);
                    uint money;
                    money = (uint)(_priceExscessWeidhtLuggage * massBigger);
                    Console.WriteLine($"Превышение составляет {massBigger}кг.\nНеобходимо доплатать {money}$ " +
                                      $"({_priceExscessWeidhtLuggage}$ за каждый кг.)");
                }
                else
                {
                    Console.WriteLine("Превышения массы багажа нет! Доплачивать не придется!");
                }
            }
            else
            {
                Console.WriteLine("Ясно, багаж отсутствует!");
            }

            Console.WriteLine("У Вас есть ручная кладь?");
            string questionHandLuggage;
            questionHandLuggage = Console.ReadLine();

            if (questionLuggage == "да" || questionLuggage == "ДА" || // на случай если не будет переключена
                questionLuggage == "lf" || questionLuggage == "LF")   // клавиатура на русский язык
            {
                Console.WriteLine("Положите свою ручную кладь на весы.");

                byte massHandLuggage;
                massHandLuggage = (byte)new Random().Next(1, 20);
                Console.WriteLine($"Масса ручной клади составляет {massHandLuggage}");
            }

            Console.WriteLine("Спасибо! Проходите далее на досмотр");
        }
    }
}
