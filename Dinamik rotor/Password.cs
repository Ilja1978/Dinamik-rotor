﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamik_rotor
{
    class Password
    {
        private string  parol = "Ilja";
        private string code;
         public void Cod(string cod)
         {
            code = cod;
         }
        
            
   
        public bool Check ()
        {
            //Console.WriteLine("\tВАС ПРИВЕТСТВУЕТ ПРОГРАММА РАСЧЕТОВ РОТОРОВ\n");
            //Console.Write("Введите код доступа\t");
            //string Code = Console.ReadLine();
            if (code != parol)
            {
                //Console.WriteLine("У вас нет прав доступа");
                return false;
            }
            else
            {
                //Console.Clear();
                return true;
            }


        }



    }
}
