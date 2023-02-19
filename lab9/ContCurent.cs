using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    class ContCurent : ContBancar
    {
        public ContCurent(string nume, double soldCurent ) : base(nume, soldCurent)
        {
        }

        public override void ExtrageBani(double extrageBani)
        {
            if (extrageBani > soldCurent + 5000)
            {
                Console.WriteLine("Suma indisponibila");
            }
            else
            {
                soldCurent -= extrageBani;
                AfiseazaSold();
            }
        }
    }
}
