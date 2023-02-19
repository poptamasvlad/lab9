using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    class ContInvestitii : ContEconomii
    {
        private int termenExtragere;
        public ContInvestitii(string nume, double soldCurent, double rataDobanda, int termenExtragere) : base(nume, soldCurent, rataDobanda)
        {
            this.termenExtragere = termenExtragere;
        }

        public override void DepuneBani(double depuneBani)
        {
            base.DepuneBani(depuneBani);
        }

        public override void ExtrageBani(double extrageBani)
        {
            if(termenExtragere > DateTime.Now.Day)
            {
                Console.WriteLine($"Nu puteti extrage bani pana in ziua {termenExtragere}");
            }
            else
            {
                base.ExtrageBani(extrageBani);
            }
        }

        public override void Descriere()
        {
            base.Descriere();
            Console.Write($"Termen Extragere: {termenExtragere} ");
        }
    }
}
