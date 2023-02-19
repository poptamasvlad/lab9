using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    class ContBancar
    {
        public string nume;
        public double soldCurent;

        public ContBancar(string nume, double soldCurent)
        {
            this.soldCurent = soldCurent;
            this.nume = nume;
        }
        public virtual void DepuneBani(double depuneBani)
        {
            soldCurent += depuneBani;
            AfiseazaSold();
        }
        public virtual void ExtrageBani(double extrageBani)
        {
            if(extrageBani > soldCurent)
            {
                Console.WriteLine("Sold insuficient");
            }
            else
            {
                soldCurent -= extrageBani;
                AfiseazaSold();
            }
        }
        public void AfiseazaSold()
        {
            Console.WriteLine($"Soldul curent este {soldCurent}");
        }

        public virtual void Descriere()
        {
            Console.Write($"Nume: {nume} ,{this.GetType().Name} , Sold: {soldCurent} ");
        }


    }
}
