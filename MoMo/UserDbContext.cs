using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net;

namespace MoMo
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }

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

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Email = "vinh123@gmail.com",
                    PhoneNumber = "0123456789",
                    Address = "123 Trần Phú P10 Q5 TP.Hồ Chí Minh",
                    Password = "123"
                },
                new User
                {
                    Id = 2,
                    Email = "tuan456@gmail.com",
                    PhoneNumber = "0987654321",
                    Address = "456 Đào Tuấn P5 Q10 TP.Hồ Chí Minh",
                    Password = "456"
                });
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
