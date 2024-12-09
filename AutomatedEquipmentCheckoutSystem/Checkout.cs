using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedEquipmentCheckoutSystem
{
    public class Checkout
    {
        public int CheckoutID { get; set; }    // Unique identifier for each checkout transaction
        public int UserID { get; set; }        // ID of the user performing the checkout
        public int EquipmentID { get; set; }  // ID of the equipment being checked out
        public DateTime DueDate { get; set; } // Due date for returning the equipment

        // Method to process checkout
        public bool CheckoutItem(int userID, int equipmentID)
        {
            // Basic implementation: For now, assume checkout is always successful
            this.UserID = userID;
            this.EquipmentID = equipmentID;
            this.DueDate = DateTime.Now.AddDays(7); // Set a default due date 7 days from now
            return true; // Indicate success
        }

        // Method to return the item
        public void ReturnItem()
        {
            EquipmentID = 0; // Clear the equipment ID to indicate it's been returned
        }
    }
}