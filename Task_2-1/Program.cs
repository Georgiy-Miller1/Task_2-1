﻿using System;
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
            Console.WriteLine("Введите сумму гривен которую вы хотите обменять...");
            double sum_ua = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите валюту которую хотите конвертировать в гривну...1-usd,2-eur,3-rub");
            double currency = Convert.ToDouble(Console.ReadLine());

            Converter converter = new Converter(sum_ua);
            switch (currency)
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
            Console.ReadKey();
        }
       
    }
}
