using System;

namespace Shildn_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arrayObject = new object[4];
            arrayObject[0] = 12.3;
            arrayObject[1] = "Aefswef";
            arrayObject[2] = 35;
            arrayObject[3] = (double)arrayObject[0] + (int)arrayObject[2];

            for (int i = 0; i < arrayObject.Length; i++)
            {
                Console.WriteLine(arrayObject[i]);
            }
        }
    }
}
