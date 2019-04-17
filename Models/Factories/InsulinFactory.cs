using System.Collections.Generic;

namespace PennyPacker.Models.Factories {
    public class InsulinFactory : IFactory {
        public List<LabTechnician> employees { get; set; } = new List<LabTechnician> ();

        public void HireEmployee (LabTechnician employee) {
            employees.Add (employee);
        }
    }
}