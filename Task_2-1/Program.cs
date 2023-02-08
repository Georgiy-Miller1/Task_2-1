using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    class Program
    {
        /*
         Задание 2 
         Используя Visual Studio, создайте проект по шаблону Console Application. 
         Требуется: 
         1-Создать класс Converter. 
         2-В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
           и инициализирует поля соответствующие курсу 3-х основных валют, 
           по отношению к гривне – public Converter(double usd, double eur, double rub). 
         3-Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, 
           также программа должна производить конвертацию из указанных валют в гривну. 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Поменять гривны на другую валюту нажмите 1,поменять валюту на гривну нажмите 2...");
            int exchange = Convert.ToInt32(Console.ReadLine());
            if(exchange == 1)
            {
                Console.WriteLine("Введите сумму гривен которую вы хотите обменять...");
                double sum_ua = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите валюту которую на которую вы хотите поменять гривну:1-usd,2-eur,3-rub");
                double currency_from = Convert.ToDouble(Console.ReadLine());

                Converter converter = new Converter(sum_ua);
                switch (currency_from)
                {
                    case 1:
                        converter.usd_convert(sum_ua);
                        break;
                    case 2:
                        converter.eur_converter(sum_ua);
                        break;
                    case 3:
                        converter.rub_converter(sum_ua);
                        break;
                    default:
                        break;
                }
              
            }
            else if (exchange == 2)
            {
                Console.WriteLine("Какую валюту хотите обменять на гривну:1-usd,2-eur,3-rub");
                int currency_in = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите сумму валюты которую вы хотите обменять на гривну...");
                double sum_corrency = Convert.ToDouble(Console.ReadLine());

                Converter converter = new Converter(sum_corrency);

                switch (currency_in)
                {
                    case 1:
                        converter.from_usd(sum_corrency);
                        break;
                    case 2:
                        converter.from_eur(sum_corrency);
                        break;
                    case 3:
                        converter.from_rub(sum_corrency);
                        break;
                    default:
                        break;
                }
            }
            
            Console.WriteLine("!!!!!!!!!!!!");
            Console.WriteLine("Goodbye");

            Console.ReadKey();
        }
       
    }
}
