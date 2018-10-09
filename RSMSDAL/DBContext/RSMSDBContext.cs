using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RSMSDATAMODELS.Data_Models;

namespace RSMSDAL.DBContext
{
    public partial class RSMSDBContext : DbContext
    {
        public RSMSDBContext()
        {
        }

        public RSMSDBContext(DbContextOptions<RSMSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Table> Table { get; set; }
        public virtual DbSet<TableBooking> TableBooking { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQL2017EXPRESS;Database=RSMSDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("Contact_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime)
                    .HasColumnName("Date_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtherDetails)
                    .HasColumnName("Other_Details")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartyNumber).HasColumnName("Party_Number");

                entity.Property(e => e.SpecialOccasion).HasColumnName("Special_Occasion");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TableBooking>(entity =>
            {
                entity.HasKey(e => new { e.BookingId, e.TableId });

                entity.ToTable("Table_Booking");

                entity.Property(e => e.BookingId).HasColumnName("Booking_ID");

                entity.Property(e => e.TableId).HasColumnName("Table_ID");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TableBooking)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_Booking_Booking");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.TableBooking)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_Booking_Table");
            });
        }
    }
}
