using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedEquipmentCheckoutSystem
{
    public class Equipment
    {
        public int EquipmentID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } = "Available";

        public bool CheckAvailability()
        {
            return Status == "Available";
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }
    }
}