using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Models
{
    public class Account
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
