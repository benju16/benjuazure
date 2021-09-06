using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace benjuazure.Functions.Entities
{
    public class TimeEntity : TableEntity
    {
        public int EmployeId { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set;}
        public bool IsConsolidated { get; set; }

    }
}
