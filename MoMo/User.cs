namespace MoMo
{
    public class User
    {
        public User()
        {
            AvatarImage = Utils.ImageToBytesArray(Image.FromFile(@"..\..\..\Images\user.png"));
        }

        public int Id { get; set; }
        public int Balance { get; set; }
        public string Address { get; set; } = "Test Address";
        public string Email { get; set; } = "test@test.com";
        public string PhoneNumber { get; set; } = "0123456789";
        public string Password { get; set; } = "Test123";
        public string FullName { get; set; } = "Test User";
        public string CitizenId { get; set; } = "012345678999";
        public DateTime Birthday { get; set; }
        public byte[] AvatarImage { get; set; }

        public virtual ICollection<Transaction> Transactions { get; } = new List<Transaction>();
        public virtual ICollection<ChatMessage> ChatMessages { get; } = new List<ChatMessage>();
    }
}
