using System.Data.Entity;

namespace Entity
{
    public class DALQLNH : DbContext
    {
        // Your context has been configured to use a 'DALQLNH' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Entity.DALQLNH' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DALQLNH' 
        // connection string in the application configuration file.
        public DALQLNH()
            : base("name=DALQLNH")
        {
            Database.SetInitializer<DALQLNH>(new CreateDB());
        }
        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<CaLam> CaLams { get; set; }
        public virtual DbSet<ChiTietMonAn> ChiTietMonAns { get; set; }
        public virtual DbSet<ChiTietNhaCungCap> ChiTietNhaCungCaps { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LoaiNguyenLieu> LoaiNguyenLieus { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieus { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<BangChamCong> BangChamCongs { get; set; }
        public virtual DbSet<ChiTietBan> ChiTietBans { get; set; }
        public virtual DbSet<LoaiMonAn> LoaiMonAns { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BangChamCong>()
                .HasRequired<User>(s => s.User)
                .WithMany(g => g.BangChamCongs)
                .HasForeignKey<int>(s => s.ID_User);
            modelBuilder.Entity<MonAn>()
                .HasRequired<LoaiMonAn>(s => s.LoaiMonAn)
                .WithMany(g => g.MonAns)
                .HasForeignKey<int>(s => s.ID_LoaiMonAn);
            modelBuilder.Entity<CaLam>()
                .HasMany<User>(s => s.Users)
                .WithMany(c => c.CaLams)
                .Map(cs =>
                {
                    cs.MapLeftKey("ID_CaLam");
                    cs.MapRightKey("ID_User");
                    cs.ToTable("ChiTietCaLam");
                });
            modelBuilder.Entity<User>()
                .HasRequired<ChucVu>(s => s.ChucVu)
                .WithMany(g => g.Users)
                .HasForeignKey<int>(s => s.ID_ChucVu);
            modelBuilder.Entity<HoaDon>()
                .HasRequired<User>(s => s.User)
                .WithMany(g => g.HoaDons)
                .HasForeignKey<int>(s => s.ID_User);
            modelBuilder.Entity<HoaDon>()
                .HasMany<MonAn>(s => s.MonAns)
                .WithMany(c => c.HoaDons)
                .Map(cs =>
                {
                    cs.MapLeftKey("ID_HoaDon");
                    cs.MapRightKey("ID_MonAn");
                    cs.ToTable("ChiTietHoaDon");
                });
            modelBuilder.Entity<ChiTietBan>()
                .HasRequired<MonAn>(s => s.MonAn)
                .WithMany(g => g.ChiTietBans)
                .HasForeignKey<int>(s => s.ID_MonAn);
            modelBuilder.Entity<ChiTietBan>()
                .HasRequired<Ban>(s => s.Ban)
                .WithMany(g => g.ChiTietBans)
                .HasForeignKey<int>(s => s.ID_Ban);
            modelBuilder.Entity<ChiTietMonAn>()
                .HasRequired<MonAn>(s => s.MonAn)
                .WithMany(g => g.ChiTietMonAns)
                .HasForeignKey<int>(s => s.ID_MonAn);
            modelBuilder.Entity<ChiTietMonAn>()
                .HasRequired<NguyenLieu>(s => s.NguyenLieu)
                .WithMany(g => g.ChiTietMonAns)
                .HasForeignKey<int>(s => s.ID_NguyenLieu);
            modelBuilder.Entity<NguyenLieu>()
                .HasRequired<LoaiNguyenLieu>(s => s.LoaiNguyenLieu)
                .WithMany(g => g.NguyenLieus)
                .HasForeignKey<int>(s => s.ID_LoaiNguyenLieu);
            modelBuilder.Entity<Kho>()
                .HasRequired<NguyenLieu>(s => s.NguyenLieu)
                .WithMany(g => g.Khoes)
                .HasForeignKey<int>(s => s.ID_NguyenLieu);
            modelBuilder.Entity<Kho>()
                .HasRequired<NhaCungCap>(s => s.NhaCungCap)
                .WithMany(g => g.Khoes)
                .HasForeignKey<int>(s => s.ID_NhaCungCap);
            modelBuilder.Entity<ChiTietNhaCungCap>()
                .HasRequired<NguyenLieu>(s => s.NguyenLieu)
                .WithMany(g => g.ChiTietNhaCungCaps)
                .HasForeignKey<int>(s => s.ID_NguyenLieu);
            modelBuilder.Entity<ChiTietNhaCungCap>()
                .HasRequired<NhaCungCap>(s => s.NhaCungCap)
                .WithMany(g => g.ChiTietNhaCungCaps)
                .HasForeignKey<int>(s => s.ID_NhaCungCap);
        }
    }
    // Add a DbSet for each entity type that you want to include in your model. For more information 
    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    // public virtual DbSet<MyEntity> MyEntities { get; set; }
}

//public class MyEntity
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}
