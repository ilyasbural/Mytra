namespace Mytra.DataAccess
{
	using Core;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Configuration;

	public class MytraContext : DbContext
	{
		public virtual DbSet<Candidate> Candidates { get; set; }
		public virtual DbSet<CandidatePhoto> CandidatePhotos { get; set; }
		public virtual DbSet<CandidateDetail> CandidateDetails { get; set; }
		public virtual DbSet<CandidateSkills> CandidateSkills { get; set; }
		public virtual DbSet<CandidateContact> CandidateContacts { get; set; }
		public virtual DbSet<CandidateLanguage> CandidateLanguages { get; set; }
		public virtual DbSet<CandidateSettings> CandidateSettings { get; set; }
		public virtual DbSet<CandidateEducation> CandidateEducations { get; set; }
		public virtual DbSet<CandidateReferance> CandidateReferances { get; set; }
		public virtual DbSet<CandidateExperience> CandidateExperiences { get; set; }
		public virtual DbSet<CandidateCertificate> CandidateCertificates { get; set; }
		public virtual DbSet<CandidateAuthentication> CandidateAuthentications { get; set; }
		public virtual DbSet<JobPosting> JobPostings { get; set; }
		public virtual DbSet<JobPostingDetail> JobPostingDetails { get; set; }
		public virtual DbSet<JobPostingApply> JobPostingApplies { get; set; }
		public virtual DbSet<JobPostingVisit> JobPostingVisits { get; set; }
		public virtual DbSet<College> Colleges { get; set; }
		public virtual DbSet<Institution> Institutions { get; set; }
		public virtual DbSet<Language> Languages { get; set; }
		public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<ManagerDetail> ManagerDetails { get; set; }
        public virtual DbSet<ManagerSettings> ManagerSettings { get; set; }
        public virtual DbSet<ManagerAuthentication> ManagerAuthentications { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserSettings> UserSettings { get; set; }
        public virtual DbSet<UserAuthentication> UserAuthentications { get; set; }

        public MytraContext() { }
		public MytraContext(DbContextOptions<MytraContext> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			IConfigurationRoot Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
			optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReferance).Assembly);
	}
}