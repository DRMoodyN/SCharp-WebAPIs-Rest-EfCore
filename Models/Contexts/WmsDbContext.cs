namespace Models.Contexts
{
    public class WmsDbContext : DbContext
    {
        public WmsDbContext()
        {
        }

        public WmsDbContext(DbContextOptions<WmsDbContext> option)
        : base(option)
        {
        }

        public virtual DbSet<RegionEntity> RegionEntity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=ScharpWms;User=Development;Password=Development2023#*");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegionEntity>(region =>
            {
                region.ToTable("Region", "Person");

                region.HasKey(h => h.RegionID);

                region.Property(p => p.RegionID)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RegionID")
                    .HasColumnType("INT")
                    .IsRequired(true)
                    .IsUnicode(true)
                    .HasColumnOrder(0);

                region.Property(p => p.Code)
                    .HasColumnName("Code")
                    .HasColumnType("NVARCHAR(3)")
                    .IsRequired(true)
                    .HasMaxLength(3)
                    .IsUnicode(true)
                    .HasColumnOrder(1);

                region.Property(p => p.RegionName)
                    .HasColumnName("RegionName")
                    .HasColumnType("NVARCHAR(50)")
                    .IsRequired(true)
                    .HasMaxLength(50)
                    .IsUnicode(true)
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
        }
    }
}
