using System;

namespace benjuazure.Common.Models
{
    public class Enterprise
    {
        public int EmployeId { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; }
        public bool IsConsolidated { get; set; }
    }
}
