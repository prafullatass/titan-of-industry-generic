using System;
using PennyPacker.Models.Factories;
using PennyPacker.Models.Workers;

namespace PennyPacker
{
    class Program
    {
        static void Main(string[] args)
        {
            TaffyFactory kandyKorner = new TaffyFactory();
            kandyKorner.HireEmployee();


            SteelFactory erieSteel = new SteelFactory();


            InsulinFactory johnsonChemical = new InsulinFactory();


            NuggetFactory flemingFoods = new NuggetFactory();


            CarFactory acmeAutos = new CarFactory();

        }
    }
}
