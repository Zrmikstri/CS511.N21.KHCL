using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net;

namespace MoMo.Model
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Bank> Banks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=users.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the User entity
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(10);
                entity.Property(e => e.Address).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.FullName).IsRequired();
                entity.Property(e => e.CitizenId).IsRequired();
                entity.Property(e => e.Birthday).IsRequired();
                entity.Property(e => e.AvatarImage).IsRequired().HasMaxLength(12);

                entity.HasMany(e => e.Transactions)
                      .WithOne(e => e.Sender)
                      .HasForeignKey(e => e.SenderId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(e => e.ChatMessages)
                    .WithOne(c => c.Sender)
                    .HasForeignKey(c => c.SenderId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Configure the Transaction entity
            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("services");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name).IsRequired();
            });

            // Configure the Transaction entity
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.Type).IsRequired();
                entity.Property(e => e.Date).IsRequired();

                entity.HasOne(e => e.Sender)
                      .WithMany(e => e.Transactions)
                      .HasForeignKey(e => e.SenderId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Receiver)
                        .WithMany()
                        .HasForeignKey(e => e.ReceiverId)
                        .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Service)
                        .WithMany()
                        .HasForeignKey(e => e.ServiceId)
                        .OnDelete(DeleteBehavior.Cascade);
            });

            // Configure the ChatMessage entity
            modelBuilder.Entity<ChatMessage>(entity =>
            {
                entity.ToTable("chat_messages");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Message).IsRequired();
                entity.Property(e => e.Date).IsRequired();

                entity.HasOne(e => e.Sender)
                      .WithMany(e => e.ChatMessages)
                      .HasForeignKey(e => e.SenderId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Receiver)
                        .WithMany()
                        .HasForeignKey(e => e.ReceiverId)
                        .OnDelete(DeleteBehavior.Cascade);
            });

            // Configure the Bank entity
            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("banks");
                entity.HasKey(e => e.Id);
               
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FullName = "Trần Phú Vinh",
                    Email = "vinh123@gmail.com",
                    PhoneNumber = "0123456789",
                    Address = "123 Trần Phú P10 Q5 TP.Hồ Chí Minh",
                    Password = "123"
                },
                new User
                {
                    Id = 2,
                    FullName = "Đào Trần Anh Tuấn",
                    Email = "tdao67216@gmail.com",
                    PhoneNumber = "0987654321",
                    Address = "456 Đào Tuấn P5 Q10 TP.Hồ Chí Minh",
                    Password = "456",
                    Balance = 50000000
                },
                new User
                {
                    Id = 3,
                    Email = "ckinset0@ehow.com",
                    PhoneNumber = "7377393940",
                    Address = "9911 Mandrake Circle",
                    Password = "599"
                },
                new User
                {
                    Id = 4,
                    Email = "ltrounce1@newyorker.com",
                    PhoneNumber = "2207764683",
                    Address = "0 Chinook Hill",
                    Password = "865"
                },
                new User
                {
                    Id = 5,
                    Email = "wspeariett2@wiley.com",
                    PhoneNumber = "5763806149",
                    Address = "9 Hollow Ridge Way",
                    Password = "939"
                },
                new User
                {
                    Id = 6,
                    Email = "nswapp3@cbc.ca",
                    PhoneNumber = "9263002147",
                    Address = "661 Forest Run Parkway",
                    Password = "169"
                },
                new User
                {
                    Id = 7,
                    Email = "ibosden4@yale.edu",
                    PhoneNumber = "2155269819",
                    Address = "5 Algoma Plaza",
                    Password = "538"
                },
                new User
                {
                    Id = 8,
                    Email = "cknapman5@jugem.jp",
                    PhoneNumber = "3578582722",
                    Address = "5896 Vahlen Hill",
                    Password = "923"
                },
                new User
                {
                    Id = 9,
                    Email = "troffey6@mashable.com",
                    PhoneNumber = "5736157050",
                    Address = "69 Ridgeview Circle",
                    Password = "316"
                },
                new User
                {
                    Id = 10,
                    Email = "rclipson7@lulu.com",
                    PhoneNumber = "6094288724",
                    Address = "46 Haas Drive",
                    Password = "649"
                });

            modelBuilder.Entity<ChatMessage>().HasData(
                new ChatMessage
                {
                    Id = 1,
                    Message = "Nạp tiền điện thoại",
                    SenderId = 1,
                    ReceiverId = 2,
                    IsRead = true,
                },
                new ChatMessage
                {
                    Id = 2,
                    Message = "Nạp tiền điện thoại",
                    SenderId = 1,
                    ReceiverId = 2,
                    IsRead = true,
                },
                new ChatMessage
                {
                    Id = 3,
                    Message = "Nạp tiền điện thoại",
                    ReceiverId = 1,
                    SenderId = 3,
                    IsRead = true,
                },
                new ChatMessage
                {
                    Id = 4,
                    Message = "Nạp tiền điện thoại",
                    ReceiverId = 3,
                    SenderId = 1,
                    IsRead = true,
                });

            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    Id = 1,
                    Name = "Nạp tiền điện thoại",
                    Description = "Nạp tiền điện thoại",
                },
                new Service
                {
                    Id = 2,
                    Name = "Đóng tiền nước",
                    Description = "Thanh toán hóa đơn tiền nước",
                },
                new Service
                {
                    Id = 3,
                    Name = "Đóng tiền điện",
                    Description = "Thanh toán hóa đơn tiền điện",
                },
                new Service
                {
                    Id = 4,
                    Name = "Đóng tiền internet",
                    Description = "Thanh toán hóa đơn tiền internet",
                },
                new Service
                {
                    Id = 5,

                });

            modelBuilder.Entity<Bank>().HasData(
                new Bank
                {
                    Id = 1,
                    Name = "Ngân hàng Vietcombank",
                },
                new Bank
                {
                    Id = 2,
                    Name = "Ngân hàng VietinBank",
                },
                new Bank
                {
                    Id = 3,
                    Name = "Ngân hàng BIDV",
                },
                new Bank
                {
                    Id = 4,
                    Name = "Ngân hàng Agribank",
                },
                new Bank
                {
                    Id = 5,
                    Name = "Ngân hàng Techcombank",
                },
                new Bank
                {
                    Id = 6,
                    Name = "Ngân hàng VIB",
                },
                new Bank
                {
                    Id = 7,
                    Name = "Ngân hàng ACB",
                },
                new Bank
                {
                    Id = 8,
                    Name = "Ngân hàng Sacombank",
                },
                new Bank
                {
                    Id = 9,
                    Name = "Ngân hàng TPBank",
                },
                new Bank
                {
                    Id = 10,
                    Name = "Ngân hàng DongAbank",
                },
                new Bank
                {
                    Id = 11,
                    Name = "Ngân hàng MBBank",
                },
                new Bank
                {
                    Id = 12,
                    Name = "Ngân hàng OCB",
                });

            modelBuilder.Entity<Transaction>().HasData(
                new Transaction
                {
                    Id = 1,
                    Amount = 100000,
                    Type = Transaction.TransactionType.Transfer,
                    Date = DateTime.Now,
                    SenderId = 1,
                    ReceiverId = 2,
                    Message = "Chuyển tiền sinh hoạt",
                },
                new Transaction
                {
                    Id = 2,
                    Amount = 200000,
                    Type = Transaction.TransactionType.Transfer,
                    Date = DateTime.Now,
                    SenderId = 1,
                    ReceiverId = 2,
                    Message = "Chuyển tiền sinh hoạt",
                },
                new Transaction
                {
                    Id = 3,
                    Amount = 150000,
                    Type = Transaction.TransactionType.Transfer,
                    Date = DateTime.Now,
                    SenderId = 1,
                    ReceiverId = 2,
                    Message = "Chuyển tiền sinh hoạt",
                },
                new Transaction
                {
                    Id = 4,
                    Amount = 100000,
                    Type = Transaction.TransactionType.Transfer,
                    Date = DateTime.Now,
                    SenderId = 2,
                    ReceiverId = 1,
                    Message = "Trả tiền thừa",
                },
                new Transaction
                {
                    Id = 5,
                    Amount = 200000,
                    Type = Transaction.TransactionType.Service,
                    Date = DateTime.Now,
                    SenderId = 1,
                    ServiceId = 1,
                },
                new Transaction
                {
                    Id = 6,
                    Amount = 2000000,
                    Type = Transaction.TransactionType.Service,
                    Date = DateTime.Now.AddMonths(1),
                    SenderId = 1,
                    ServiceId = 1,
                },
                new Transaction
                {
                    Id = 7,
                    Amount = 50000000,
                    Type = Transaction.TransactionType.Service,
                    Date = DateTime.Now.AddMonths(-1),
                    SenderId = 1,
                    ServiceId = 1,
                });
        }
    }
}
