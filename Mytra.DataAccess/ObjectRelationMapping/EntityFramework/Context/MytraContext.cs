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
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-LUSNRB7; Database=MYTRA; TrustServerCertificate=True; Trusted_Connection=True; User Id = sa; password = 1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Announce>(entity =>
            {
                entity.ToTable("ANNOUNCE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("TITLE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<AnnounceDetail>(entity =>
            {
                entity.ToTable("ANNOUNCE DETAIL");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Announce).HasColumnName("ANNOUNCE");
                entity.Property(e => e.Detail)
                    .HasMaxLength(750)
                    .HasColumnName("DETAIL");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.AnnounceNavigation).WithMany(p => p.AnnounceDetails)
                    .HasForeignKey(d => d.Announce)
                    .HasConstraintName("FK_ANNOUNCE DETAIL_ANNOUNCE");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("CONTENT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Category).HasColumnName("CATEGORY");
                entity.Property(e => e.ContentType).HasColumnName("CONTENT TYPE");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Contents)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("FK_CONTENT_CATEGORY");

                entity.HasOne(d => d.ContentTypeNavigation).WithMany(p => p.Contents)
                    .HasForeignKey(d => d.ContentType)
                    .HasConstraintName("FK_CONTENT_CONTENT TYPE");
            });

            modelBuilder.Entity<ContentComment>(entity =>
            {
                entity.ToTable("CONTENT COMMENT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Content).HasColumnName("CONTENT");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
                entity.Property(e => e.User).HasColumnName("USER");

                entity.HasOne(d => d.ContentNavigation).WithMany(p => p.ContentComments)
                    .HasForeignKey(d => d.Content)
                    .HasConstraintName("FK_CONTENT COMMENT_CONTENT");

                entity.HasOne(d => d.UserNavigation).WithMany(p => p.ContentComments)
                    .HasForeignKey(d => d.User)
                    .HasConstraintName("FK_CONTENT COMMENT_USER");
            });

            modelBuilder.Entity<ContentDetail>(entity =>
            {
                entity.ToTable("CONTENT DETAIL");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<ContentLike>(entity =>
            {
                entity.ToTable("CONTENT LIKE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Content).HasColumnName("CONTENT");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
                entity.Property(e => e.User).HasColumnName("USER");

                entity.HasOne(d => d.ContentNavigation).WithMany(p => p.ContentLikes)
                    .HasForeignKey(d => d.Content)
                    .HasConstraintName("FK_CONTENT LIKE_CONTENT");

                entity.HasOne(d => d.UserNavigation).WithMany(p => p.ContentLikes)
                    .HasForeignKey(d => d.User)
                    .HasConstraintName("FK_CONTENT LIKE_USER");
            });

            modelBuilder.Entity<ContentPicture>(entity =>
            {
                entity.ToTable("CONTENT PICTURE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Content).HasColumnName("CONTENT");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.ContentNavigation).WithMany(p => p.ContentPictures)
                    .HasForeignKey(d => d.Content)
                    .HasConstraintName("FK_CONTENT PICTURE_CONTENT");
            });

            modelBuilder.Entity<ContentSettings>(entity =>
            {
                entity.ToTable("CONTENT SETTINGS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<ContentType>(entity =>
            {
                entity.ToTable("CONTENT TYPE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<Management>(entity =>
            {
                entity.ToTable("MANAGEMENT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Password)
                    .HasMaxLength(50)
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
                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<ManagementContact>(entity =>
            {
                entity.ToTable("MANAGEMENT CONTACT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Management).HasColumnName("MANAGEMENT");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.ManagementNavigation).WithMany(p => p.ManagementContacts)
                    .HasForeignKey(d => d.Management)
                    .HasConstraintName("FK_MANAGEMENT CONTACT_MANAGEMENT");
            });

            modelBuilder.Entity<ManagementDetail>(entity =>
            {
                entity.ToTable("MANAGEMENT DETAIL");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.IdNavigation).WithOne(p => p.ManagementDetail)
                    .HasForeignKey<ManagementDetail>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MANAGEMENT DETAIL_MANAGEMENT");
            });

            modelBuilder.Entity<ManagementSettings>(entity =>
            {
                entity.ToTable("MANAGEMENT SETTINGS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.IdNavigation).WithOne(p => p.ManagementSetting)
                    .HasForeignKey<ManagementSettings>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MANAGEMENT SETTINGS_MANAGEMENT");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("PERMISSION");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<PermissionDetail>(entity =>
            {
                entity.ToTable("PERMISSION DETAIL");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Permission).HasColumnName("PERMISSION");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.PermissionNavigation).WithMany(p => p.PermissionDetails)
                    .HasForeignKey(d => d.Permission)
                    .HasConstraintName("FK_PERMISSION DETAIL_PERMISSION");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.ToTable("SURVEY");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<SurveyDetail>(entity =>
            {
                entity.ToTable("SURVEY DETAIL");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.Survey).HasColumnName("SURVEY");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
                entity.Property(e => e.User).HasColumnName("USER");

                entity.HasOne(d => d.SurveyNavigation).WithMany(p => p.SurveyDetails)
                    .HasForeignKey(d => d.Survey)
                    .HasConstraintName("FK_SURVEY DETAIL_SURVEY");

                entity.HasOne(d => d.UserNavigation).WithMany(p => p.SurveyDetails)
                    .HasForeignKey(d => d.User)
                    .HasConstraintName("FK_SURVEY DETAIL_USER");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USER");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Password)
                    .HasMaxLength(50)
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
                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<UserContact>(entity =>
            {
                entity.ToTable("USER CONTACT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
                entity.Property(e => e.User).HasColumnName("USER");

                entity.HasOne(d => d.UserNavigation).WithMany(p => p.UserContacts)
                    .HasForeignKey(d => d.User)
                    .HasConstraintName("FK_USER CONTACT_USER");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.ToTable("USER DETAIL");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.IdNavigation).WithOne(p => p.UserDetail)
                    .HasForeignKey<UserDetail>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USER DETAIL_USER");
            });

            modelBuilder.Entity<UserEmail>(entity =>
            {
                entity.ToTable("USER EMAIL");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
                entity.Property(e => e.User).HasColumnName("USER");

                entity.HasOne(d => d.UserNavigation).WithMany(p => p.UserEmails)
                    .HasForeignKey(d => d.User)
                    .HasConstraintName("FK_USER EMAIL_USER");
            });

            modelBuilder.Entity<UserSettings>(entity =>
            {
                entity.ToTable("USER SETTINGS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.IdNavigation).WithOne(p => p.UserSetting)
                    .HasForeignKey<UserSettings>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USER SETTINGS_USER");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}