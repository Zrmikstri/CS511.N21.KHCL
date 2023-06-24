using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace MoMo.Model
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public byte[]? Image { get; set; } = null;
        public byte[]? Audio { get; set; } = null;
        public bool IsRead { get; set; } = false;
        public DateTime Date { get; set; } = DateTime.Now;

        public int SenderId { get; set; }
        public virtual User Sender { get; set; } = null!;

        public int ReceiverId { get; set; }
        public virtual User Receiver { get; set; } = null!;
    }
}
