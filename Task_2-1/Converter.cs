using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    class Converter
    {
        double usd, eur, rub,sum_ua;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public Converter(double sum_ua)
        {
            this.sum_ua = sum_ua;
        }


        public void usd_convert(double sum_ua)
        {
            Console.WriteLine($"Вы получите {sum_ua * 0.027} usd");
        }

        public void eur_converter(double sum_ua)
        {
            Console.WriteLine($"Вы получите {sum_ua * 0.25} eur");
        }

        public void rub_converter(double sum_ua)
        {
            Console.WriteLine($"Вы получите {sum_ua * 1.91} rub");
        }

        public void from_usd(double sum_corrency)
        {
            Console.WriteLine($"Вы получите {sum_corrency * 36.93} грн");
        }

        public void from_eur(double sum_corrency)
        {
            Console.WriteLine($"Вы получите {sum_corrency * 39.81} грн");
        }

        public void from_rub(Double sum_corrency)
        {
            Console.WriteLine($"Вы получите {sum_corrency * 0.52} грн");
        }
    }
}
