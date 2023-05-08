namespace Models
{
    public class WmsDbContext : IdentityDbContext<User>
    {
        public WmsDbContext()
        {
        }

        public WmsDbContext(DbContextOptions<WmsDbContext> option)
        : base(option)
        {
        }

        // Person
        public virtual DbSet<RegionEntity> Region { get; set; }
        public virtual DbSet<TypePhoneEntity> TypePhone { get; set; }
        public virtual DbSet<TypeEmailEntity> TypeEmail { get; set; }
        public virtual DbSet<TypePersonEntity> TypePerson { get; set; }
        public virtual DbSet<PersonEntity> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=ScharpWms;User=Development;Password=Development2023#*");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RegionEntity>(region =>
            {
                region.ToTable("Region", "Person");

                region.HasKey(h => h.RegionID);

                region.Property(p => p.RegionID)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RegionID")
                    .HasColumnType("INT")
                    .IsRequired(true)
                    .HasColumnOrder(0);

                region.Property(p => p.Code)
                    .HasColumnName("Code")
                    .HasColumnType("NVARCHAR(3)")
                    .IsRequired(true)
                    .HasMaxLength(3)
                    .HasColumnOrder(1);

                region.Property(p => p.RegionName)
                    .HasColumnName("RegionName")
                    .HasColumnType("NVARCHAR(50)")
                    .IsRequired(true)
                    .HasMaxLength(50)
                    .HasColumnOrder(2);

                region.Property(p => p.RegionSubID)
                    .HasColumnName("RegionSubID")
                    .HasColumnType("INT")
                    .IsRequired(false)
                    .HasColumnOrder(3);

                region.Property(p => p.Level)
                    .HasColumnName("Level")
                    .HasColumnType("INT")
                    .IsRequired(true)
                    .HasColumnOrder(4)
                    .HasDefaultValueSql("(1)");

                region.Property(p => p.UserCreate)
                    .HasColumnName("UserCreate")
                    .HasColumnType("NVARCHAR(50)")
                    .IsRequired(true)
                    .HasColumnOrder(5);

                region.Property(p => p.UserModify)
                    .HasColumnName("UserModify")
                    .HasColumnType("NVARCHAR(50)")
                    .IsRequired(true)
                    .HasColumnOrder(6);

                region.Property(p => p.DateCreate)
                    .HasColumnName("DateCreate")
                    .HasColumnType("DATE")
                    .IsRequired(true)
                    .HasColumnOrder(7)
                    .HasDefaultValueSql("GETDATE()");

                region.Property(p => p.DateModify)
                    .HasColumnName("DateModify")
                    .HasColumnType("DATE")
                    .IsRequired(true)
                    .HasColumnOrder(8)
                    .HasDefaultValueSql("GETDATE()");

                region.Property(p => p.IsActive)
                    .HasColumnName("IsActive")
                    .IsRequired(true)
                    .HasColumnOrder(9)
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<TypePhoneEntity>(phone =>
            {
                phone.ToTable("TypePhone", "Person");

                phone.HasKey(h => h.TypePhoneID);

                phone.Property(p => p.TypePhoneID)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TypePhoneID")
                    .HasColumnType("INT")
                    .HasColumnOrder(0)
                    .IsRequired(true);

                phone.Property(p => p.TypePhoneName)
                    .HasColumnName("TypePhoneName")
                    .HasColumnType("NVARCHAR(20)")
                    .HasMaxLength(20)
                    .IsRequired(true)
                    .HasColumnOrder(1);


                phone.Property(p => p.UserCreate)
                    .HasColumnName("UserCreate")
                    .HasColumnType("NVARCHAR(50)")
                    .IsRequired(true)
                    .HasColumnOrder(5);

                phone.Property(p => p.UserModify)
                    .HasColumnName("UserModify")
                    .HasColumnType("NVARCHAR(50)")
                    .IsRequired(true)
                    .HasColumnOrder(6);

                phone.Property(p => p.DateCreate)
                    .HasColumnName("DateCreate")
                    .HasColumnType("DATE")
                    .IsRequired(true)
                    .HasColumnOrder(7)
                    .HasDefaultValueSql("GETDATE()");

                phone.Property(p => p.DateModify)
                    .HasColumnName("DateModify")
                    .HasColumnType("DATE")
                    .IsRequired(true)
                    .HasColumnOrder(8)
                    .HasDefaultValueSql("GETDATE()");

                phone.Property(p => p.IsActive)
                    .HasColumnName("IsActive")
                    .IsRequired(true)
                    .HasColumnOrder(9)
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<TypeEmailEntity>(email =>
                {
                    email.ToTable("TypeEmail", "Person");

                    email.HasKey(h => h.TypeEmailID);

                    email.Property(p => p.TypeEmailID)
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TypeEmailID")
                        .HasColumnType("INT")
                        .HasColumnOrder(0)
                        .IsRequired(true);

                    email.Property(p => p.TypeEmailName)
                        .HasColumnName("TypeEmailName")
                        .HasColumnType("NVARCHAR(20)")
                        .HasMaxLength(20)
                        .IsRequired(true)
                        .HasColumnOrder(1);



                    email.Property(p => p.UserCreate)
                        .HasColumnName("UserCreate")
                        .HasColumnType("NVARCHAR(50)")
                        .IsRequired(true)
                        .HasColumnOrder(5);

                    email.Property(p => p.UserModify)
                        .HasColumnName("UserModify")
                        .HasColumnType("NVARCHAR(50)")
                        .IsRequired(true)
                        .HasColumnOrder(6);

                    email.Property(p => p.DateCreate)
                        .HasColumnName("DateCreate")
                        .HasColumnType("DATE")
                        .IsRequired(true)
                        .HasColumnOrder(7)
                        .HasDefaultValueSql("GETDATE()");

                    email.Property(p => p.DateModify)
                        .HasColumnName("DateModify")
                        .HasColumnType("DATE")
                        .IsRequired(true)
                        .HasColumnOrder(8)
                        .HasDefaultValueSql("GETDATE()");

                    email.Property(p => p.IsActive)
                        .HasColumnName("IsActive")
                        .IsRequired(true)
                        .HasColumnOrder(9)
                        .HasDefaultValueSql("(1)");
                });

            modelBuilder.Entity<TypePersonEntity>(person =>
                {
                    person.ToTable("TypePerson", "Person");

                    person.HasKey(h => h.TypePersonID);

                    person.Property(p => p.TypePersonID)
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TypePersonID")
                        .HasColumnType("INT")
                        .HasColumnOrder(0)
                        .IsRequired(true);

                    person.Property(p => p.TypePersonName)
                        .HasColumnName("TypePersonName")
                        .HasColumnType("NVARCHAR(20)")
                        .HasMaxLength(20)
                        .IsRequired(true)
                        .HasColumnOrder(1);

                    person.Property(p => p.UserCreate)
                        .HasColumnName("UserCreate")
                        .HasColumnType("NVARCHAR(50)")
                        .IsRequired(true)
                        .HasColumnOrder(5);

                    person.Property(p => p.UserModify)
                        .HasColumnName("UserModify")
                        .HasColumnType("NVARCHAR(50)")
                        .IsRequired(true)
                        .HasColumnOrder(6);

                    person.Property(p => p.DateCreate)
                        .HasColumnName("DateCreate")
                        .HasColumnType("DATE")
                        .IsRequired(true)
                        .HasColumnOrder(7)
                        .HasDefaultValueSql("GETDATE()");

                    person.Property(p => p.DateModify)
                        .HasColumnName("DateModify")
                        .HasColumnType("DATE")
                        .IsRequired(true)
                        .HasColumnOrder(8)
                        .HasDefaultValueSql("GETDATE()");

                    person.Property(p => p.IsActive)
                        .HasColumnName("IsActive")
                        .IsRequired(true)
                        .HasColumnOrder(9)
                        .HasDefaultValueSql("(1)");
                });

            modelBuilder.Entity<PersonEntity>(person =>
                {
                    person.ToTable("Person", "Person");

                    person.HasKey(h => h.PersonID);

                    person.Property(p => p.PersonID)
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PersonID")
                        .HasColumnType("INT")
                        .HasColumnOrder(0)
                        .IsRequired(true);

                    person.Property(p => p.Information)
                        .HasColumnName("Information")
                        .HasColumnType("NVARCHAR(20)")
                        .HasMaxLength(20)
                        .IsRequired(true)
                        .HasColumnOrder(1);

                    person.Property(p => p.FirstName1)
                        .HasColumnName("FirstName1")
                        .HasColumnType("NVARCHAR(50)")
                        .HasMaxLength(50)
                        .IsRequired(true)
                        .HasColumnOrder(2);

                    person.Property(p => p.FirstName2)
                       .HasColumnName("FirstName2")
                       .HasColumnType("NVARCHAR(50)")
                       .HasMaxLength(50)
                       .HasColumnOrder(3);

                    person.Property(p => p.LastName1)
                       .HasColumnName("LastName1")
                       .HasColumnType("NVARCHAR(50)")
                       .HasMaxLength(50)
                       .IsRequired(true)
                       .HasColumnOrder(4);

                    person.Property(p => p.LastName2)
                       .HasColumnName("LastName2")
                       .HasColumnType("NVARCHAR(50)")
                       .HasMaxLength(50)
                       .HasColumnOrder(5);

                    person.Property(p => p.UserCreate)
                        .HasColumnName("UserCreate")
                        .HasColumnType("NVARCHAR(50)")
                        .IsRequired(true)
                        .HasColumnOrder(6);

                    person.Property(p => p.UserModify)
                        .HasColumnName("UserModify")
                        .HasColumnType("NVARCHAR(50)")
                        .IsRequired(true)
                        .HasColumnOrder(7);

                    person.Property(p => p.DateCreate)
                        .HasColumnName("DateCreate")
                        .HasColumnType("DATE")
                        .IsRequired(true)
                        .HasColumnOrder(8)
                        .HasDefaultValueSql("GETDATE()");

                    person.Property(p => p.DateModify)
                        .HasColumnName("DateModify")
                        .HasColumnType("DATE")
                        .IsRequired(true)
                        .HasColumnOrder(9)
                        .HasDefaultValueSql("GETDATE()");

                    person.Property(p => p.IsActive)
                        .HasColumnName("IsActive")
                        .IsRequired(true)
                        .HasColumnOrder(10)
                        .HasDefaultValueSql("(1)");

                    person
                    .HasOne(h => h.TypePersonEntity)
                    .WithMany(w => w.Person)
                    .HasForeignKey(h => h.TypePersonID)
                    .IsRequired(true);
                });

            modelBuilder.ApplyConfiguration(new RolConfiguration());
        }
    }
}
