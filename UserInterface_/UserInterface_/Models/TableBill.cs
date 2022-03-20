using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInterface_.Models
{
    public class TableBill
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public string CreditCardNumber { get; set; }
        public string CardType { get; set; }
        public double Amount { get; set; }
        public string DateOfTransaction { get; set; }
    }
}
