namespace MoMo
{
    public class User
    {
        //public User()
        //{
        //    //AvatarImage = Utils.ImageToBytesArray(Properties.Resources.user);
        //}

        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public byte[] AvatarImage { get; set; }

        //public virtual ICollection<OrderItem> OrderHistory { get; set; } = new List<OrderItem>();
        //public virtual ICollection<CartItem> ShoppingCart { get; set; } = new List<CartItem>();
    }
}
