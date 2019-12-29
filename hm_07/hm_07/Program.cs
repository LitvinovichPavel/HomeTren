﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineFirst;
            lineFirst = "Но мы все-таки приходим в кино. До начала сеанса еще минут пятнадцать." +
                " Мы стоим посреди фойе и слушаем певицу, но ее плохо слышно: возле нас много народу," +
                " и все потихоньку разговаривают. Я давно заметил, что те, кто стоит в фойе, плохо" +
                " слушают оркестр. Слушают и аплодируют только передние, а сзади едят мороженое и" +
                " конфеты и тихо переговариваются. Решив, что певицу все равно не услышишь как следует," +
                " я принимаюсь разглядывать картины. Я никогда раньше не обращал внимания на них, но" +
                " теперь я очень заинтересован. Я думаю о художниках, которые их нарисовали. Видимо, не" +
                " зря повесили эти картины в фойе. Очень хорошо, что они висят тут.\n";

            //Task1();
            Task2(lineFirst);
        }

        static void Task1()
        {
            Console.WriteLine("Введи стих в одну строку разделяя строки точкой с запятой");
            string poem;
            poem = Console.ReadLine();


            //char[] array1 = poem.ToCharArray();
            string[] array1 = new string[poem.Length]; //массив строк
            char[] arrayCopy = poem.ToCharArray(); //массив символов
            string strArray1 = poem; //строка

            for (int i =0; i < poem.Length; i++)
            {
                
            }
        }
        static void Task2(string lineFirst)
        {
            string lineSecond;
            lineSecond = lineFirst;
            Console.WriteLine($"Исходный текст:\n{lineSecond}");

            string[] str = lineSecond.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';', '-' },
                                                        StringSplitOptions.RemoveEmptyEntries);

            int maxlen = 0;
            int indexMax = 0;
            int minlen = int.MaxValue;
            int indexMin = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    indexMax = i;
                }

                if (str[i].Length < minlen)
                {
                    minlen = str[i].Length;
                    indexMin = i;
                }
            }

            string longWord = str[indexMax]; // самое длинное слово
            string shortWord = str[indexMin]; //самое короткое слово
            lineSecond = lineSecond.Replace(longWord, string.Empty); // удаляем самое длинное слово
            lineSecond = lineSecond.Replace(longWord, shortWord); //меняем слова местами
            lineSecond = lineSecond.Replace(shortWord, longWord);

            int countGeneral = 0;
            int countTotal = 0;
            int countSign = 0;

            for (int i = 0; i < lineSecond.Length; i++)
            {
                countTotal++;

                if (lineSecond[i] == ' ' || lineSecond[i] == '.' || lineSecond[i] == ',' || lineSecond[i] == '!' ||
                    lineSecond[i] == '(' || lineSecond[i] == ')' || lineSecond[i] == '"' || lineSecond[i] == '?' ||
                    lineSecond[i] == ':' || lineSecond[i] == '-')
                {
                    countGeneral++;
                }

                if (lineSecond[i] == '-' || lineSecond[i] == '.' || lineSecond[i] == ',' || lineSecond[i] == '!' ||
                    lineSecond[i] == '(' || lineSecond[i] == ')' || lineSecond[i] == '"' || lineSecond[i] == '?' ||
                    lineSecond[i] == ':')
                {
                    countSign++;
                }
            }

            Console.WriteLine($"Количество букв: {countTotal - countGeneral}");
            Console.WriteLine($"Количество пунктуационных знаков: {countSign}");

            string[] arrayStr = lineSecond.Split(' ');
            foreach (var item in arrayStr)
            {
                Console.Write(" " + item);
            }
            

        }
    }
}
