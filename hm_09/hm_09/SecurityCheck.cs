using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class SecurityCheck
    {
        private const string _prohibitedItem = "лезвие, канцелярский нож, ножницы,\nемкости более 100 мл и т.д.";
        public string answer;
        private const string questionWeapons = "У Вас имеются при себе оружие (да/нет)?: ";
        public void HelloSecurityCheck()
        {
            Console.WriteLine("*****Служба досмотра*****");
            Console.WriteLine(" Здравствуйте! Выложите из карманов все металлические предметы.");
        }
        public void Search()
        {
            Console.WriteLine($" Вы везете запрещенные предметы, такие как: {_prohibitedItem}(да/нет)?");
            answer = Console.ReadLine();

            if (answer.Equals("да"))
            {
                Console.WriteLine("Выложите эти предметы!");
            }

            Console.Write(questionWeapons); // имеется ли оружие
            answer = Console.ReadLine();
            if (answer.Equals("да") || answer.Equals("ДА") || answer.Equals("lf") || answer.Equals("LF"))
            {
                Console.WriteLine("Есть разрешение на ношение оружия?");
                answer = Console.ReadLine();

                if (answer.Equals("да") || answer.Equals("ДА") || answer.Equals("lf") || answer.Equals("LF"))
                {
                    Console.WriteLine("Вам придется сдать оружие!\nВ самолет с оружием нельзя!");
                }
                else
                {
                    Console.WriteLine("!!!ОСТАВАТЬСЯ НА МЕСТЕ!!!\nВЫ ЗАДЕРЖАНЫ ПО ПОДОЗРЕНИЮ " +
                                      "В НЕЗАКОННОМ НОШЕНИИ ОРУЖИЯ!!!");
                }
            }
        }
    }
}
