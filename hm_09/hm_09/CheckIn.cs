using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class CheckIn
    {
        private string surname;
        private string name;
        private string patronymic;
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
        public void Pasport()
        {
            Console.WriteLine("Укажите серию и номе Вашего паспорта: ");
            
            string pasportSeries;
            byte indexSeries = 0;
            while (indexSeries < 2)
            {
                pasportSeries = Console.ReadLine();
                indexSeries++;
            }
        }
        public void GoToRegistration()
        {
            Console.WriteLine($"{name} {patronymic}, проходите далее на регистрацию.");
        }
    }
}
