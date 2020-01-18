using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class Passanger
    {
        private string _surname;                                 // фамилия пассажира
        private string _name;                                    // имя пассажира
        private string _patronymic;                              // отчество пассажира
        public void FullName() //здесь вводим ФИО
        {
            Console.Write("Назовите Вашу фамилию: ");
            _surname = Console.ReadLine();

            Console.Write("Назовите Ваше имя: ");
            _name = Console.ReadLine();

            Console.Write("Назовите Ваше отчество: ");
            _patronymic = Console.ReadLine();
        }
    }
}
