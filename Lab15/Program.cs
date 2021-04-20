using System;


namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            //public delegate int Func(string str2, int x); //расшифровка делегата Func
            //public delegate void Action(string str1); //расшифровка дегеата Action

            
            Func<Action<string>, int, int> func = Metod2;
            Action<string> action = Metod1;
            action("Иванов Иван Иванович");
            func(action, 30);

            
            Func<Action<string>, int, int> func2 = Metod4;
            Action<string> action2 = Metod3;
            action2("Инженер");
            func2(action2, 21);

            Console.ReadLine();

        }
        public static void Metod1(string name)
        {
            Console.WriteLine("Фамилия, имя, отчетсво: {0}", name);
        }

        public static int Metod2(Action<string> action, int year)
        {
            Console.WriteLine("Полных лет: {0}",year);
            return year;
        }

        public static void Metod3(string job)
        {
            Console.WriteLine("Должность: {0}", job);
        }

        public static int Metod4(Action<string> action, int day)
        {
            Console.WriteLine("Количество отработанных дней: {0}", day);
            return day;
        }
    
    }
}
