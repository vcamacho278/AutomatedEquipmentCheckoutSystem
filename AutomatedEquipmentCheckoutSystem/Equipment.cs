using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedEquipmentCheckoutSystem
{
    public class Equipment
    {
        public int EquipmentID { get; set; }  // Unique identifier for each equipment
        public string Name { get; set; }      // Name of the equipment
        public string Status { get; set; }    // Status (e.g., Available, In Use)

        // Method to check availability
        public bool CheckAvailability()
        {
            return Status == "Available"; // Returns true if the equipment is available
        }
    }
}