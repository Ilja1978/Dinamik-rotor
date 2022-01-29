using System;

namespace Dinamik_rotor
{
    
    class Program
    {
        static void  MenuGlav()
        {
            Console.WriteLine("\tРАСЧЕТ ДИНАМИЧЕСКОЙ НЕУРАВНОВЕШЕННОСТИ РОТОРОВ\n");
            Console.WriteLine("1. Расчет корректирующих масс");
            Console.WriteLine("2. Расчет выборок металла");
            Console.WriteLine("3. Рассчет амплитуд");
            Console.WriteLine("4. Расчет компенсирующих масс");
            Console.WriteLine("5. Прочие расчеты");
            Console.WriteLine("6. Перевод Амплитуд");
            Console.WriteLine("7. База Данных");
            Console.WriteLine("8. ВЫХОД\n");
            int num;
            do
            {
                Console.Write("Выбирете нужную функцию\t\t");
                string F = Console.ReadLine();
                num = Convert.ToInt32(F);
                switch (num)
                {
                    case 1:
                        // Вызываем  нужную функцию(метод)
                        Console.Clear();
                        Menu1();

                        break;
                    case 2:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        Menu2();
                        break;
                    case 3:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        Menu3();
                        break;
                    case 4:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        Menu4();
                        break;
                    case 5:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        Menu5();
                        break;
                    case 6:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        Menu6();
                        break;
                    case 7:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        Menu7();
                        break;
                    case 8:
                        Console.Clear();
                        break;
                        //if (num > 7)
                        // Console.Write("\b");
                }
            }
            while (num>8);

        }
        static void Menu1()
        {
            Console.WriteLine("\t\tРАСЧЕТ КОРЕКТИРУЮЩИХ МАСС РОТОРА\n");
            Console.WriteLine("1. Расчет корректирующих масс по 1 плоскости");
            Console.WriteLine("2. Расчет корректирующих масс по 2 плоскостям");
            Console.WriteLine("3. Расчет корректирующих масс сведением");
            Console.WriteLine("4. Расчет роторов в РБС");
            Console.WriteLine("5. Выход в главное меню\n");
            int num;
            do
            {
                Console.Write("Выбирете нужную функцию\t\t");
                string F = Console.ReadLine();
                num = Convert.ToInt32(F);
                switch (num)
                {
                    case 1:
                        // Вызываем  нужный класс
                        Console.Clear();
                        

                        break;
                    case 2:
                        // Вызываем   нужный класс
                        Console.Clear();
                       
                        break;
                    case 3:
                        // Вызываем  нужный класс
                        Console.Clear();
                        
                        break;
                    case 4:
                        // Вызываем   нужный класс
                        Console.Clear();
                        
                        break;
                    case 5:
                        // Возвращаемся в Главное меню
                        Console.Clear();
                        MenuGlav();
                        break;
                   
                }
            }
            while (num > 5);
        }
        static void Menu2()
        {
            Console.WriteLine("\t\tРАСЧЕТ ВЫБОРОК МЕТАЛЛА\n");
            Console.WriteLine("1. Расчет выборки металла методом ''Ромашка'' ");
            Console.WriteLine("2. Расчет выборки металла сверлением");
            Console.WriteLine("3. Расчет линейной выборки металла");
            Console.WriteLine("4. Расчет линейной выборки металла с заданным углом");
            Console.WriteLine("5. Расчет нелинейной выборки металла");
            Console.WriteLine("6. Выход в главное меню");
            int num;
            do
            {
                Console.Write("\nВыбирете нужную функцию\t\t");
                string F = Console.ReadLine();
                num = Convert.ToInt32(F);
                switch (num)
                {
                    case 1:
                        // Вызываем  нужный класс
                        Console.Clear();


                        break;
                    case 2:
                        // Вызываем   нужный класс
                        Console.Clear();

                        break;
                    case 3:
                        // Вызываем  нужный класс
                        Console.Clear();

                        break;
                    case 4:
                        // Вызываем   нужный класс
                        Console.Clear();

                        break;
                    case 5:
                        // Вызываем   нужный класс
                        Console.Clear();

                        break;
                    case 6:
                        // Возвращаемся в Главное меню
                        Console.Clear();
                        MenuGlav();
                        break;

                }
            }
            while (num > 6);
        }
        static void Menu3()
        {
            Console.WriteLine("\t\tРАСЧЕТ АММПЛИТУД\n");
            Console.WriteLine("1. Сведение амплитуд к одной равнодействующей");
            Console.WriteLine("2. Рапределение амплитуд на две составляющие");
            Console.WriteLine("3. Вычитание амплитуд");
            Console.WriteLine("4. Выход в главное меню");
            int num;
            do
            {
                Console.Write("\nВыбирете нужную функцию\t\t");
                string F = Console.ReadLine();
                num = Convert.ToInt32(F);
                switch (num)
                {
                    case 1:
                        // Вызываем  нужный класс
                        Console.Clear();


                        break;
                    case 2:
                        // Вызываем   нужный класс
                        Console.Clear();

                        break;
                    case 3:
                        // Вызываем  нужный класс
                        Console.Clear();

                        break;
                   
                    case 4:
                        // Возвращаемся в Главное меню
                        Console.Clear();
                        MenuGlav();
                        break;

                }
            }
            while (num > 4);
        }
        static void Menu4()
        {
            Console.WriteLine("\t\tРАССЧЕТ КОМПЕНСИРУЮЩИХ МАСС\n");
            Console.WriteLine("1. Расчет выпуклой полушпонки");
            Console.WriteLine("2. Расчет вогнутой полушпонки");
            Console.WriteLine("3. Расчет лепестка");
            Console.WriteLine("4. Расчет штифта");
            Console.WriteLine("5. Выход в главное меню");
            int num;
            do
            {
                Console.Write("\nВыбирете нужную функцию\t\t");
                string F = Console.ReadLine();
                num = Convert.ToInt32(F);
                switch (num)
                {
                    case 1:
                        // Вызываем  нужный класс
                        Console.Clear();


                        break;
                    case 2:
                        // Вызываем   нужный класс
                        Console.Clear();

                        break;
                    case 3:
                        // Вызываем  нужный класс
                        Console.Clear();

                        break;
                    case 4:
                        // Вызываем   нужный класс
                        Console.Clear();

                        break;
                    case 5:
                        // Возвращаемся в Главное меню
                        Console.Clear();
                        MenuGlav();
                        break;

                }
            }
            while (num > 5);
        }
            
        static void Menu5()
        {
            Console.WriteLine("\t\t\tПРОЧИЕ РАСЧЕТЫ\n");
            Console.WriteLine("1. Выход в главное меню");
            int num;
            do
            {
                Console.Write("\nВыбирете нужную функцию\t\t");
                string F = Console.ReadLine();
                num = Convert.ToInt32(F);
                switch (num)
                {

                    case 1:
                        // Возвращаемся в Главное меню
                        Console.Clear();
                        MenuGlav();
                        break;

                }
            }
            while (num > 1);
        }
        static void Menu6()
        {
            Console.WriteLine("\t\tПЕРЕВОД АМПЛИТУД\n");
            Console.WriteLine("1. Перевод виброскорости в виброперемещение");
            Console.WriteLine("2. Перевод виброперемещения в виброскорость");
            Console.WriteLine("3. Перевод виброскорости в виброускорение");
            Console.WriteLine("4. Перевод виброускорения в виброскорость");
            Console.WriteLine("5. Выход в главное меню");
            int num;
            do
            {
                Console.Write("\nВыбирете нужную функцию\t\t");
                string F = Console.ReadLine();
                num = Convert.ToInt32(F);
                switch (num)
                {
                    case 1:
                        // Вызываем  нужный класс
                        Console.Clear();


                        break;
                    case 2:
                        // Вызываем   нужный класс
                        Console.Clear();

                        break;
                    case 3:
                        // Вызываем  нужный класс
                        Console.Clear();

                        break;
                    case 4:
                        // Вызываем   нужный класс
                        Console.Clear();

                        break;
                    case 5:
                        // Возвращаемся в Главное меню
                        Console.Clear();
                        MenuGlav();
                        break;

                }
            }
            while (num > 5);
        }
        static void Menu7()
        {
            Console.WriteLine("\t\t\tБАЗА ДАННЫХ\n");
            Console.WriteLine("1. Выход в главное меню");
            int num;
            do
            {
                Console.Write("\nВыбирете нужную функцию\t\t");
                string F = Console.ReadLine();
                num = Convert.ToInt32(F);
                switch (num)
                {
                    
                    case 1:
                        // Возвращаемся в Главное меню
                        Console.Clear();
                        MenuGlav();
                        break;

                }
            }
            while (num > 1);
        }
        static void Main(string[] arg)
        {
            Parol rotor = new Parol();
            if (rotor.Proverka())
            {
                MenuGlav();
            }
            

        }
        }
}
