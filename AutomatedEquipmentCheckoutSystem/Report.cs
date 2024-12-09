using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedEquipmentCheckoutSystem
{
    public class Report
    {
        public int ReportID { get; set; }
        public int GeneratedBy { get; set; }
        public DateTime DateGenerated { get; set; }

        public string GenerateUsageSummary()
        {
            return "Usage summary report generated.";
        }

        public List<string> GenerateOverdueList()
        {
            return new List<string> { "Overdue Equipment 1", "Overdue Equipment 2" };
        }
    }
}
