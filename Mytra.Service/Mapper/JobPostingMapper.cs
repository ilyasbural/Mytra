namespace Mytra.Service
{
	public class JobPostingMapper : AutoMapper.Profile
	{
		public JobPostingMapper()
		{
			CreateMap<Common.JobPostingInsert, Core.JobPosting>().ReverseMap();
			CreateMap<Common.JobPostingUpdate, Core.JobPosting>().ReverseMap();
			CreateMap<Common.JobPostingDelete, Core.JobPosting>().ReverseMap();
			CreateMap<Common.JobPostingSelect, Core.JobPosting>().ReverseMap();
			CreateMap<Common.JobPostingSelectSingle, Core.JobPosting>().ReverseMap();
		}
	}
}