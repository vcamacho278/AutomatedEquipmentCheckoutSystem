using System;

namespace AutomatedEquipmentCheckoutSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a user
            User user = new User { UserID = 1, Username = "vcamacho", Password = "password" };
            Console.WriteLine($"User Created: {user.Username} (ID: {user.UserID})");

            // Authenticate the user
            if (user.Login("vcamacho", "password"))
            {
                Console.WriteLine($"{user.Username} has logged in successfully.");
            }
            else
            {
                Console.WriteLine("Invalid login credentials.");
                return;
            }

            // Create equipment
            Equipment equipment = new Equipment { EquipmentID = 101, Name = "Hammer", Status = "Available" };
            Console.WriteLine($"Equipment Created: {equipment.Name} (ID: {equipment.EquipmentID}, Status: {equipment.Status})");

            // Check out equipment
            Checkout checkout = new Checkout();
            if (equipment.CheckAvailability())
            {
                checkout.CheckOutItem(user.UserID, equipment.EquipmentID);
                equipment.UpdateStatus("In Use");
            }
            else
            {
                Console.WriteLine("Equipment is not available.");
            }

            // Return equipment
            checkout.ReturnItem(equipment.EquipmentID);
            equipment.UpdateStatus("Available");

            // Generate a report
            Report report = new Report();
            Console.WriteLine(report.GenerateUsageSummary());

            // Notify overdue
            checkout.NotifyOverdue();

            // Logout user
            user.Logout();
        }
    }
}