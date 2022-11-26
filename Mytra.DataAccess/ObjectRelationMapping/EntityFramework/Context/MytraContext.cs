namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;

    public partial class MytraContext : DbContext
    {
        public MytraContext() { }
        public MytraContext(DbContextOptions<MytraContext> options) : base(options) { }

        public virtual DbSet<Announce> Announces { get; set; } = null!;
        public virtual DbSet<AnnounceDetail> AnnounceDetails { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<ContentComment> ContentComments { get; set; } = null!;
        public virtual DbSet<ContentDetail> ContentDetails { get; set; } = null!;
        public virtual DbSet<ContentLike> ContentLikes { get; set; } = null!;
        public virtual DbSet<ContentPicture> ContentPictures { get; set; } = null!;
        public virtual DbSet<Content> Contents { get; set; } = null!;
        public virtual DbSet<ContentSettings> ContentSettings { get; set; } = null!;
        public virtual DbSet<ContentType> ContentTypes { get; set; } = null!;
        public virtual DbSet<ManagementContact> ManagementContacts { get; set; } = null!;
        public virtual DbSet<ManagementDetail> ManagementDetails { get; set; } = null!;
        public virtual DbSet<Management> Managements { get; set; } = null!;
        public virtual DbSet<ManagementSettings> ManagementSettings { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<PermissionDetail> PermissionDetails { get; set; } = null!;
        public virtual DbSet<Survey> Surveys { get; set; } = null!;
        public virtual DbSet<UserContact> UserContacts { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;
        public virtual DbSet<UserEmail> UserEmails { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserSettings> UserSettings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-3MT9N8N\SQLSERVER; Database=JOBHUMAN; User Id = sa; password = 1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Ability>(entity =>
            //{
            //    entity.ToTable("ABILITIES");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(500)
            //        .HasColumnName("NAME");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");
            //});

            //modelBuilder.Entity<Announce>(entity =>
            //{
            //    entity.ToTable("ANNOUNCE");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.AnnounceDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("ANNOUNCE DATE");

            //    entity.Property(e => e.Company).HasColumnName("COMPANY");

            //    entity.Property(e => e.CreatedByUser).HasColumnName("CREATED BY USER");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Occupation).HasColumnName("OCCUPATION");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(250)
            //        .HasColumnName("TITLE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.UpdatedByUser).HasColumnName("UPDATED BY USER");

            //    entity.HasOne(d => d.CompanyNavigation)
            //        .WithMany(p => p.Announces)
            //        .HasForeignKey(d => d.Company)
            //        .HasConstraintName("FK_ANNOUNCE_COMPANY");

            //    entity.HasOne(d => d.CreatedByUserNavigation)
            //        .WithMany(p => p.AnnounceCreatedByUserNavigations)
            //        .HasForeignKey(d => d.CreatedByUser)
            //        .HasConstraintName("FK_ANNOUNCE_USER");

            //    entity.HasOne(d => d.IdNavigation)
            //        .WithOne(p => p.Announce)
            //        .HasForeignKey<Announce>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_ANNOUNCE_ANNOUNCE DETAIL");

            //    entity.HasOne(d => d.OccupationNavigation)
            //        .WithMany(p => p.Announces)
            //        .HasForeignKey(d => d.Occupation)
            //        .HasConstraintName("FK_ANNOUNCE_OCCUPATION");

            //    entity.HasOne(d => d.UpdatedByUserNavigation)
            //        .WithMany(p => p.AnnounceUpdatedByUserNavigations)
            //        .HasForeignKey(d => d.UpdatedByUser)
            //        .HasConstraintName("FK_ANNOUNCE_USER1");
            //});

            //modelBuilder.Entity<AnnounceDetail>(entity =>
            //{
            //    entity.ToTable("ANNOUNCE DETAIL");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Content)
            //        .HasMaxLength(2500)
            //        .HasColumnName("CONTENT");

            //    entity.Property(e => e.CreatedByUser).HasColumnName("CREATED BY USER");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Picture)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("PICTURE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.UpdatedByUser).HasColumnName("UPDATED BY USER");

            //    entity.HasOne(d => d.CreatedByUserNavigation)
            //        .WithMany(p => p.AnnounceDetailCreatedByUserNavigations)
            //        .HasForeignKey(d => d.CreatedByUser)
            //        .HasConstraintName("FK_ANNOUNCE DETAIL_USER");

            //    entity.HasOne(d => d.UpdatedByUserNavigation)
            //        .WithMany(p => p.AnnounceDetailUpdatedByUserNavigations)
            //        .HasForeignKey(d => d.UpdatedByUser)
            //        .HasConstraintName("FK_ANNOUNCE DETAIL_USER1");
            //});

            //modelBuilder.Entity<Appeal>(entity =>
            //{
            //    entity.ToTable("APPEAL");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Announce).HasColumnName("ANNOUNCE");

            //    entity.Property(e => e.AppealDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("APPEAL DATE");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.User).HasColumnName("USER");

            //    entity.HasOne(d => d.AnnounceNavigation)
            //        .WithMany(p => p.Appeals)
            //        .HasForeignKey(d => d.Announce)
            //        .HasConstraintName("FK_APPEAL_ANNOUNCE");

            //    entity.HasOne(d => d.UserNavigation)
            //        .WithMany(p => p.Appeals)
            //        .HasForeignKey(d => d.User)
            //        .HasConstraintName("FK_APPEAL_USER");
            //});

            //modelBuilder.Entity<AppealDetail>(entity =>
            //{
            //    entity.ToTable("APPEAL DETAIL");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Description)
            //        .HasMaxLength(500)
            //        .HasColumnName("DESCRIPTION");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.HasOne(d => d.IdNavigation)
            //        .WithOne(p => p.AppealDetail)
            //        .HasForeignKey<AppealDetail>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_APPEAL DETAIL_APPEAL");
            //});

            //modelBuilder.Entity<Certificate>(entity =>
            //{
            //    entity.ToTable("CERTIFICATES");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Company).HasColumnName("COMPANY");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(250)
            //        .HasColumnName("NAME");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.HasOne(d => d.CompanyNavigation)
            //        .WithMany(p => p.Certificates)
            //        .HasForeignKey(d => d.Company)
            //        .HasConstraintName("FK_CERTIFICATES_COMPANY");
            //});

            //modelBuilder.Entity<College>(entity =>
            //{
            //    entity.ToTable("COLLEGES");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(100)
            //        .HasColumnName("NAME");

            //    entity.Property(e => e.Region).HasColumnName("REGION");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //    .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");
            //});

            //modelBuilder.Entity<Company>(entity =>
            //{
            //    entity.ToTable("COMPANY");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("EMAIL");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Password)
            //        .HasMaxLength(100)
            //        .HasColumnName("PASSWORD");

            //    entity.Property(e => e.RefreshToken)
            //        .HasMaxLength(200)
            //        .HasColumnName("REFRESH TOKEN");

            //    entity.Property(e => e.RefreshValidDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REFRESH VALID DATE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.HasOne(d => d.IdNavigation)
            //        .WithOne(p => p.Company)
            //        .HasForeignKey<Company>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_COMPANY_COMPANY ABOUT");

            //    entity.HasOne(d => d.Id1)
            //        .WithOne(p => p.Company)
            //        .HasForeignKey<Company>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_COMPANY_COMPANY DETAIL");

            //    entity.HasOne(d => d.Id2)
            //        .WithOne(p => p.Company)
            //        .HasForeignKey<Company>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_COMPANY_COMPANY SETTINGS");

            //    entity.HasOne(d => d.Id3)
            //        .WithOne(p => p.Company)
            //        .HasForeignKey<Company>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_COMPANY_COMPANY VIDEO");
            //});

            //modelBuilder.Entity<CompanyAbout>(entity =>
            //{
            //    entity.ToTable("COMPANY ABOUT");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.About)
            //        .HasMaxLength(2000)
            //        .HasColumnName("ABOUT");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");
            //});

            //modelBuilder.Entity<CompanyDetail>(entity =>
            //{
            //    entity.ToTable("COMPANY DETAIL");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Detail)
            //        .HasMaxLength(500)
            //        .HasColumnName("DETAIL");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");
            //});

            //modelBuilder.Entity<CompanyFollower>(entity =>
            //{
            //    entity.ToTable("COMPANY FOLLOWER");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Company).HasColumnName("COMPANY");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.User).HasColumnName("USER");

            //    entity.HasOne(d => d.CompanyNavigation)
            //        .WithMany(p => p.CompanyFollowers)
            //        .HasForeignKey(d => d.Company)
            //        .HasConstraintName("FK_COMPANY FOLLOWER_COMPANY");

            //    entity.HasOne(d => d.UserNavigation)
            //        .WithMany(p => p.CompanyFollowers)
            //        .HasForeignKey(d => d.User)
            //        .HasConstraintName("FK_COMPANY FOLLOWER_USER");
            //});

            //modelBuilder.Entity<CompanySettings>(entity =>
            //{
            //    entity.ToTable("COMPANY SETTINGS");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");
            //});

            //modelBuilder.Entity<CompanyVideo>(entity =>
            //{
            //    entity.ToTable("COMPANY VIDEO");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.Video)
            //        .HasMaxLength(250)
            //        .IsUnicode(false)
            //        .HasColumnName("VIDEO");
            //});

            //modelBuilder.Entity<Management>(entity =>
            //{
            //    entity.ToTable("MANAGEMENT");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("EMAIL");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Password)
            //        .HasMaxLength(100)
            //        .HasColumnName("PASSWORD");

            //    entity.Property(e => e.RefreshToken)
            //        .HasMaxLength(200)
            //        .HasColumnName("REFRESH TOKEN");

            //    entity.Property(e => e.RefreshValidDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REFRESH VALID DATE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");
            //});

            //modelBuilder.Entity<MessageBox>(entity =>
            //{
            //    entity.ToTable("MESSAGE BOX");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Msg).HasColumnName("MSG");

            //    entity.Property(e => e.MsgDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("MSG DATE");

            //    entity.Property(e => e.Read).HasColumnName("READ");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.SendTo).HasColumnName("SEND TO");

            //    entity.Property(e => e.Sender).HasColumnName("SENDER");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.HasOne(d => d.SendToNavigation)
            //        .WithMany(p => p.MessageBoxSendToNavigations)
            //        .HasForeignKey(d => d.SendTo)
            //        .HasConstraintName("FK_MESSAGE BOX_USER1");

            //    entity.HasOne(d => d.SenderNavigation)
            //        .WithMany(p => p.MessageBoxSenderNavigations)
            //        .HasForeignKey(d => d.Sender)
            //        .HasConstraintName("FK_MESSAGE BOX_USER");
            //});

            //modelBuilder.Entity<Network>(entity =>
            //{
            //    entity.ToTable("NETWORK");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Company).HasColumnName("COMPANY");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.ShareDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("SHARE DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.User).HasColumnName("USER");
            //});

            //modelBuilder.Entity<Occupation>(entity =>
            //{
            //    entity.ToTable("OCCUPATION");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(100)
            //        .HasColumnName("NAME");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");
            //});

            //modelBuilder.Entity<Position>(entity =>
            //{
            //    entity.ToTable("POSITIONS");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(100)
            //        .HasColumnName("NAME");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");
            //});

            //modelBuilder.Entity<Region>(entity =>
            //{
            //    entity.ToTable("REGION");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(80)
            //        .HasColumnName("NAME");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.Sub).HasColumnName("SUB");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.HasOne(d => d.SubNavigation)
            //        .WithMany(p => p.InverseSubNavigation)
            //        .HasForeignKey(d => d.Sub)
            //        .HasConstraintName("FK_REGION_REGION");
            //});

            //modelBuilder.Entity<Survey>(entity =>
            //{
            //    entity.ToTable("SURVEY");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Company).HasColumnName("COMPANY");

            //    entity.Property(e => e.Content)
            //        .HasMaxLength(200)
            //        .HasColumnName("CONTENT");

            //    entity.Property(e => e.ContentType).HasColumnName("CONTENT TYPE");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.Sub).HasColumnName("SUB");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.User).HasColumnName("USER");

            //    entity.HasOne(d => d.CompanyNavigation)
            //        .WithMany(p => p.Surveys)
            //        .HasForeignKey(d => d.Company)
            //        .HasConstraintName("FK_SURVEY_COMPANY");

            //    entity.HasOne(d => d.SubNavigation)
            //        .WithMany(p => p.InverseSubNavigation)
            //        .HasForeignKey(d => d.Sub)
            //        .HasConstraintName("FK_SURVEY_SURVEY");

            //    entity.HasOne(d => d.UserNavigation)
            //        .WithMany(p => p.Surveys)
            //        .HasForeignKey(d => d.User)
            //        .HasConstraintName("FK_SURVEY_USER");
            //});

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USER");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.RefreshToken)
                    .HasMaxLength(50)
                    .HasColumnName("REFRESH TOKEN");

                entity.Property(e => e.RefreshValidDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REFRESH VALID DATE");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
            });

            //modelBuilder.Entity<UserAbility>(entity =>
            //{
            //    entity.ToTable("USER ABILITY");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Ability).HasColumnName("ABILITY");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.User).HasColumnName("USER");

            //    entity.HasOne(d => d.AbilityNavigation)
            //        .WithMany(p => p.UserAbilities)
            //        .HasForeignKey(d => d.Ability)
            //        .HasConstraintName("FK_USER ABILITY_ABILITIES");

            //    entity.HasOne(d => d.UserNavigation)
            //        .WithMany(p => p.UserAbilities)
            //        .HasForeignKey(d => d.User)
            //        .HasConstraintName("FK_USER ABILITY_USER");
            //});

            //modelBuilder.Entity<UserAbout>(entity =>
            //{
            //    entity.ToTable("USER ABOUT");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.About)
            //        .HasMaxLength(2000)
            //        .HasColumnName("ABOUT");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.User).HasColumnName("USER");

            //    entity.HasOne(d => d.UserNavigation)
            //        .WithMany(p => p.UserAbouts)
            //        .HasForeignKey(d => d.User)
            //        .HasConstraintName("FK_USER ABOUT_USER");
            //});

            //modelBuilder.Entity<UserCertificate>(entity =>
            //{
            //    entity.ToTable("USER CERTIFICATE");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Certificate).HasColumnName("CERTIFICATE");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.User).HasColumnName("USER");

            //    entity.HasOne(d => d.CertificateNavigation)
            //        .WithMany(p => p.UserCertificates)
            //        .HasForeignKey(d => d.Certificate)
            //        .HasConstraintName("FK_USER CERTIFICATE_CERTIFICATES");

            //    entity.HasOne(d => d.UserNavigation)
            //        .WithMany(p => p.UserCertificates)
            //        .HasForeignKey(d => d.User)
            //        .HasConstraintName("FK_USER CERTIFICATE_USER1");
            //});

            //modelBuilder.Entity<UserDetail>(entity =>
            //{
            //    entity.ToTable("USER DETAIL");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.Region).HasColumnName("REGION");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.HasOne(d => d.IdNavigation)
            //        .WithOne(p => p.UserDetail)
            //        .HasForeignKey<UserDetail>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_USER DETAIL_USER");

            //    entity.HasOne(d => d.RegionNavigation)
            //        .WithMany(p => p.UserDetails)
            //        .HasForeignKey(d => d.Region)
            //        .HasConstraintName("FK_USER DETAIL_REGION");
            //});

            //modelBuilder.Entity<UserEducation>(entity =>
            //{
            //    entity.ToTable("USER EDUCATION");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive)
            //        .HasMaxLength(10)
            //        .HasColumnName("IS ACTIVE")
            //        .IsFixedLength();

            //    entity.Property(e => e.RegisterDate)
            //        .HasMaxLength(10)
            //        .HasColumnName("REGISTER DATE")
            //        .IsFixedLength();

            //    entity.Property(e => e.UpdateDate)
            //        .HasMaxLength(10)
            //        .HasColumnName("UPDATE DATE")
            //        .IsFixedLength();
            //});

            //modelBuilder.Entity<UserExperience>(entity =>
            //{
            //    entity.ToTable("USER EXPERIENCE");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Company).HasColumnName("COMPANY");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.User).HasColumnName("USER");

            //    entity.HasOne(d => d.CompanyNavigation)
            //        .WithMany(p => p.UserExperiences)
            //        .HasForeignKey(d => d.Company)
            //        .HasConstraintName("FK_USER EXPERIENCE_COMPANY");

            //    entity.HasOne(d => d.UserNavigation)
            //        .WithMany(p => p.UserExperiences)
            //        .HasForeignKey(d => d.User)
            //        .HasConstraintName("FK_USER EXPERIENCE_USER");
            //});

            //modelBuilder.Entity<UserFollower>(entity =>
            //{
            //    entity.ToTable("USER FOLLOWER");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Follower).HasColumnName("FOLLOWER");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.User).HasColumnName("USER");

            //    entity.HasOne(d => d.FollowerNavigation)
            //        .WithMany(p => p.UserFollowerFollowerNavigations)
            //        .HasForeignKey(d => d.Follower)
            //        .HasConstraintName("FK_USER FOLLOWER_USER1");

            //    entity.HasOne(d => d.UserNavigation)
            //        .WithMany(p => p.UserFollowerUserNavigations)
            //        .HasForeignKey(d => d.User)
            //        .HasConstraintName("FK_USER FOLLOWER_USER");
            //});

            //modelBuilder.Entity<UserLanguage>(entity =>
            //{
            //    entity.ToTable("USER LANGUAGE");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.HasOne(d => d.IdNavigation)
            //        .WithOne(p => p.UserLanguage)
            //        .HasForeignKey<UserLanguage>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_USER LANGUAGE_USER");
            //});

            //modelBuilder.Entity<UserReferance>(entity =>
            //{
            //    entity.ToTable("USER REFERANCE");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive)
            //        .HasMaxLength(10)
            //        .HasColumnName("IS ACTIVE")
            //        .IsFixedLength();

            //    entity.Property(e => e.Position).HasColumnName("POSITION");

            //    entity.Property(e => e.RegisterDate)
            //        .HasMaxLength(10)
            //        .HasColumnName("REGISTER DATE")
            //        .IsFixedLength();

            //    entity.Property(e => e.UpdateDate)
            //        .HasMaxLength(10)
            //        .HasColumnName("UPDATE DATE")
            //        .IsFixedLength();

            //    entity.Property(e => e.User).HasColumnName("USER");
            //});

            //modelBuilder.Entity<UserSettings>(entity =>
            //{
            //    entity.ToTable("USER SETTINGS");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.HasOne(d => d.IdNavigation)
            //        .WithOne(p => p.UserSettings)
            //        .HasForeignKey<UserSettings>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_USER SETTINGS_USER");
            //});

            //modelBuilder.Entity<UserVideo>(entity =>
            //{
            //    entity.ToTable("USER VIDEO");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");

            //    entity.Property(e => e.RegisterDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("REGISTER DATE");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("UPDATE DATE");

            //    entity.Property(e => e.Video)
            //        .HasMaxLength(150)
            //        .IsUnicode(false)
            //        .HasColumnName("VIDEO");

            //    entity.HasOne(d => d.IdNavigation)
            //        .WithOne(p => p.UserVideo)
            //        .HasForeignKey<UserVideo>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_USER VIDEO_USER");
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}