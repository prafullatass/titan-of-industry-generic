using System.Collections.Generic;
using PennyPacker.Models.Workers;

namespace PennyPacker.Models.Factories {
    public class InsulinFactory {
        public List<LabTechnician> employees { get; set; } = new List<LabTechnician> ();

        public void HireEmployee (LabTechnician employee) {
            employees.Add (employee);
        }
    }
}