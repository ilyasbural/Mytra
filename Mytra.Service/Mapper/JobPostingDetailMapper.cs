namespace Mytra.Service
{
	public class JobPostingDetailMapper : AutoMapper.Profile
	{
		public JobPostingDetailMapper()
		{
			CreateMap<Utilize.JobPostingDetailInsert, Core.JobPostingDetail>().ReverseMap();
			CreateMap<Utilize.JobPostingDetailUpdate, Core.JobPostingDetail>().ReverseMap();
			CreateMap<Utilize.JobPostingDetailSelect, Core.JobPostingDetail>().ReverseMap();
			CreateMap<Utilize.JobPostingDetailSelectSingle, Core.JobPostingDetail>().ReverseMap();
			CreateMap<Utilize.JobPostingDetailResponse, Core.JobPostingDetail>().ReverseMap();
		}
	}
}