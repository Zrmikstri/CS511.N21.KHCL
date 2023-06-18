using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoMo
{
    public class Transaction
    {
        // 0: Transfer between users, 1: Service payment
        public enum TransactionType
        {
            Transfer = 0,
            Service = 1
        }

        public int Id { get; set; }
        public int Amount { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; } = string.Empty;

        public int? SenderId { get; set; }
        public virtual User Sender { get; set; } = null!;

        public int? ReceiverId { get; set; }
        public virtual User? Receiver { get; set; } = null!;

        public int? ServiceId { get; set; }
        public virtual Service? Service { get; set; } = null!;
    }
}
