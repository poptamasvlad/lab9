using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            ContBancar contCurent = new ContCurent("Mihai", 1500);
            ContBancar contEconomi = new ContEconomii("Mihai", 2700, 0.07);
            ContBancar contInvestitii = new ContInvestitii("Mihai", 1300, 0.06, 29);

            contCurent.ExtrageBani(2000);
            contCurent.ExtrageBani(4800);
            contCurent.DepuneBani(2100);
            contCurent.Descriere();

            contEconomi.ExtrageBani(700);
            contEconomi.DepuneBani(100);
            contEconomi.Descriere();

            contInvestitii.DepuneBani(700);
            contInvestitii.ExtrageBani(500);
            contInvestitii.Descriere();
        }
    }
}
