namespace Mytra.Service
{
	public class JobPostingDetailMapper : AutoMapper.Profile
	{
		public JobPostingDetailMapper()
		{
			CreateMap<Common.JobPostingDetailInsert, Core.JobPostingDetail>().ReverseMap();
			CreateMap<Common.JobPostingDetailUpdate, Core.JobPostingDetail>().ReverseMap();
			CreateMap<Common.JobPostingDetailDelete, Core.JobPostingDetail>().ReverseMap();
			CreateMap<Common.JobPostingDetailSelect, Core.JobPostingDetail>().ReverseMap();
			CreateMap<Common.JobPostingDetailSelectSingle, Core.JobPostingDetail>().ReverseMap();
		}
	}
}