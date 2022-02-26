using System;


namespace Dinamik_rotor
{

    class Program
    {
        static bool MainMenu() // Главное меню нашей программы
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
                // if (num == 8) { return false; }
                switch (num)
                {
                    case 1:
                        // Вызываем  нужную функцию(метод)
                        Console.Clear();
                        CorrectiveMassnu1(); // Входим в меню 1 "Расчет корректирующих масс"

                        break;
                    case 2:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        EatingMetal();  // Входим в меню 2 "Расчет выборок металла"
                        break;
                    case 3:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        Amplitude(); // Входим в меню 3 "Расчет амплитуд"
                        break;
                    case 4:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        Compensation();  // Входим в меню 4 "Расчет компенсирующих масс"
                        break;
                    case 5:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        Calculations();  // Входим в меню 5 "Прочие расчеты"
                        break;
                    case 6:
                        // Вызываем  нужную функцию
                        Console.Clear();
                       // Vibration();   // Входим в меню 6 "Перевод амплитуд"
                        break;
                    case 7:
                        // Вызываем  нужную функцию
                        Console.Clear();
                        Database();   // Входим в меню 7 "База данных" 
                        break;
                    case 8:
                        //Console.Clear();
                        return false;   // Выходим из программы
                                        //break;

                }
            }
            while (num == 8);
            // if (num == 8) { return false; }
            //else 
            return true;

        }
        static void CorrectiveMassnu1() // Меню 1 "Расчет корректирующих масс"
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
                string Choice = Console.ReadLine();
                num = Convert.ToInt32(Choice);
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
                        MainMenu();
                        break;

                }
            }
            while (num > 5);
        }
        static void EatingMetal()   // Меню 2 "Расчет выборок металла"
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
                        NewMethod(); //


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
                        MainMenu();
                        break;

                }
            }
            while (num > 6);
        }
        private static void NewMethod()
        {
            string Choice;
            do
            {
                double m, b, h, l;
                MetalSampling V = new MetalSampling();  // Вызываем класс Выборка металла
               // MetalSampling.LinearSampling(); // вызываем метод линейная выборка класса выборка металла
                Console.Write("Введите массу\t");
                string Mas = Console.ReadLine();
                m = Convert.ToDouble(Mas);
                Console.Write("Введите ширину\t");
                string Shir = Console.ReadLine();
                b = Convert.ToDouble(Shir);
                Console.Write("Введите высоту \t");
                string Vis = Console.ReadLine();
                h = Convert.ToDouble(Vis);
                V.LinearSampling(m, b, h);
                l =  V.LinearSampling(m, b, h);
                Console.WriteLine("Длинна выборки\t = \t" + l);
                Console.WriteLine("Масса выборки  =   " + m);
                Console.WriteLine("Повторить расчет\t-\tY");
                Console.WriteLine("Выйти в главное меню\t-\tN");
                Choice = Console.ReadLine();
            }
            while (Choice == "N");
           
           
        }
        static void Amplitude()   // Меню 3 "Расчет амплитуд"
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
                        MainMenu();
                        break;

                }
            }
            while (num > 4);
        }
        static void Compensation() // Меню 4 "Расчет компенсирующих масс"
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
                        ShaftСompensation();  // Вызываем метод расчет выпуклой полушпонки
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
                        MainMenu();
                        break;

                }
            }
            while (num > 5);
        }

        static void ShaftСompensation()  // Метод для расчета выпуклой полушпонки
        {
            // Вызываем  нужный класс
            string Vibor;
            do
            {
                Console.Clear();
                double m, b, h, l;

                KompensirMass VShponka = new KompensirMass(); // вызываем класс компенсация масс
                Console.Write("Введите длинну шпонки\t");
                string Dlin = Console.ReadLine();
                l = Convert.ToDouble(Dlin);
                Console.Write("Введите ширину\t");
                string Shir = Console.ReadLine();
                b = Convert.ToDouble(Shir);
                Console.Write("Введите высоту \t");
                string Vis = Console.ReadLine();
                h = Convert.ToDouble(Vis);
                VShponka.Shponka(b, h, l);  // передаем данные методу Шпонка класса компенсация масс
                m = VShponka.Shponka(b, h, l);  // Вызываем метод Шпонка класса компенсация масс
                Console.WriteLine("Масса выборки  =   " + m);
                Console.WriteLine("Повторить расчет\t-\tY");
                Console.WriteLine("Выйти в главное меню\t-\tN");
                Vibor = Console.ReadLine();
            }
            while (Vibor == "N");
        }

        static void Calculations()   // Меню 5 "Прочие расчеты"
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
                        MainMenu();
                        break;

                }
            }
            while (num > 1);
        }
        static void Vibration()  // Меню 6 " Перевод амплитуд"
        {
            Console.WriteLine("\t\tПЕРЕВОД АМПЛИТУД \n");
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
                        MainMenu();
                        break;

                }
            }
            while (num > 5);
        }
        static void Database()  // Меню 7 " База данных"
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
                        MainMenu();
                        break;

                }
            }
            while (num > 1);
        }
        static void Main(string[] arg)
        {
            Console.WriteLine("\tВАС ПРИВЕТСТВУЕТ ПРОГРАММА РАСЧЕТОВ РОТОРОВ\n");
            Console.Write("Введите код доступа\t");
            string Code = Console.ReadLine(); // Вводим пароль с клавиатуры
            bool cod = true;
            Password rotor = new Password(Code);
            Console.WriteLine(rotor.Parol);
            rotor.Parol = "parol123";
            //rotor.Cod(Code); // Передаем введенный пароль в класс  Password()
            if (rotor.Check())
            {

                while (cod == true)
                {
                    Console.Clear();
                    cod = MainMenu();
                    
                }
            }
            else
                Console.WriteLine("У вас нет прав доступа");

        }
    }

}


