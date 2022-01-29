using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamik_rotor
{
    class Parol
    {
        private string parol = "Ilja";
        public bool Proverka ()
        {
            Console.WriteLine("\tВАС ПРИВЕТСТВУЕТ ПРОГРАММА РАСЧЕТОВ РОТОРОВ\n");
            Console.Write("Введите код доступа\t");
            string kod = Console.ReadLine();
            if (kod != parol)
            {
                Console.WriteLine("У вас нет прав доступа");
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }


        }



    }
}
