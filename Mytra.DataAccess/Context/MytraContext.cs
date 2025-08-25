namespace Mytra.DataAccess
{
	using Core;
	using Microsoft.EntityFrameworkCore;

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
		public virtual DbSet<Manager> Managers { get; set; }
		public virtual DbSet<ManagerDetail> ManagerDetails { get; set; }
		public virtual DbSet<ManagerSettings> ManagerSettings { get; set; }
		public virtual DbSet<ManagerAuthentication> ManagerAuthentications { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<UserDetail> UserDetails { get; set; }
		public virtual DbSet<UserSettings> UserSettings { get; set; }
		public virtual DbSet<UserAuthentication> UserAuthentications { get; set; }
		public virtual DbSet<College> Colleges { get; set; }
		public virtual DbSet<Institution> Institutions { get; set; }
		public virtual DbSet<Language> Languages { get; set; }
		public virtual DbSet<Skills> Skills { get; set; }

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
			ModelBuilder.ApplyConfiguration(new CandidateMapping());
			ModelBuilder.ApplyConfiguration(new CandidatePhotoMapping());
			ModelBuilder.ApplyConfiguration(new CandidateDetailMapping());
			ModelBuilder.ApplyConfiguration(new CandidateSkillsMapping());
			ModelBuilder.ApplyConfiguration(new CandidateContactMapping());
			ModelBuilder.ApplyConfiguration(new CandidateLanguageMapping());
			ModelBuilder.ApplyConfiguration(new CandidateSettingsMapping());
			ModelBuilder.ApplyConfiguration(new CandidateEducationMapping());
			ModelBuilder.ApplyConfiguration(new CandidateReferanceMapping());
			ModelBuilder.ApplyConfiguration(new CandidateExperienceMapping());
			ModelBuilder.ApplyConfiguration(new CandidateCertificateMapping());
			ModelBuilder.ApplyConfiguration(new CandidateAuthenticationMapping());
			ModelBuilder.ApplyConfiguration(new JobPostingMapping());
			ModelBuilder.ApplyConfiguration(new JobPostingDetailMapping());
			ModelBuilder.ApplyConfiguration(new JobPostingApplyMapping());
			ModelBuilder.ApplyConfiguration(new JobPostingVisitMapping());
			ModelBuilder.ApplyConfiguration(new ManagerMapping());
			ModelBuilder.ApplyConfiguration(new ManagerDetailMapping());
			ModelBuilder.ApplyConfiguration(new ManagerSettingsMapping());
			ModelBuilder.ApplyConfiguration(new ManagerAuthenticationMapping());
			ModelBuilder.ApplyConfiguration(new UserMapping());
			ModelBuilder.ApplyConfiguration(new UserDetailMapping());
			ModelBuilder.ApplyConfiguration(new UserSettingsMapping());
			ModelBuilder.ApplyConfiguration(new UserAuthenticationMapping());
			ModelBuilder.ApplyConfiguration(new CollegeMapping());
			ModelBuilder.ApplyConfiguration(new InstitutionMapping());
			ModelBuilder.ApplyConfiguration(new LanguageMapping());
			ModelBuilder.ApplyConfiguration(new SkillsMapping());
		}
	}
}