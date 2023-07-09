using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Journal
    {
        public int JournalId { get; set; }
        public string? SymbolName { get; set; }
        public DateTime? Created { get; set; }
        public int? EntryPrice { get; set; }
        public int? ClosePrice { get; set; }
        public int? Quantity { get; set; }
        public int? Profit { get; set; }
        public int? Loss { get; set; }
        public string? Journal1 { get; set; }
    }
}
