using System.Collections.Generic;
using PennyPacker.Interfaces;
using PennyPacker.Models.Workers;

namespace PennyPacker.Models.Factories {
    public class SteelFactory : IFactory {
        public List<SteelWorker> employees { get; set; } = new List<SteelWorker> ();

        public void HireEmployee (SteelWorker employee) {
            employees.Add (employee);
        }
    }
}