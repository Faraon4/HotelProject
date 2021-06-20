namespace MyHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Creating the HotelDbContext.
    /// </summary>
    public class HotelDbContext : DbContext
    {
        /// <summary>
        ///  Gets or sets of DbSet of People.
        /// </summary>
        public virtual DbSet<People> People { get; set; }

        /// <summary>
        /// Gets or sets of DbSet of Rooms.
        /// </summary>
        public virtual DbSet<Rooms> Rooms { get; set; }

        /// <summary>
        /// Gets or sets of DbSet of Extras.
        /// </summary>
        public virtual DbSet<Extra> Extras { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HotelDbContext"/> class.
        /// Constructor that ensure that database is created.
        /// </summary>
        public HotelDbContext()
        {
            this.Database.EnsureCreated();
        }

        /// <summary>
        /// Overriding the OnConfiguring method.
        /// </summary>
        /// <param name="optionsBuilder">adding the optionBuilder parameter.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.
                    UseLazyLoadingProxies().
                    UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDb.mdf;Integrated Security=True;MultipleActiveResultSets=true");
            }
        }

        /// <summary>
        /// Overriding the OnModelCreating method.
        /// Here it is used Fluent Api.
        /// </summary>
        /// <param name="modelBuilder">creating the modelBuilder parameter. </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Extra>(entity =>
            {
                entity.ToTable("Extra");

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtraDays)
                    .HasColumnName("ExtraDays")
                    .HasMaxLength(200);

                entity.Property(e => e.ExtraNrpeople).HasColumnName("ExtraNrpeople");

                entity.Property(e => e.ExtraPrice).HasColumnName("ExtraPrice");

                entity.Property(e => e.ExtraTicket)
                    .HasColumnName("ExtraTicket")
                    .HasMaxLength(200);

                entity.Property(e => e.ExtraType)
                    .HasColumnName("ExtraType")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.ToTable("People");

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PeopleCheckin)
                    .HasColumnName("PeopleCheckin")
                    .HasColumnType("date");

                entity.Property(e => e.PeopleCheckout)
                    .HasColumnName("PeopleCheckout")
                    .HasColumnType("date");

                entity.Property(e => e.Country)
                    .HasColumnName("Country")
                    .HasMaxLength(200);

                entity.Property(e => e.PeopleExtraid).HasColumnName("PeopleExtraid");

                entity.Property(e => e.PeopleName)
                    .HasColumnName("PeopleName")
                    .HasMaxLength(200);

                entity.Property(e => e.PeopleRoomid).HasColumnName("PeopleRoomid");

                entity.HasOne(d => d.PeopleExtra)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.PeopleExtraid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_people_extra");

                entity.HasOne(d => d.PeopleRoom)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.PeopleRoomid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_people_room");
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.ToTable("Rooms");

                entity.Property(e => e.Id);
                 /*   .HasColumnName("Id")
                    .ValueGeneratedNever();
                 */
                entity.Property(e => e.RoomsAmount).HasColumnName("RoomsAmount");

                entity.Property(e => e.RoomsAvailable).HasColumnName("RoomsAvailable");

                entity.Property(e => e.RoomsPrice).HasColumnName("RoomsPrice");

                entity.Property(e => e.RoomsType)
                    .HasColumnName("RoomsType")
                    .HasMaxLength(200);

                entity.Property(e => e.RoomsView)
                    .HasColumnName("RoomsView")
                    .HasMaxLength(200);

                entity.Property(e => e.Selection)
              .HasColumnName("Selection")
              .HasMaxLength(200);
            });

            Rooms room1 = new Rooms() { Id = 111, RoomsType = "Double", RoomsAmount = 10, RoomsAvailable = 8, RoomsPrice = 240, RoomsView = "Seaside", Selection = "SELECTED" };
            Rooms room2 = new Rooms() { Id = 112, RoomsType = "Triple", RoomsAmount = 15, RoomsAvailable = 11, RoomsPrice = 300, RoomsView = "Pool", Selection = "SELECTED" };
            Rooms room3 = new Rooms() { Id = 113, RoomsType = "Quad", RoomsAmount = 4, RoomsAvailable = 3, RoomsPrice = 400, RoomsView = "Seaside", Selection = "SELECTED" };
            Rooms room4 = new Rooms() { Id = 114, RoomsType = "Twin", RoomsAmount = 7, RoomsAvailable = 4, RoomsPrice = 475, RoomsView = "Aqua-Park", Selection = "SELECTED" };
            Rooms room5 = new Rooms() { Id = 115, RoomsType = "Studio", RoomsAmount = 5, RoomsAvailable = 4, RoomsPrice = 700, RoomsView = "Pool", Selection = "UNSELECTED" };
            Rooms room6 = new Rooms() { Id = 116, RoomsType = "Queen", RoomsAmount = 3, RoomsAvailable = 1, RoomsPrice = 800, RoomsView = "Aqua-Park", Selection = "UNSELECTED" };
            Rooms room7 = new Rooms() { Id = 117, RoomsType = "King", RoomsAmount = 3, RoomsAvailable = 1, RoomsPrice = 1000, RoomsView = "Seaside", Selection = "SELECTED" };
            Rooms room8 = new Rooms() { Id = 118, RoomsType = "Suite", RoomsAmount = 1, RoomsAvailable = 0, RoomsPrice = 1200, RoomsView = "Pool", Selection = "UNSELECTED" };

            Extra extra1 = new Extra() { Id = 1231, ExtraType = "Muzeum", ExtraPrice = 10, ExtraDays = "Sunday", ExtraNrpeople = 100, ExtraTicket = "yes" };
            Extra extra2 = new Extra() { Id = 1232, ExtraType = "Parachute", ExtraPrice = 90, ExtraDays = "Every Day", ExtraNrpeople = 2, ExtraTicket = "yes" };
            Extra extra3 = new Extra() { Id = 1233, ExtraType = "Underwater Diving", ExtraPrice = 200, ExtraDays = "Tuesday", ExtraNrpeople = 7, ExtraTicket = "yes" };
            Extra extra4 = new Extra() { Id = 1234, ExtraType = "Excursion", ExtraPrice = 140, ExtraDays = "Monday", ExtraNrpeople = 30, ExtraTicket = "yes" };
            Extra extra5 = new Extra() { Id = 1235, ExtraType = "Safari", ExtraPrice = 100, ExtraDays = "Friday", ExtraNrpeople = 15, ExtraTicket = "yes" };
            Extra extra6 = new Extra() { Id = 1236, ExtraType = "Batiskaf", ExtraPrice = 200, ExtraDays = "Saturday", ExtraNrpeople = 20, ExtraTicket = "yes" };
            Extra extra7 = new Extra() { Id = 1237, ExtraType = "Banana", ExtraPrice = 50, ExtraDays = "Every Day", ExtraNrpeople = 7, ExtraTicket = "yes" };
            Extra extra8 = new Extra() { Id = 1238, ExtraType = "Night Excursion", ExtraPrice = 10, ExtraDays = "Wednesday", ExtraNrpeople = 40, ExtraTicket = "yes" };
            Extra extra9 = new Extra() { Id = 1239, ExtraType = "AquaPark", ExtraPrice = 100, ExtraDays = "Every Day", ExtraNrpeople = 200, ExtraTicket = "yes" };

            People people1 = new People() { Id = 120, PeopleName = "John", PeopleRoomid = 111, PeopleExtraid = 1234, Country = "Russia", PeopleCheckin = Convert.ToDateTime("2019-12-13"), PeopleCheckout = Convert.ToDateTime("2019-12-20") };
            People people2 = new People() { Id = 121, PeopleName = "Dean", PeopleRoomid = 112, PeopleExtraid = 1232, Country = "England", PeopleCheckin = Convert.ToDateTime("2019-12-05"), PeopleCheckout = Convert.ToDateTime("2019-12-20") };
            People people3 = new People() { Id = 122, PeopleName = "Jake", PeopleRoomid = 114, PeopleExtraid = 1237, Country = "Germany", PeopleCheckin = Convert.ToDateTime("2020-01-04"), PeopleCheckout = Convert.ToDateTime("2020-01-11") };
            People people4 = new People() { Id = 123, PeopleName = "Alfred", PeopleRoomid = 114, PeopleExtraid = 1238, Country = "Spain", PeopleCheckin = Convert.ToDateTime("2019-12-20"), PeopleCheckout = Convert.ToDateTime("2019-12-27") };
            People people5 = new People() { Id = 124, PeopleName = "Scott", PeopleRoomid = 116, PeopleExtraid = 1233, Country = "Poland", PeopleCheckin = Convert.ToDateTime("2020-01-13"), PeopleCheckout = Convert.ToDateTime("2020-01-20") };
            People people6 = new People() { Id = 125, PeopleName = "Berry", PeopleRoomid = 118, PeopleExtraid = 1239, Country = "Hungary", PeopleCheckin = Convert.ToDateTime("2020-02-14"), PeopleCheckout = Convert.ToDateTime("2020-02-21") };
            People people7 = new People() { Id = 126, PeopleName = "Kate", PeopleRoomid = 113, PeopleExtraid = 1232, Country = "Russia", PeopleCheckin = Convert.ToDateTime("2020-02-01"), PeopleCheckout = Convert.ToDateTime("2020-02-08") };
            People people8 = new People() { Id = 127, PeopleName = "Hamilton", PeopleRoomid = 112, PeopleExtraid = null, Country = "Hungary", PeopleCheckin = Convert.ToDateTime("2019-11-11"), PeopleCheckout = Convert.ToDateTime("2019-11-18") };
            People people9 = new People() { Id = 128, PeopleName = "Bruce", PeopleRoomid = 117, PeopleExtraid = null, Country = "Poland", PeopleCheckin = Convert.ToDateTime("2019-12-19"), PeopleCheckout = Convert.ToDateTime("2019-12-26") };
            People people10 = new People() { Id = 129, PeopleName = "Mirabela", PeopleRoomid = 116, PeopleExtraid = 1238, Country = "Russia", PeopleCheckin = Convert.ToDateTime("2019-12-13"), PeopleCheckout = Convert.ToDateTime("2019-12-20") };
            People people11 = new People() { Id = 130, PeopleName = "Dan", PeopleRoomid = 111, PeopleExtraid = 1236, Country = "Moldova", PeopleCheckin = Convert.ToDateTime("2020-02-09"), PeopleCheckout = Convert.ToDateTime("2020-02-16") };
            People people12 = new People() { Id = 131, PeopleName = "Drake", PeopleRoomid = 112, PeopleExtraid = 1231, Country = "Poland", PeopleCheckin = Convert.ToDateTime("2020-01-13"), PeopleCheckout = Convert.ToDateTime("2020-01-20") };
            People people13 = new People() { Id = 132, PeopleName = "Ann", PeopleRoomid = 115, PeopleExtraid = 1233, Country = "Austria", PeopleCheckin = Convert.ToDateTime("2019-12-13"), PeopleCheckout = Convert.ToDateTime("2019-12-20") };
            People people14 = new People() { Id = 133, PeopleName = "Edward", PeopleRoomid = 114, PeopleExtraid = 1234, Country = "Austria", PeopleCheckin = Convert.ToDateTime("2020-01-07"), PeopleCheckout = Convert.ToDateTime("2020-01-14") };
            People people15 = new People() { Id = 134, PeopleName = "Elly", PeopleRoomid = 117, PeopleExtraid = 1235, Country = "Moldova", PeopleCheckin = Convert.ToDateTime("2020-01-13"), PeopleCheckout = Convert.ToDateTime("2020-01-20") };
            People people16 = new People() { Id = 135, PeopleName = "Hanna", PeopleRoomid = 112, PeopleExtraid = 1239, Country = "Russia", PeopleCheckin = Convert.ToDateTime("2019-12-11"), PeopleCheckout = Convert.ToDateTime("2019-12-18") };

            modelBuilder.Entity<Rooms>().HasData(room1, room2, room3, room4, room5, room6, room7, room8);
            modelBuilder.Entity<Extra>().HasData(extra1, extra2, extra3, extra4, extra5, extra6, extra7, extra8, extra9);
            modelBuilder.Entity<People>().HasData(people1, people2, people3, people4, people5, people6, people7, people8, people9, people10, people11, people12, people13, people14, people15, people16);
        }
    }
}
