namespace Mytra.Service
{
	public class JobPostingMapper : AutoMapper.Profile
	{
		public JobPostingMapper()
		{
			CreateMap<Utilize.JobPostingInsert, Core.JobPosting>().ReverseMap();
			CreateMap<Utilize.JobPostingUpdate, Core.JobPosting>().ReverseMap();
			CreateMap<Utilize.JobPostingSelect, Core.JobPosting>().ReverseMap();
			CreateMap<Utilize.JobPostingSelectSingle, Core.JobPosting>().ReverseMap();
			CreateMap<Utilize.JobPostingResponse, Core.JobPosting>().ReverseMap();
		}
	}
}