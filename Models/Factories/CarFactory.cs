using System.Collections.Generic;
using PennyPacker.Models.Workers;

namespace PennyPacker.Models.Factories {
    public class CarFactory {
        public List<AutoWorker> employees { get; set; } = new List<AutoWorker> ();

        public void HireEmployee (AutoWorker employee) {
            employees.Add (employee);
        }
    }
}