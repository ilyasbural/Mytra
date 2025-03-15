namespace Mytra.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    public class MytraContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserSettings> UserSettings { get; set; }
        public virtual DbSet<UserAuthentication> UserAuthentications { get; set; }

        public MytraContext() { }
        public MytraContext(DbContextOptions<MytraContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            if (!OptionsBuilder.IsConfigured)
            {
                OptionsBuilder.UseSqlServer(@"Server = 192.168.1.100; Database= Mytra; User Id = sa; Password = oxLwep2bc1FiUKQsPCK9xoztwr8eATK0EHM6TuO8cWGL4QJmTa; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.ApplyConfiguration(new UserAuthenticationMapping());
        }
    }
}