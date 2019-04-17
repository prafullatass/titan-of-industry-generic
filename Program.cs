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
            kandyKorner.HireEmployee(new Confectioner() {
                FirstName = "Joe",
                LastName = "Smith"
            });


            SteelFactory erieSteel = new SteelFactory();
            erieSteel.HireEmployee(new SteelWorker() {
                FirstName = "Anil",
                LastName = "Ambani"
            });


            InsulinFactory johnsonChemical = new InsulinFactory();
            johnsonChemical.HireEmployee(new LabTechnician() {
                FirstName = "Peter",
                LastName = "C"
            });


            NuggetFactory flemingFoods = new NuggetFactory();
            flemingFoods.HireEmployee(new FoodProcessor() {
                FirstName = "Brad",
                LastName = "Chef"
            });


            CarFactory acmeAutos = new CarFactory();
            acmeAutos.HireEmployee(new AutoWorker() {
                FirstName = "Lynn",
                LastName = "Ford"
            });

        }
    }
}
