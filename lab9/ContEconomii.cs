using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    class ContEconomii : ContBancar
    {
        private double rataDobanda;
        public ContEconomii(string nume, double soldCurent, double rataDobanda) : base(nume, soldCurent)
        {
            this.rataDobanda = rataDobanda;
        }

        public override void DepuneBani(double depuneBani)
        {
            soldCurent += depuneBani;
            soldCurent = soldCurent * (1 + rataDobanda);
            AfiseazaSold();
        }

        public override void ExtrageBani(double extrageBani)
        {
            base.ExtrageBani(extrageBani);
        }

        public override void Descriere()
        {
            base.Descriere();
            Console.Write($"Rata: {rataDobanda} ");
        }


    }
}
