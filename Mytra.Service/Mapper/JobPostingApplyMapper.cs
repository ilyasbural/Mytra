namespace Mytra.Service
{
	public class JobPostingApplyMapper : AutoMapper.Profile
	{
		public JobPostingApplyMapper()
		{
			CreateMap<Common.JobPostingApplyInsert, Core.JobPostingApply>().ReverseMap();
			CreateMap<Common.JobPostingApplyUpdate, Core.JobPostingApply>().ReverseMap();
			CreateMap<Common.JobPostingApplySelect, Core.JobPostingApply>().ReverseMap();
			CreateMap<Common.JobPostingApplySelectSingle, Core.JobPostingApply>().ReverseMap();
			CreateMap<Common.JobPostingApplyResponse, Core.JobPostingApply>().ReverseMap();
		}
	}
}