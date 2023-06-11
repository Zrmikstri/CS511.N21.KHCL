using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Net;

namespace MoMo
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<CartItem> CartItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=users.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the User entity
            modelBuilder.Entity<User>()
                        .HasKey(user => user.Id);

            modelBuilder.Entity<User>()
                        .HasIndex(user => user.Email)
                        .IsUnique();

            modelBuilder.Entity<User>()
                        .HasIndex(user => user.Username)
                        .IsUnique();

            modelBuilder.Entity<User>()
                        .HasIndex(user => user.PhoneNumber)
                        .IsUnique();

            //modelBuilder.Entity<User>()
            //            .HasMany(user => user.OrderHistory)
            //            .WithOne(orderItem => orderItem.User)
            //            .HasForeignKey(orderItem => orderItem.UserId);

            //modelBuilder.Entity<User>()
            //            .HasMany(user => user.ShoppingCart)
            //            .WithOne(cartItem => cartItem.User)
            //            .HasForeignKey(cartItem => cartItem.UserId);

            //// Configure the OrderItem entity for seeding
            //modelBuilder.Entity<OrderItem>()
            //    .HasOne(orderItem => orderItem.User)
            //    .WithMany(user => user.OrderHistory)
            //    .HasForeignKey(orderItem => orderItem.UserId)
            //    .IsRequired();

            //modelBuilder.Entity<OrderItem>()
            //    .HasKey(orderItem => orderItem.Id);

            //modelBuilder.Entity<OrderItem>()
            //    .Property(orderItem => orderItem.ServiceType)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //modelBuilder.Entity<OrderItem>()
            //    .Property(orderItem => orderItem.Quantity)
            //    .IsRequired();

            //modelBuilder.Entity<OrderItem>()
            //    .Property(orderItem => orderItem.Price)
            //    .IsRequired();

            //// Configure the CartItem entity
            //modelBuilder.Entity<CartItem>()
            //    .HasOne(cartItem => cartItem.User)
            //    .WithMany(user => user.ShoppingCart)
            //    .HasForeignKey(cartItem => cartItem.UserId)
            //    .IsRequired();

            //modelBuilder.Entity<CartItem>()
            //    .HasKey(cartItem => cartItem.Id);

            //modelBuilder.Entity<CartItem>()
            //    .Property(cartItem => cartItem.ServiceType)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //modelBuilder.Entity<CartItem>()
            //    .Property(cartItem => cartItem.Quantity)
            //    .IsRequired();

            //modelBuilder.Entity<CartItem>()
            //    .Property(cartItem => cartItem.Price)
            //    .IsRequired();

            //modelBuilder.Entity<OrderItem>().HasData(
            //    new OrderItem(2, 1),
            //    new OrderItem(3, 1),
            //    new OrderItem(4, 1),
            //    new OrderItem(5, 1),
            //    new OrderItem(6, 1),
            //    new OrderItem(7, 1),
            //    new OrderItem(8, 1),
            //    new OrderItem(9, 1),
            //    new OrderItem(10, 1),
            //    new OrderItem(11, 2),
            //    new OrderItem(12, 2),
            //    new OrderItem(13, 2),
            //    new OrderItem(14, 2),
            //    new OrderItem(15, 2),
            //    new OrderItem(16, 2),
            //    new OrderItem(17, 2),
            //    new OrderItem(18, 2),
            //    new OrderItem(19, 2),
            //    new OrderItem(20, 2),
            //    new OrderItem(21, 3),
            //    new OrderItem(22, 3),
            //    new OrderItem(23, 3),
            //    new OrderItem(24, 3),
            //    new OrderItem(25, 3),
            //    new OrderItem(26, 3),
            //    new OrderItem(27, 3),
            //    new OrderItem(28, 3),
            //    new OrderItem(29, 3),
            //    new OrderItem(30, 3),
            //    new OrderItem(31, 4),
            //    new OrderItem(32, 4),
            //    new OrderItem(33, 4),
            //    new OrderItem(34, 4),
            //    new OrderItem(35, 4),
            //    new OrderItem(36, 4),
            //    new OrderItem(37, 4),
            //    new OrderItem(38, 4),
            //    new OrderItem(39, 4),
            //    new OrderItem(40, 4),
            //    new OrderItem(41, 5),
            //    new OrderItem(42, 5),
            //    new OrderItem(43, 5),
            //    new OrderItem(44, 5),
            //    new OrderItem(45, 5),
            //    new OrderItem(46, 5),
            //    new OrderItem(47, 5),
            //    new OrderItem(48, 5),
            //    new OrderItem(49, 5),
            //    new OrderItem(50, 5),
            //    new OrderItem(51, 6),
            //    new OrderItem(52, 6),
            //    new OrderItem(53, 6),
            //    new OrderItem(54, 6),
            //    new OrderItem(55, 6),
            //    new OrderItem(56, 6),
            //    new OrderItem(57, 6),
            //    new OrderItem(58, 6),
            //    new OrderItem(59, 6),
            //    new OrderItem(60, 6),
            //    new OrderItem(61, 7),
            //    new OrderItem(62, 7),
            //    new OrderItem(63, 7),
            //    new OrderItem(64, 7),
            //    new OrderItem(65, 7),
            //    new OrderItem(66, 7),
            //    new OrderItem(67, 7),
            //    new OrderItem(68, 7),
            //    new OrderItem(69, 7),
            //    new OrderItem(70, 7),
            //    new OrderItem(71, 8),
            //    new OrderItem(72, 8),
            //    new OrderItem(73, 8),
            //    new OrderItem(74, 8),
            //    new OrderItem(75, 8),
            //    new OrderItem(76, 8),
            //    new OrderItem(77, 8),
            //    new OrderItem(78, 8),
            //    new OrderItem(79, 8),
            //    new OrderItem(80, 8),
            //    new OrderItem(81, 9),
            //    new OrderItem(82, 9),
            //    new OrderItem(83, 9),
            //    new OrderItem(84, 9),
            //    new OrderItem(85, 9),
            //    new OrderItem(86, 9),
            //    new OrderItem(87, 9),
            //    new OrderItem(88, 9),
            //    new OrderItem(89, 9),
            //    new OrderItem(90, 9),
            //    new OrderItem(91, 10),
            //    new OrderItem(92, 10),
            //    new OrderItem(93, 10),
            //    new OrderItem(94, 10),
            //    new OrderItem(95, 10),
            //    new OrderItem(96, 10),
            //    new OrderItem(97, 10),
            //    new OrderItem(98, 10),
            //    new OrderItem(99, 10),
            //    new OrderItem(100, 10));

            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = 1,
            //        Email = "vinh123@gmail.com",
            //        Username = "Vinh",
            //        PhoneNumber = "0123456789",
            //        Address = "123 Trần Phú P10 Q5 TP.Hồ Chí Minh",
            //        Password = "123"
            //    },
            //    new User
            //    {
            //        Id = 2,
            //        Email = "tuan456@gmail.com",
            //        Username = "Tuan",
            //        PhoneNumber = "0987654321",
            //        Address = "456 Đào Tuấn P5 Q10 TP.Hồ Chí Minh",
            //        Password = "456"
            //    },
            //    new User
            //    {
            //        Id = 3,
            //        Email = "ckinset0@ehow.com",
            //        Username = "mmelbert0",
            //        PhoneNumber = "7377393940",
            //        Address = "9911 Mandrake Circle",
            //        Password = "599"
            //    },
            //    new User
            //    {
            //        Id = 4,
            //        Email = "ltrounce1@newyorker.com",
            //        Username = "mkinver1",
            //        PhoneNumber = "2207764683",
            //        Address = "0 Chinook Hill",
            //        Password = "865"
            //    },
            //    new User
            //    {
            //        Id = 5,
            //        Email = "wspeariett2@wiley.com",
            //        Username = "ablanchard2",
            //        PhoneNumber = "5763806149",
            //        Address = "9 Hollow Ridge Way",
            //        Password = "939"
            //    },
            //    new User
            //    {
            //        Id = 6,
            //        Email = "nswapp3@cbc.ca",
            //        Username = "skehri3",
            //        PhoneNumber = "9263002147",
            //        Address = "661 Forest Run Parkway",
            //        Password = "169"
            //    },
            //    new User
            //    {
            //        Id = 7,
            //        Email = "ibosden4@yale.edu",
            //        Username = "zpook4",
            //        PhoneNumber = "2155269819",
            //        Address = "5 Algoma Plaza",
            //        Password = "538"
            //    },
            //    new User
            //    {
            //        Id = 8,
            //        Email = "cknapman5@jugem.jp",
            //        Username = "hagius5",
            //        PhoneNumber = "3578582722",
            //        Address = "5896 Vahlen Hill",
            //        Password = "923"
            //    },
            //    new User
            //    {
            //        Id = 9,
            //        Email = "troffey6@mashable.com",
            //        Username = "wchristophersen6",
            //        PhoneNumber = "5736157050",
            //        Address = "69 Ridgeview Circle",
            //        Password = "316"
            //    },
            //    new User
            //    {
            //        Id = 10,
            //        Email = "rclipson7@lulu.com",
            //        Username = "tgwillim7",
            //        PhoneNumber = "6094288724",
            //        Address = "46 Haas Drive",
            //        Password = "649"
            //    });
        }
    }
}
