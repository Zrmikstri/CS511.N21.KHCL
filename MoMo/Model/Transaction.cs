using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoMo.Model
{
    public class Transaction
    {
        // 0: Transfer between users
        // 1: Service payment (e.g. electricity, water, internet, etc.)
        // 2: Transfer between user and bank
        public enum TransactionType
        {
            Transfer = 0,
            Service = 1,
            Bank = 2
        }

        public enum TransactionStatus
        {
            Success = 0,
            Failed = 1
        }

        public int Id { get; set; }
        public double Amount { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Message { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TransactionStatus Status { get; set; } = TransactionStatus.Success;

        public int? SenderId { get; set; }
        public virtual User? Sender { get; set; } = null!;

        public int? ReceiverId { get; set; }
        public virtual User? Receiver { get; set; } = null!;

        public int? ServiceId { get; set; }
        public virtual Service? Service { get; set; } = null!;

        public int? BankId { get; set; }
        public virtual Bank? Bank { get; set; } = null!;

        // Generate description for transaction base on receiver, sender, service, bank
        public string GenerateDescription()
        {
            if (string.IsNullOrEmpty(Description))
            {
                string description = string.Empty;
                switch (Type)
                {
                    case TransactionType.Transfer:
                        if (SenderId == Session.LoggedInUserInfo!.Id)
                            description = $"Chuyển tiền đến {Receiver!.FullName}";
                        else
                            description = $"Nhận tiền từ {Sender!.FullName}";
                        break;
                    case TransactionType.Service:
                        description = $"{Service!.Name}";
                        break;
                    case TransactionType.Bank:
                        if (ReceiverId == Session.LoggedInUserInfo!.Id)
                            description = $"Nạp tiền từ {Bank!.Name.Replace("Ngân hàng ", "")} vào ví";
                        else
                            description = $"Rút tiền từ ví về {Bank!.Name.Replace("Ngân hàng ", "")}";
                        break;
                }
                return description;
            }

            return Description;
        }

        public string GetAmount()
        {
            if(SenderId == Session.LoggedInUserInfo!.Id)
                return $"-{Utils.FormatVNCurrency(Amount)}";
            else
                return $"+{Utils.FormatVNCurrency(Amount)}";
        }
    }
}
