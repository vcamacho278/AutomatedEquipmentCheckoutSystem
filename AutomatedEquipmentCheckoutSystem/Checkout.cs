using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedEquipmentCheckoutSystem
{
    public class Checkout
    {
        public int CheckoutID { get; set; }
        public int UserID { get; set; }
        public int EquipmentID { get; set; }
        public DateTime DueDate { get; set; }

        public bool CheckOutItem(int userID, int equipmentID)
        {
            // Simulating a checkout process
            DueDate = DateTime.Now.AddDays(7);
            Console.WriteLine($"Checkout Successful: User {userID} checked out Equipment {equipmentID} with Due Date: {DueDate}");
            return true;
        }

        public void ReturnItem(int equipmentID)
        {
            Console.WriteLine($"Equipment {equipmentID} has been returned.");
        }

        public void NotifyOverdue()
        {
            Console.WriteLine("Overdue notification sent to the manager.");
        }
    }
}