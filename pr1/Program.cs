using System;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvitancia a = new Kvitancia();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1 - Добавить квитанцию" + " " +
                "2 - Вывести квитанцию" + " " + "3 - Выход");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            a.Input();
                            break;
                        }
                    case 2:
                        {
                            a.Print();
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            }
        }
    }
}