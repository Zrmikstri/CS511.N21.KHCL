namespace MoMo.Model
{
    public class User
    {
        public enum UserGender
        {
            Male = 0,
            Female = 1
        }

        public User()
        {
            AvatarImage = Utils.ImageToBytesArray(Image.FromFile(@"..\..\..\Images\user.png"));
        }

        public int Id { get; set; }
        public string FullName { get; set; } = "Test User";
        public UserGender Gender { get; set; }
        public string CitizenId { get; set; } = "012345678999";
        public string PhoneNumber { get; set; } = "0123456789";
        public DateTime Birthday { get; set; }
        public string Address { get; set; } = "Test Address";
        public string Email { get; set; } = "test@test.com";
        public string Password { get; set; } = "Test123";
        public byte[] AvatarImage { get; set; }
        public double Balance { get; set; } = 0;

        public int[] LinkedBankId { get; set; } = { 1, 2 };

        public virtual ICollection<Transaction> Transactions { get; } = new List<Transaction>();
        public virtual ICollection<ChatMessage> ChatMessages { get; } = new List<ChatMessage>();
    }
}
