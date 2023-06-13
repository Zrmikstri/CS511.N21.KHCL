using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace MoMo
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        public int SenderId { get; set; }
        public virtual User Sender { get; set; } = null!;
        
        public int ReceiverId { get; set; }
        public virtual User Receiver { get; set; } = null!;
    }
}
