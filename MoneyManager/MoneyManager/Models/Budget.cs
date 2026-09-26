using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Models
{
    internal class Budget
    {
        public required string Category { get; set; }
        public decimal Limit { get; set; }
        public decimal Spent { get; set; }
    }
}
