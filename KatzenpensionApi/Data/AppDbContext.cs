using KatzenpensionApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KatzenpensionApi.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<CommentModel> Comments => Set<CommentModel>();
        public DbSet<RegularGuestModel> RegularGuests => Set<RegularGuestModel>();
        public DbSet<RoomModel> Rooms => Set<RoomModel>();
        public DbSet<BookingModel> Bookings => Set<BookingModel>();
        public DbSet<ContactInfoModel> ContactInfos => Set<ContactInfoModel>();
        public DbSet<CatInfoModel> CatInfos => Set<CatInfoModel>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookingModel>()
                .HasOne(b => b.CatInfo) //booking has 1 catInfo
                .WithOne(c => c.Booking) //catInfo belongs to this Booking
                .HasForeignKey<CatInfoModel>(c => c.BookingId) //foreignKey is in catInfo
                .OnDelete(DeleteBehavior.Cascade); //delete catInfo when delete Booking

            modelBuilder.Entity<BookingModel>()
                .HasOne(b => b.ContactInfo)
                .WithOne(c => c.Booking)
                .HasForeignKey<ContactInfoModel>(c => c.BookingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
