namespace Mytra.Service
{
	public class JobPostingApplyMapper : AutoMapper.Profile
	{
		public JobPostingApplyMapper()
		{
			CreateMap<Utilize.JobPostingApplyInsert, Core.JobPostingApply>().ReverseMap();
			CreateMap<Utilize.JobPostingApplyUpdate, Core.JobPostingApply>().ReverseMap();
			CreateMap<Utilize.JobPostingApplySelect, Core.JobPostingApply>().ReverseMap();
			CreateMap<Utilize.JobPostingApplySelectSingle, Core.JobPostingApply>().ReverseMap();
			CreateMap<Utilize.JobPostingApplyResponse, Core.JobPostingApply>().ReverseMap();
		}
	}
}